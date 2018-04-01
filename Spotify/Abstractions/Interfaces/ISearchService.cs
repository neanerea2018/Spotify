using System.Collections.Generic;
using Spotify.Models;

namespace Spotify.Abstractions.Interfaces
{
    public interface ISearchService
    {
        List<SpotifyItem> GetSpotifyItems();
    }
}