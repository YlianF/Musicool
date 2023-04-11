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
    public partial class AlbumPage : ContentPage
    {
        public AlbumPage()
        {
            InitializeComponent();

            // on récupère toutes nos variables avec l'API
            var imageAlbum = SpotifyService.Instance.GetSpotifyClient().Albums.Get("5OW08rgSamXCA4t9KkPN9L").Result.Images[0].Url;
            var nomAlbum = SpotifyService.Instance.GetSpotifyClient().Albums.Get("5OW08rgSamXCA4t9KkPN9L").Result.Name;
            var nomsArtistesAlbum = SpotifyService.Instance.GetSpotifyClient().Albums.Get("5OW08rgSamXCA4t9KkPN9L").Result.Artists;
            var listeTitres = SpotifyService.Instance.GetSpotifyClient().Albums.Get("5OW08rgSamXCA4t9KkPN9L").Result.Tracks.Items;
            var dateAlbumRealisation = SpotifyService.Instance.GetSpotifyClient().Albums.Get("5OW08rgSamXCA4t9KkPN9L").Result.ReleaseDate;

            var titresNoms = new List<string>();

            this.imageAlbum.Source = imageAlbum;

            this.nomAlbum.Text = nomAlbum;

            // on assigne tous les genre de l'artiste à 1 seul label avec une boucle et on met en forme avec le séparateur "|", sauf pour le dernier
            // au cas où il y ait un album avec plusieurs artistes (dans notre cas non)
            for (int i = 0; i <= nomsArtistesAlbum.Count - 2; i++)
            {
                nomArtisteAlbum.Text = nomArtisteAlbum.Text + nomsArtistesAlbum[i].Name + " | ";
            }
            nomArtisteAlbum.Text = "Artiste : " + nomArtisteAlbum.Text + nomsArtistesAlbum[nomsArtistesAlbum.Count - 1].Name;

            this.dateAlbumRealisation.Text = "Date de réalisation : " + dateAlbumRealisation;

            //pour récupérer que le nom des titres
            foreach (var titre in listeTitres)
            {
                titresNoms.Add(titre.Name);
            }

            this.listeTitres.ItemsSource = titresNoms;
        }
    }
}