using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Spotify.Abstractions;
using Spotify.Abstractions.Interfaces;
using Spotify.StructureMap;
using StructureMap;

namespace Spotify.Models.ViewModels
{
    public class SearchViewModel : SearchModel
    {
        private static readonly IContainer SearchService = Container.For<StructureMapRegistry>();
        private static readonly IContainer SpotifyService = Container.For<StructureMapRegistry>();

        public SearchViewModel()
        {
            var authHandler = new SpotifyAuthClientCredentialsHttpMessageHandler(
                "a6603f0e913d4511bdfe8aa0c167d293",
                "aaf58db86409493487c372a89a7b5abc",
                new HttpClientHandler());

           // var authHandler = new SpotifyAuthClientCredentialsHttpMessageHandler();

            //SpotifyItems = SearchService.GetInstance<ISearchService>().GetSpotifyItems();
            Client = SpotifyService.GetInstance<ISpotifyService>().GetDefaultClient();
            //var c = Client.GetAsync()

            var token = SpotifyService.GetInstance<ISpotifyService>().GetToken(authHandler).Wait(10000);

            // Artist = SpotifyService.GetInstance<ISpotifyService>().SearchArtistsAsync("Bruce Springsteen");

            var output = SpotifyService.GetInstance<ISearchService>().GetTrack();
            var s = output;
        }

        public HttpClient Client { get; set; }

        public Task<SearchArtistResponse> Artist { get; private set; }

        public IEnumerable<SpotifyItem> SpotifyItems { get; set; }
    }
}