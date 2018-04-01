using System.Collections.Generic;
using Spotify.Abstractions.Interfaces;
using Spotify.Models;

namespace Spotify.Abstractions
{
    public class SearchService : ISearchService
    {
        public List<SpotifyItem> GetSpotifyItems()
        {
            List<SpotifyItem> spotifyItems = new List<SpotifyItem>();

            return spotifyItems;
        }
    }
}