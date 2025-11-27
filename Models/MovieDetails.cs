using System.Text.Json.Serialization;
namespace MovieApp.Models;
public class MovieDetail
{
    [JsonPropertyName("Title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("Year")]
    public string Year { get; set; } = string.Empty;

    [JsonPropertyName("Rated")]
    public string Rated { get; set; } = string.Empty;

    [JsonPropertyName("Released")]
    public string Released { get; set; } = string.Empty;

    [JsonPropertyName("Runtime")]
    public string Runtime { get; set; } = string.Empty;

    [JsonPropertyName("Genre")]
    public string Genre { get; set; } = string.Empty;

    [JsonPropertyName("Director")]
    public string Director { get; set; } = string.Empty;

    [JsonPropertyName("Writer")]
    public string Writer { get; set; } = string.Empty;

    [JsonPropertyName("Actors")]
    public string Actors { get; set; } = string.Empty;

    [JsonPropertyName("Plot")]
    public string Plot { get; set; } = string.Empty;

    [JsonPropertyName("Language")]
    public string Language { get; set; } = string.Empty;

    [JsonPropertyName("Country")]
    public string Country { get; set; } = string.Empty;

    [JsonPropertyName("Awards")]
    public string Awards { get; set; } = string.Empty;

    [JsonPropertyName("Poster")]
    public string Poster { get; set; } = string.Empty;

    [JsonPropertyName("imdbRating")]
    public string ImdbRating { get; set; } = string.Empty;

    [JsonPropertyName("Metascore")]
    public string? Metascore { get; set; }

    [JsonPropertyName("imdbID")]
    public string ImdbID { get; set; } = string.Empty;

    [JsonPropertyName("Type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("Response")]
    public string Response { get; set; } = string.Empty;

    [JsonPropertyName("Error")]
    public string? Error { get; set; }
}

