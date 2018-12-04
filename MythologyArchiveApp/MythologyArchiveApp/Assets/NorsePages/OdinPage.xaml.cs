using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MythologyArchiveApp.Assets.NorsePages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OdinPage : ContentPage
	{
		public OdinPage ()
		{
			InitializeComponent ();

            //For Displaying image of Odin
            SetupImagesOnOdinPage();

        }
        //For setting up the image
        private void SetupImagesOnOdinPage()
        {
            //Variables
            var assembly = typeof(OdinPage);
            string pathway = "MythologyArchiveApp.Assets.NorseImages.odin.jpg";

            //Getting and Setting the image
            odinImage.Source = ImageSource.FromResource(pathway, assembly);

        }
        //For going back a page Brings. you back to Norse Options page
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NorseOption());

        }
    }
}