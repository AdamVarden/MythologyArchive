using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MythologyArchiveApp.Assets.GreekPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HadesPage : ContentPage
	{
		public HadesPage ()
		{
			InitializeComponent ();
            //Display Image of Hades
            SetupImagesOnHadesPage();
        }

        //Getting and setting the Hades image
        private void SetupImagesOnHadesPage()
        {
            //Variables
            var assembly = typeof(HadesPage);
            string pathway = "MythologyArchiveApp.Assets.GreekImages.hades.jpg";

            //Getting and setting the image
            hadesImage.Source = ImageSource.FromResource(pathway, assembly);

        }

        //Brings you back to GreekOption
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GreekOption());
        }
    }
}