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
	public partial class LokiPage : ContentPage
	{
		public LokiPage ()
		{
			InitializeComponent();
            //Display Image of Loki
            SetupImagesOnLokiPage();

        }

        //Getting and setting the Loki image
        private void SetupImagesOnLokiPage()
        {
            //Variables
            var assembly = typeof(LokiPage);
            string pathway = "MythologyArchiveApp.Assets.NorseImages.loki.jpg";

            //Getting and setting the image
            lokiImage.Source = ImageSource.FromResource(pathway, assembly);
            
        }

        //Brings you back to NorseOption
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NorseOption());
        }
    }
}