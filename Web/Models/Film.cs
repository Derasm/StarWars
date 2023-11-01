namespace Web.Models
{
    namespace Web.models
    {
        using System;
        using System.Collections.Generic;

        using System.Text.Json;
        using System.Text.Json.Serialization;
        using System.Globalization;

        public partial class Film
        {
            [JsonPropertyName("count")]
            public long Count { get; set; }

            [JsonPropertyName("next")]
            public object Next { get; set; }

            [JsonPropertyName("previous")]
            public object Previous { get; set; }

            [JsonPropertyName("results")]
            public List<Result> Results { get; set; }
        }

        public partial class Result
        {
            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("episode_id")]
            public long EpisodeId { get; set; }

            [JsonPropertyName("opening_crawl")]
            public string OpeningCrawl { get; set; }

            [JsonPropertyName("director")]
            public string Director { get; set; }

            [JsonPropertyName("producer")]
            public string Producer { get; set; }

            [JsonPropertyName("release_date")]
            public DateTimeOffset ReleaseDate { get; set; }

            [JsonPropertyName("characters")]
            public List<Uri> Characters { get; set; }

            [JsonPropertyName("planets")]
            public List<Uri> Planets { get; set; }

            [JsonPropertyName("starships")]
            public List<Uri> Starships { get; set; }

            [JsonPropertyName("vehicles")]
            public List<Uri> Vehicles { get; set; }

            [JsonPropertyName("species")]
            public List<Uri> Species { get; set; }

            [JsonPropertyName("created")]
            public DateTimeOffset Created { get; set; }

            [JsonPropertyName("edited")]
            public DateTimeOffset Edited { get; set; }

            [JsonPropertyName("url")]
            public Uri Url { get; set; }
        }
    }
}
