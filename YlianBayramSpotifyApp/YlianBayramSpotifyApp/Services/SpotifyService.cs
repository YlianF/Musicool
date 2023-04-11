using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace EliseSpotifyApp.Service
{
    public class SpotifyService
    {
        const string TokenSpotify = "BQB3vTQ49J2YeCMzBkuCWp4zHF1LRicM0Pkat9RLQpUQeWGv-AbcU8g2dpYUBDNwhLUJfcp91eBIBFAYLzeam2OjVhOm_TtAs0ZE5XkU8iiTOkXvrw0Q";
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