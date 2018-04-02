using System.Collections.Generic;
using System.Threading.Tasks;
using Spotify.Models;
using SpotifyWebAPI;

namespace Spotify.Abstractions.Interfaces
{
    public interface ISearchService
    {
        List<SpotifyItem> GetSpotifyItems();

        Task<Page<Track>> GetTrack();
    }
}