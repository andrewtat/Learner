using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers;
using RestSharp.Deserializers;
using InstagramAPIExplorer.Models;
using Newtonsoft.Json;
using GcmSharp.Serialization;

namespace InstagramAPIExplorer.Pages.InstagramMedia
{
    public class IndexModel : PageModel
    {
        private string ApiURI = "https://graph.facebook.com/v3.2/";
        private readonly string AppSecret = "9c8c09e7b0d294ba71ab8ef20d928c98";
        private readonly string Token = "EAADl8DK0YoQBAL8CWaGwcJipfZCCioZAsILCUOZBz9n5wdcO5R6QRzY00ZC6W1MaFupqGhCkCMnq3ehQHOfD6qjOnc7uH1Q4GCbFDx2jiKOTAlVLq9Un5DCrxIOfZAiWfOCtcWTPbdNYcC78L2HFUNboYFHUpO7idXSTkoEZBPftjZC3oNh64XhLFJTNDxDhdqh5KLbWBfEJQZDZD";
        private readonly string IGUserID = "17841400001410052";

        private readonly string UserMedia = "/media?fields=media_url,media_type,like_count,comments_count,timestamp";

        private readonly string TestMedia = "/17860547830332116?fields=media_url";

        public IList<Post> Media { get; set; }

        public void OnGet()
        {
            var client = new RestClient(ApiURI);

            var request = new RestRequest(IGUserID + UserMedia, Method.GET, DataFormat.Json);
            //request.JsonSerializer = NewtonsoftJsonSerializer.Default;

            request.AddParameter("access_token", Token);
            var response = client.Execute<User>(request);
            //Media = response.Data;

            var test = JsonConvert.DeserializeObject(response.Content);

            Console.WriteLine(response);
        }
    }
}
