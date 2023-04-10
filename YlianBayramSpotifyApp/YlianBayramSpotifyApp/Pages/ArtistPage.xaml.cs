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

            // on récupère toutes nos variables avec l'API
            var imageArtiste = SpotifyService.Instance.GetSpotifyClient().Artists.Get("3Rq3YOF9YG9YfCWD4D56RZ").Result.Images[0].Url;
            var nomArtiste = SpotifyService.Instance.GetSpotifyClient().Artists.Get("3Rq3YOF9YG9YfCWD4D56RZ").Result.Name;
            var genresArtiste = SpotifyService.Instance.GetSpotifyClient().Artists.Get("3Rq3YOF9YG9YfCWD4D56RZ").Result.Genres;
            var nbFollowersArtiste = SpotifyService.Instance.GetSpotifyClient().Artists.Get("3Rq3YOF9YG9YfCWD4D56RZ").Result.Followers.Total;
            var populariteArtiste = SpotifyService.Instance.GetSpotifyClient().Artists.Get("3Rq3YOF9YG9YfCWD4D56RZ").Result.Popularity.ToString();


            // TODO image
            this.imageArtiste.Source = imageArtiste;

            this.nomArtiste.Text = nomArtiste;

            // on assigne tous les genre de l'artiste à 1 seul label avec une boucle et on met en forme avec le séparateur "|", sauf pour le dernier
            for (int i = 0;  i <= genresArtiste.Count-2; i++)
            {
                this.genresArtiste.Text = this.genresArtiste.Text + genresArtiste[i] + " | ";
            }
            this.genresArtiste.Text = this.genresArtiste.Text + genresArtiste[genresArtiste.Count-1];

            this.nbFollowersArtiste.Text = "Nombre de followers : " + nbFollowersArtiste.ToString();

            this.populariteArtiste.Text = "Popularité : " + populariteArtiste + "/100";
        }
    }
}