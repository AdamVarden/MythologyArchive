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
	public partial class OdinPage : ContentPage
	{
		public OdinPage ()
		{
			InitializeComponent ();
            SetupImagesOnOdinPage();

        }
        private void SetupImagesOnOdinPage()
        {
            var assembly = typeof(OdinPage);
            string strFilename = "MythologyArchiveApp.Assets.NorseImages.odin.jpg";

            odinImage.Source = ImageSource.FromResource(strFilename, assembly);

        }
        private async void Back_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new NorseOption());

        }
    }
}