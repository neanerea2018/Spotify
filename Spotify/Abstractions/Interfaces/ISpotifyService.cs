using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Spotify.Models;

namespace Spotify.Abstractions.Interfaces
{
    public interface ISpotifyService
    {
        HttpClient GetDefaultClient();

        Task<string> GetToken(SpotifyAuthClientCredentialsHttpMessageHandler authHandler);

        Task<SearchArtistResponse> SearchArtistsAsync(string artistName, int? limit = null, int? offset = null);
    }
}
