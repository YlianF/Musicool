using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace EliseSpotifyApp.Service
{
    public class SpotifyService
    {
        const string TokenSpotify = "BQA6TJVjElYoea2aSrQ5_xvXtn_L8rnrvWip58zLdssWyDeIytuOEARfzd6fGdXn3XdtOsr1VxbgnWrxYaZmcMwtisQtPB3mIpDiIhwNacni_wp4YnlLgWbYC-uqNi82UHP5MbHqRGc_sFS_OpNaIp2fZtRVU2niOqBxRmh1_Ziy9T6ENZtlrVLMdl2_8QzfTcXUAj7s_KzOEUow7XUCSAfqaWpABujNtJvVUQ6Qx23nvmnozB4x7hTINrl7oXhyTFqztKJ_u0c95Z8UynmcNDTI8HAXiK5Y1JfZI-rLDmypUZ8rQIZYgyjDs_SosHEbhFscNjR4zm5uTg";
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