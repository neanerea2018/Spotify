using System.Collections.Generic;
using System.Threading.Tasks;
using Spotify.Abstractions.Interfaces;
using Spotify.Models;
using Spotify.Extensions;
using SpotifyWebAPI;

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

        public async Task<Page<Track>> GetTrack()
        {
            var output = await SpotifyWebAPI.Artist.GetArtist("4DWX7u8BV0vZIQSpJQQDWU");
            var tracks = await Track.Search("Born in the USA");

            return tracks;
        }
    }
}