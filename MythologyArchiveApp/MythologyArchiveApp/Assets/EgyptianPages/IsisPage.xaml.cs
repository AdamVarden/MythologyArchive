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
            SetupImagesOnIsisPage();

        }
        private async void Back_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new EgyptianOption());

        }

        private void SetupImagesOnIsisPage()
        {
            var assembly = typeof(IsisPage);
            string strFilename = "MythologyArchiveApp.Assets.EgyptianImages.isis.png";

            isisImage.Source = ImageSource.FromResource(strFilename, assembly);
        }
    }
}