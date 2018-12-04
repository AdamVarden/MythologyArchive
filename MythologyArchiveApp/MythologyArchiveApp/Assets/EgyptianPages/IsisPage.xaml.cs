using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MythologyArchiveApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IsisPage : ContentPage
	{
        public IsisPage()
        {
            InitializeComponent();
            //Dispalying to IsisPage
            SetupImagesOnIsisPage();

        }

        //Linked to button to go back to Egyptian Option
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EgyptianOption());
        }

        //Gets and sets image on isis page
        private void SetupImagesOnIsisPage()
        {
            //Variables
            var assembly = typeof(IsisPage);
            string pathway = "MythologyArchiveApp.Assets.EgyptianImages.isis.png";
    
            isisImage.Source = ImageSource.FromResource(pathway, assembly);
        }
    }
}