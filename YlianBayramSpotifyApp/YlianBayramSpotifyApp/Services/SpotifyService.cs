using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace EliseSpotifyApp.Service
{
    public class SpotifyService
    {
        const string TokenSpotify = "BQDtRp1v60pisEdICFS81XStfstV0fldw0rRDbXXYOFnVCAidWlx4pAnpDvwFFX5tYf-2r-4LRzjDCW2lD_8-ut8cRGM4Ey6khfHPablvt6aB-jsEjKS";
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