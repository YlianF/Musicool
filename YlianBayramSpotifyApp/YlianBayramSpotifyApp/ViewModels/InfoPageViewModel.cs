using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using XXXXXX;

namespace YlianBayramSpotifyApp.ViewModels
{
    public class InfoPageViewModel : BaseViewModel
    {
        #region Instance

        public static InfoPageViewModel Instance { get; } = new InfoPageViewModel();

        #endregion

        public InfoPageViewModel() {
            FirstColor = Color.White;
            SecondColor = Color.Black;
        }

        public Color FirstColor
        {
            get
            {
                return GetValue<Color>();
            }
            set
            {
                SetValue(value);
            }
        }

        public Color SecondColor
        {
            get
            {
                return GetValue<Color>();
            }
            set
            {
                SetValue(value);
            }
        }

        public void UpdateColors()
        {
            if(FirstColor == Color.Black)
            {
                FirstColor = Color.White;
                SecondColor = Color.Black;
            }
            else
            {
                FirstColor = Color.Black;
                SecondColor = Color.White;
            }
        }

    }
}
