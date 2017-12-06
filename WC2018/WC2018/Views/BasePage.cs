using WC2018.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WC2018.Views
{
    public class BasePage : ContentPage
    {
        protected override void OnAppearing() // It will start immediately after the screen is appeared
        {
            base.OnAppearing();

            if (!App.IsLoggedIn)
            {
                Navigation.PushModalAsync(new Login());
            }
        }
    }
}
