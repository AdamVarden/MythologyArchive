﻿using System;
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
            //Displays image
            SetupImagesOnSetPage();

        }

        //Sends user back to EgyptianOption
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EgyptianOption());
        }

        //Gets and sets image on Set Page
        private void SetupImagesOnSetPage()
        {
            //Variables
            var assembly = typeof(SetPage);
            string pathway = "MythologyArchiveApp.Assets.EgyptianImages.set.png";

            setImage.Source = ImageSource.FromResource(pathway, assembly);

        }
    }
}