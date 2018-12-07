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
	public partial class HelPage : ContentPage
	{
		public HelPage ()
		{
            InitializeComponent();
            //Display Image of Hel
            SetupImagesOnHelPage();

        }

        //Getting and setting the Hel image
        private void SetupImagesOnHelPage()
        {
            //Variables
            var assembly = typeof(HelPage);
            string pathway = "MythologyArchiveApp.Assets.NorseImages.hel.jpg";

            //Getting and setting the image
            helImage.Source = ImageSource.FromResource(pathway, assembly);

        }

        //Brings you back to NorseOption
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NorseOption());
        }
    }
}