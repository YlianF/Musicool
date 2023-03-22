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
    public partial class ArtistPage : ContentPage
    {
        public ArtistPage()
        {
            InitializeComponent();
            this.nomart.Text = SpotifyService.Instance.GetSpotifyClient().Artists.Get("3Rq3YOF9YG9YfCWD4D56RZ").Result.Name;
        }
    }
}