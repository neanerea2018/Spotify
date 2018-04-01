using System.Collections.Generic;
using Spotify.Abstractions.Interfaces;
using Spotify.StructureMap;
using StructureMap;

namespace Spotify.Models.ViewModels
{
    public class SearchViewModel : SearchModel
    {
        private static readonly IContainer SearchService = Container.For<StructureMapRegistry>();

        public SearchViewModel()
        {
            SpotifyItems = SearchService.GetInstance<ISearchService>().GetSpotifyItems();
        }

        public IEnumerable<SpotifyItem> SpotifyItems { get; set; }
    }
}