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
            SetupImagesOnPage();

        }



        private void SetupImagesOnPage()
        {
            var assembly = typeof(IsisPage);
            string strFilename = "MythologyArchiveApp.Assets.Images.isis3.jpg";

            isisImage.Source = ImageSource.FromResource(strFilename, assembly);
            
        }
    }
}