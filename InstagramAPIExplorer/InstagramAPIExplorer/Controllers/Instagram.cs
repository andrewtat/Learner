using System;
using RestSharp;
using RestSharp.Authenticators;
using InstagramAPIExplorer.Models;

namespace InstagramAPIExplorer.Controllers
{
    public class Instagram
    {
        private string BaseUrl = "https://graph.facebook.com/v3.2/";
        private readonly string AppSecret = "9c8c09e7b0d294ba71ab8ef20d928c98";
        private readonly string Token = "33e962a8f7df0455c0e61d850f879cb5";
        private readonly string IGUserID = "17841400001410052";

        private readonly string UserMedia = "/media?fields=media_url";

        private readonly IRestClient _client;

        public Instagram()
        {
            _client = new RestClient(BaseUrl);
            _client.Authenticator = new HttpBasicAuthenticator(Token, AppSecret);


            var request = new RestRequest(IGUserID + UserMedia, DataFormat.Json);
            //request.RootElement = "data";
        }

    }
}
