using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.UI;
using Spotify.Abstractions.Interfaces;
using Spotify.Models;
using SpotifyWebAPI;

namespace Spotify.Abstractions
{
    public class SearchService : ISearchService
    {
        public List<SpotifyItem> GetSpotifyItems()
        {
            List<SpotifyItem> spotifyItems = new List<SpotifyItem>();

            return spotifyItems;           
        }

        public async Task<Page<Track>> GetTrack()
        {
            var output = await SpotifyWebAPI.Artist.GetArtist("4DWX7u8BV0vZIQSpJQQDWU");
            var tracks =  await Track.Search("Ties that bind", "Blackbird", "Alter Bridge");

            return tracks;
        }

        
    }
}