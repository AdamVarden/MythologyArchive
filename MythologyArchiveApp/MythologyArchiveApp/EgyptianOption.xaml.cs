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
	public partial class EgyptianOption : ContentPage
	{
        public EgyptianOption()
        {
            InitializeComponent();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());

        }

        private void Horus_Clicked(object sender, EventArgs e)
        {

        }

        private async void Isis_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IsisPage());
        }
    }
}