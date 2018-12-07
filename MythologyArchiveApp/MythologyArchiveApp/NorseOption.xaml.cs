using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MythologyArchiveApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NorseOption : ContentPage
	{
		public NorseOption ()
		{
			InitializeComponent ();
		}
        //Linked to button to go back to the main page
        private async void Back_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());

        }

        //Linked to button to bring you to LokiPage
        private async void Loki_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.NorsePages.LokiPage());

        }

        //Linked to button to bring you to OdinPage
        private async void Odin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.NorsePages.OdinPage());

        }
        //Linked to button to bring you to ThorPage
        private async void Thor_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.NorsePages.ThorPage());

        }

        //Linked to button to bring you to HelPage
        private async void Hel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.NorsePages.HelPage());

        }
    }
}