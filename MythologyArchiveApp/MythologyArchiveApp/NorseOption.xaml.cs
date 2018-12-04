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

        private async void Back_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());

        }

        private async void Loki_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Assets.NorsePages.LokiPage());

        }

        private async void Odin_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Assets.NorsePages.OdinPage());

        }

        private async void Thor_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Assets.NorsePages.ThorPage());

        }
    }
}