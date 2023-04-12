using EliseSpotifyApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YlianBayramSpotifyApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FeaturePage : ContentPage
	{
		public FeaturePage ()
		{
			InitializeComponent ();

			var top50 = "37i9dQZEVXbMDoHDwVN2tF";
            var Top50PlaylistImage = SpotifyService.Instance.GetSpotifyClient().Playlists.Get(top50).Result.Images[0].Url;
			var Top50PlaylistOwner = SpotifyService.Instance.GetSpotifyClient().Playlists.Get(top50).Result.Owner.DisplayName;
			var Top50PlaylistDescription = SpotifyService.Instance.GetSpotifyClient().Playlists.Get(top50).Result.Description;
            var Top50PlaylistFollowers = SpotifyService.Instance.GetSpotifyClient().Playlists.Get(top50).Result.Followers.Total.ToString();
			var Top50PlaylistTitle = SpotifyService.Instance.GetSpotifyClient().Playlists.Get(top50).Result.Name;


			this.Top50PlaylistTitle.Text = Top50PlaylistTitle;
            this.Top50PlaylistOwner.Text = "Par : " + Top50PlaylistOwner;
			this.Top50PlaylistImage.Source = Top50PlaylistImage;
			this.Top50PlaylistDescription.Text = "Description : " + Top50PlaylistDescription;
			this.Top50PlaylistFollowers.Text = "Nombre de Followers : " + Top50PlaylistFollowers;

        }

	}

}