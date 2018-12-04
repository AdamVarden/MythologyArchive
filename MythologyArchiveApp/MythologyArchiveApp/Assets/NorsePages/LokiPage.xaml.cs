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
            SetupImagesOnLokiPage();

        }
        private void SetupImagesOnLokiPage()
        {
            var assembly = typeof(LokiPage);
            string pathway = "MythologyArchiveApp.Assets.NorseImages.loki.jpg";

            lokiImage.Source = ImageSource.FromResource(pathway, assembly);
            
        }
        private async void Back_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new NorseOption());

        }
    }
}