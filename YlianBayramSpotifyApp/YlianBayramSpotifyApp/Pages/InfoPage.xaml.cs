using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YlianBayramSpotifyApp.ViewModels;

namespace YlianBayramSpotifyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
            BindingContext = InfoPageViewModel.Instance;
        }

        async void click(object sender, EventArgs args)
        {
           InfoPageViewModel.Instance.UpdateColors();
        }
    }
}