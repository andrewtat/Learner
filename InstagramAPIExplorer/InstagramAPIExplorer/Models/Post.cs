using System;
using Newtonsoft.Json.Converters;
using RestSharp.Serializers;
using RestSharp.Deserializers;
using Newtonsoft.Json;

namespace InstagramAPIExplorer.Models
{
    public class Post
    {
        [DeserializeAs(Name = "id")]
        public string ID { get; set; }

        [DeserializeAs(Name = "media_url")]
        public string Url { get; set; }

        [DeserializeAs(Name = "media_type")]
        public string Type { get; set; }

        [DeserializeAs(Name = "like_count")]
        public int Likes { get; set; }

        [DeserializeAs(Name = "comments_count")]
        public int Comments { get; set; }

        [DeserializeAs(Name = "timestamp")]
        public DateTime Timestamp { get; set; }

        public Post()
        {
        }
    }
}
