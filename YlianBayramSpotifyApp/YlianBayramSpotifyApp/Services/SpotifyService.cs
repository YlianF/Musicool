using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace EliseSpotifyApp.Service
{
    public class SpotifyService
    {
        const string TokenSpotify = "BQBtsyrcMiT6WuYv8WNw-aa6auN1cSUraSmxXccgkvxfkfrW_veCEgfa9OuFnEqT1idbTpyUjpFU6YEl_E-4Lz7UtgQBFiikye10roSl7O5ZxrOlW7dn";
        private SpotifyClient _spotifyClient;
        #region Instance

        public static SpotifyService Instance { get; } = new SpotifyService();

        #endregion

        public async Task<bool> ConnectSpotify()
        {
            try
            {
                _spotifyClient = new SpotifyClient(TokenSpotify);
                return await Task.FromResult(true);
            }
            catch (Exception exception)
            {
                return await Task.FromResult(false);
            }
        }

        public SpotifyClient GetSpotifyClient()
        {
            return _spotifyClient;
        }
    }
}