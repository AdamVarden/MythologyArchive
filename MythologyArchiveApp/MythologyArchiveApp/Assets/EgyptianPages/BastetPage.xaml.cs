using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MythologyArchiveApp.Assets.EgyptianPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BastetPage : ContentPage
	{
		public BastetPage ()
		{
            InitializeComponent();
            //Dispalying to BastetPage
            SetupImagesOnBastetPage();

        }

        //Linked to button to go back to Egyptian Option
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EgyptianOption());
        }

        //Gets and sets image on BastetPage
        private void SetupImagesOnBastetPage()
        {
            //Variables
            var assembly = typeof(BastetPage);
            string pathway = "MythologyArchiveApp.Assets.EgyptianImages.bastet.png";

            bastetImage.Source = ImageSource.FromResource(pathway, assembly);
        }
    }
}