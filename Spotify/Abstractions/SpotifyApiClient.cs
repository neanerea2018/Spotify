using System;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl;
using Newtonsoft.Json;
using Spotify.Abstractions.Interfaces;
using Spotify.Models;

namespace Spotify.Abstractions
{
    public class SpotifyApiClient : ISpotifyService
    {
        private const string ClientId = "a6603f0e913d4511bdfe8aa0c167d293";
        private const string ClientSecret = "aaf58db86409493487c372a89a7b5abc";
        protected const string BaseUrl = "https://api.spotify.com/";

        public HttpClient GetDefaultClient()
        {
            var authHandler = new SpotifyAuthClientCredentialsHttpMessageHandler(
                ClientId,
                ClientSecret,
                new HttpClientHandler());

            var client = new HttpClient(authHandler)
            {
                BaseAddress = new Uri(BaseUrl)
            };

            var token = authHandler.GetAuthenticationTokenAsync();


            return client;
        }

        public Task<string> GetToken(SpotifyAuthClientCredentialsHttpMessageHandler authHandler)
        {
            var token = authHandler.GetAuthenticationTokenAsync();

            return token;
        }

        public async Task<SearchArtistResponse> SearchArtistsAsync(string artistName, int? limit = null, int? offset = null)
        {
            var client = GetDefaultClient();

            var headers = client.DefaultRequestHeaders;

            var url = new Url("/v1/search");
            url = url.SetQueryParam("q", artistName);
            url = url.SetQueryParam("type", "artist");

            if (limit != null)
                url = url.SetQueryParam("limit", limit);

            if (offset != null)
                url = url.SetQueryParam("offset", offset);

            var response = await client.GetStringAsync(url);

            var artistResponse = JsonConvert.DeserializeObject<SearchArtistResponse>(response);

            return artistResponse;
        }
    }
}