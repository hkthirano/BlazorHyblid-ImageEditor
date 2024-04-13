using System.Text.Json.Serialization;

namespace BlazorHyblid_ImageEditor.Models
{
    public class ImageListInfo
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("totalHits")]
        public int TotalHits { get; set; }

        [JsonPropertyName("hits")]
        public List<Image> Hits { get; set; } = [];
    }

    public class Image
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("pageURL")]
        public string? PageURL { get; set; }

        [JsonPropertyName("previewURL")]
        public string? PreviewURL { get; set; }

        [JsonPropertyName("webformatURL")]
        public string? WebformatURL { get; set; }

        [JsonPropertyName("largeImageURL")]
        public string? LargeImageURL { get; set; }

        [JsonPropertyName("views")]
        public int Views { get; set; }

        [JsonPropertyName("downloads")]
        public int Downloads { get; set; }

        [JsonPropertyName("likes")]
        public int Likes { get; set; }

        [JsonPropertyName("comments")]
        public int Comments { get; set; }

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        [JsonPropertyName("user")]
        public string? User { get; set; }

        [JsonPropertyName("userImageURL")]
        public string? UserImageURL { get; set; }
    }
}
