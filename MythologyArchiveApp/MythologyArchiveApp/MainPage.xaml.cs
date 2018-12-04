using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MythologyArchiveApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Greek_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GreekOption());

        }

        private async void Norse_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NorseOption());

        }
        private async void Egyptian_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EgyptianOption());

        }

    }
}
