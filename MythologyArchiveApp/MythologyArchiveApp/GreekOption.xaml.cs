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
	public partial class GreekOption : ContentPage
	{
		public GreekOption ()
		{
			InitializeComponent ();
		}

        //Linked to button to go back to the main page
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        //Linked to button to bring you to PoseidonPage
        private async void Poseidon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.GreekPages.PoseidonPage());
        }

        //Linked to button to bring you to ZeusPage
        private async void Zeus_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.GreekPages.ZeusPage());
        }

        //Linked to button to bring you to HadesPage
        private async void Hades_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.GreekPages.HadesPage());
        }

        //Linked to button to bring you to HeraPage
        private async void Hera_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.GreekPages.HeraPage());
        }
    }
}