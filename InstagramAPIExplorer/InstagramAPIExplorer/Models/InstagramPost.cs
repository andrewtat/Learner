using System;
using Newtonsoft.Json.Converters;
using RestSharp.Serializers;
using RestSharp.Deserializers;
using Newtonsoft.Json;

namespace InstagramAPIExplorer.Models
{
    public class InstagramPost
    {
        [DeserializeAs(Name = "id")]
        public string ID { get; set; }

        [DeserializeAs(Name = "media_url")]
        public string Url { get; set; }

        [DeserializeAs(Name = "media_type")]
        public string Type { get; set; }

        public InstagramPost()
        {
        }
    }
}
