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
	public partial class ThorPage : ContentPage
	{
		public ThorPage ()
		{
			InitializeComponent();
            //Displaying Thor image
            SetupImagesOnThorPage();

        }
        //Getting and setting image for Thor
        private void SetupImagesOnThorPage()
        {
            //Variables
            var assembly = typeof(ThorPage);
            string pathway = "MythologyArchiveApp.Assets.NorseImages.thor.jpg";

            thorImage.Source = ImageSource.FromResource(pathway, assembly);

        }

        //For going back to Norse Options Page
        private async void Back_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new NorseOption());

        }
    }
}