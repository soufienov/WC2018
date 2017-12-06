using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WC2018.Views;
using Xamarin.Forms;

namespace WC2018
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            _NavPage = new NavigationPage(new Login());
            MainPage = _NavPage;
           // MainPage = new NavigationPage(new WC2018.Views.TeamsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        static NavigationPage _NavPage;
        public static Page GetMainPage()
        {
            var profilePage = new ProfilePage();

            _NavPage = new NavigationPage(profilePage);

            return _NavPage;
        }


        public static bool IsLoggedIn
        {
            get { return !string.IsNullOrWhiteSpace(_Token); }
        }

        #region To store token form auth services
        static string _Token;
        public static String Token
        {
            get { return _Token; }
        }

        public static void SaveToken(string token)
        {
            _Token = token;

        }
        #endregion

        public static Action SuccessfulLoginAction
        {
            get
            {
                return new Action(() =>
                {
                    _NavPage.Navigation.PopModalAsync();
                    _NavPage.Navigation.PushAsync(new ProfilePage());
                });
            }
        }
        static string _user;

        public static void SaveUser(string fbuser)
        {
            _user = fbuser;
        }
    }
}
