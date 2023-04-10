using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace EliseSpotifyApp.Service
{
    public class SpotifyService
    {
        const string TokenSpotify = "BQBYzJpOWh0j4MjxIb9uYwj_XSODfwpk_xtuglAQxOobz4odsXtMocSil9QSA9knylnT3xodLXIbiTfzVKURAjs7QiX7U79Qo5k-rjxPnCN1Iqs4QkwZ";
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