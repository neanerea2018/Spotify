using System.Collections.Generic;
using Spotify.Abstractions.Interfaces;
using Spotify.Models;
using Spotify.Extensions;

namespace Spotify.Abstractions
{
    public class SearchMockService : ISearchService
    {
        public List<SpotifyItem> GetSpotifyItems()
        {
            List<SpotifyItem> spotifyItems = new List<SpotifyItem>();

            var spotifyItem1 = new SpotifyItem
            {
                Artist = "The Killers",
                Song = "Runaways"
            };

            var spotifyItem2 = new SpotifyItem
            {
                Artist = "U2",
                Song = "With or without you"
            };

            var spotifyItem3 = new SpotifyItem
            {
                Artist = "Coldplay",
                Song = "Yellow"
            };

            spotifyItems.Add(spotifyItem1, spotifyItem2, spotifyItem3);

            return spotifyItems;
        }
    }
}