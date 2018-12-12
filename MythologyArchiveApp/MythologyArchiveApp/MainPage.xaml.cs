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

        //Linked to button to bring you to GreekOption
        private async void Greek_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GreekOption());

        }

        //Linked to button to bring you to NorseOption
        private async void Norse_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NorseOption());

        }

        //Linked to button to bring you to EgyptianOption
        private async void Egyptian_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EgyptianOption());

        }

    }
}
