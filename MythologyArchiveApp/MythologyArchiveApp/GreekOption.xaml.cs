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
    }
}