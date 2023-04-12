using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace EliseSpotifyApp.Service
{
    public class SpotifyService
    {
        const string TokenSpotify = "BQBoi97AxHrAEijpzV-zeKyazPjhw7ksgnZ7YkyilIrZZSGjgX1XIrb7aBfoMigU8z5u12Bu9EinlKDM4FW5aQVcWj3_uhURgo_iESgzVvEv_Pm65GeB";
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