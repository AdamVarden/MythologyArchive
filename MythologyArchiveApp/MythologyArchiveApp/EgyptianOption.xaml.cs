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

        private async void Horus_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.EgyptianPages.HorusPage());
        }

        private async void Isis_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IsisPage());
        }

        private async void Set_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.EgyptianPages.SetPage());
        }
    }
}