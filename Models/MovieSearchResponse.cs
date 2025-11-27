using System.Text.Json.Serialization;
namespace MovieApp.Models;
public class MovieSearchResponse
{
    [JsonPropertyName("Search")]
    public List<Movie>? Search { get; set; }

    [JsonPropertyName("totalResults")]
    public string? TotalResults { get; set; }

    [JsonPropertyName("Response")]
    public string Response { get; set; } = string.Empty;

    [JsonPropertyName("Error")]
    public string? Error { get; set; }
}

