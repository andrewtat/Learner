using System;
using System.Collections.Generic;
using InstagramAPIExplorer.Models;

using RestSharp.Serializers;
using RestSharp.Deserializers;
using Newtonsoft.Json;

namespace InstagramAPIExplorer.Models
{
    public class User
    {
        [DeserializeAs(Name = "data")]
        public List<Post> UserMedia { get; set; }

        public User()
        {
        }
    }
}
