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
            SetupImagesOnPage();

        }

        private void SetupImagesOnPage()
        {
            var assembly = typeof(IsisPage);
            string strFilename = "MythologyArchiveApp.Assets.Images.horus.jpg";

            horusImage.Source = ImageSource.FromResource(strFilename, assembly);

        }
    }
}