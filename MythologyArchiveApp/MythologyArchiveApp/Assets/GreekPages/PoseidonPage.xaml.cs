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
	public partial class PoseidonPage : ContentPage
	{
		public PoseidonPage ()
		{
            InitializeComponent();
            //Display Image of Poseidon
            SetupImagesOnPoseidonPage();
        }

        //Getting and setting the Poseidon image
        private void SetupImagesOnPoseidonPage()
        {
            //Variables
            var assembly = typeof(PoseidonPage);
            string pathway = "MythologyArchiveApp.Assets.GreekImages.poseidon.jpg";

            //Getting and setting the image
            poseidonImage.Source = ImageSource.FromResource(pathway, assembly);

        }

        //Brings you back to GreekOption
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GreekOption());
        }
    }
}