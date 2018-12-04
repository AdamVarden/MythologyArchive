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
	public partial class ZeusPage : ContentPage
	{
		public ZeusPage ()
		{
            InitializeComponent();
            //Display Image of Zeus
            SetupImagesOnZeusPage();
        }

        //Getting and setting the Zeus image
        private void SetupImagesOnZeusPage()
        {
            //Variables
            var assembly = typeof(ZeusPage);
            string pathway = "MythologyArchiveApp.Assets.GreekImages.zeus.JPG";

            //Getting and setting the image
            zeusImage.Source = ImageSource.FromResource(pathway, assembly);

        }

        //Brings you back to GreekOption
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GreekOption());
        }
    }
}