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

        //Linked to button to go back to the main page
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        //Linked to button to bring you to HorusPage
        private async void Horus_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.EgyptianPages.HorusPage());
        }

        //Linked to button to bring you to IsisPage
        private async void Isis_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IsisPage());
        }

        //Linked to button to bring you to SetPage
        private async void Set_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.EgyptianPages.SetPage());
        }

        //Linked to button to bring you to BastetPage
        private async void Bastet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assets.EgyptianPages.BastetPage());
        }
    }
}