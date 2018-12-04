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
	public partial class HorusPage : ContentPage
	{
		public HorusPage ()
		{
			InitializeComponent ();
            SetupImagesOnHorusPage();

        }
        private async void Back_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new EgyptianOption());

        }
        private void SetupImagesOnHorusPage()
        {
            var assembly = typeof(HorusPage);
            string strFilename = "MythologyArchiveApp.Assets.EgyptianImages.horus.png";

            horusImage.Source = ImageSource.FromResource(strFilename, assembly);

        }
    }
}