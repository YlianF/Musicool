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
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        async void click(object sender, EventArgs args)
        {
            var ListeCases = new List<BoxView> { case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15, case16, case17, case18, case19, case20 };
            for (int i = 0; i < ListeCases.Count; i++)
            {
                if (ListeCases[i].Color == Color.White)
                {
                    ListeCases[i].Color = Color.Black;
                }
                else
                {
                    ListeCases[i].Color = Color.White;
                }
            }
        }
    }
}