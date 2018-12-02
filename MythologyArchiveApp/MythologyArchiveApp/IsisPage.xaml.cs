using System;
using System.Collections.Generic;
using System.Linq;
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
            SetupImagesOnPage();
        }
        private void SetupImagesOnPage()
        {
            // get the assembly
            var assembly = typeof(IsisPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "MythologyArchiveApp.Assets.Images.isis3.jpg";

            imageMain.Source = ImageSource.FromResource(strFilename, assembly);
            
        }
    }
}