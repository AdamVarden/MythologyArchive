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
	public partial class SetPage : ContentPage
	{
		public SetPage ()
		{
			InitializeComponent ();
            SetupImagesOnPage();

        }
        private async void Back_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new EgyptianOption());

        }
        private void SetupImagesOnPage()
        {
            var assembly = typeof(SetPage);
            string strFilename = "MythologyArchiveApp.Assets.EgyptianImages.set.png";

            setImage.Source = ImageSource.FromResource(strFilename, assembly);

        }
    }
}