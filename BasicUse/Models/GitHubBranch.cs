﻿using System.Text.Json.Serialization;

namespace HttpClientFactory.Models
{
    public class GitHubBranch
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("commit")]
        public Commit Commit { get; set; }

        [JsonPropertyName("protected")]
        public bool Protected { get; set; }
    }

    public class Commit
    {
        [JsonPropertyName("sha")]
        public string Sha { get; set; }

        [JsonPropertyName("url")]
        public Uri url { get; set; }
    }
}