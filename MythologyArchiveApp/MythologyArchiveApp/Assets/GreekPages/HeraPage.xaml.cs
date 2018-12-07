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
	public partial class HeraPage : ContentPage
	{
		public HeraPage ()
		{
            InitializeComponent();
            //Display Image of Hera
            SetupImagesOnHeraPage();
        }

        //Getting and setting the Hera image
        private void SetupImagesOnHeraPage()
        {
            //Variables
            var assembly = typeof(HeraPage);
            string pathway = "MythologyArchiveApp.Assets.GreekImages.hera.jpg";

            //Getting and setting the image
            heraImage.Source = ImageSource.FromResource(pathway, assembly);

        }

        //Brings you back to GreekOption
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GreekOption());
        }
    }
}