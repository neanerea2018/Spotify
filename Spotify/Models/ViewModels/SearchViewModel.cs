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
            //SpotifyItems = SearchService.GetInstance<ISearchService>().GetSpotifyItems();
            //Client = SpotifyService.GetInstance<ISpotifyService>().GetDefaultClient();
            
            Artist = SpotifyService.GetInstance<ISpotifyService>().SearchArtistsAsync("Bruce Springsteen");
        }

        public HttpClient Client { get; set; }

        public Task<SearchArtistResponse> Artist { get; private set; }

        public IEnumerable<SpotifyItem> SpotifyItems { get; set; }
    }
}