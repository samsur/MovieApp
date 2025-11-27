using System.Text.Json;
using MovieApp.Models;
namespace MovieApp.Services;

public class OmdbMovieService : IMovieService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly string _baseUrl;

    public OmdbMovieService(
        HttpClient httpClient,
        IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["OmdbApi:ApiKey"]?? string.Empty;
        _baseUrl = configuration["OmdbApi:BaseUrl"] ?? "http://www.omdbapi.com/";
    }

    /// <summary>
    /// Searches for movies by title using the OMDb API
    /// </summary>
    public async Task<List<Movie>> SearchMoviesAsync(string searchTerm)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return new List<Movie>();
            }
            var url = $"{_baseUrl}?apikey={_apiKey}&s={Uri.EscapeDataString(searchTerm)}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var searchResponse = JsonSerializer.Deserialize<MovieSearchResponse>(content, 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (searchResponse?.Response == "True" && searchResponse.Search != null)
            {
                return searchResponse.Search;
            }
            else
            {
                return new List<Movie>();
            }
        }
        catch (HttpRequestException ex)
        {
            throw new InvalidOperationException("Failed to search for movies. Please check your internet connection.", ex);
        }
        catch (JsonException ex)
        {
            throw new InvalidOperationException("Failed to process movie search results.", ex);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public async Task<MovieDetail?> GetMovieDetailsAsync(string imdbId)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(imdbId))
            {
                return null;
            }

            var url = $"{_baseUrl}?apikey={_apiKey}&i={Uri.EscapeDataString(imdbId)}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var movieDetails = JsonSerializer.Deserialize<MovieDetail>(content, 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return movieDetails;
        }
        catch (HttpRequestException ex)
        {
            throw new InvalidOperationException("Failed to retrieve movie details. Please check your internet connection.", ex);
        }
        catch (JsonException ex)
        {
            throw new InvalidOperationException("Failed to process movie details.", ex);
        }
        catch (Exception)
        {
            throw;
        }
    }
}

