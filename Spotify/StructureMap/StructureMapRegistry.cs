using Spotify.Abstractions;
using Spotify.Abstractions.Interfaces;
using StructureMap;

namespace Spotify.StructureMap
{
    public class StructureMapRegistry : Registry
        {
         public StructureMapRegistry()
         {
            For<ISearchService>()
                .Use<SearchMockService>();

             For<ISpotifyService>()
                 .Use<SpotifyApiClient>();
            
            //For<ISearchService>()
            //    .Use<SearchService>();
        }
    }
}