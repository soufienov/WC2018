using WC2018.controls;
using WC2018.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            var vm = new LoginViewModel();
            vm.Navigation = Navigation;
            BindingContext = vm;

            InitializeComponent();
        }

        private void fblog(object sender, EventArgs e)
        {
            var profilePage = new ProfilePage();
            var device = Resolver.Resolve<IDevice>();

            ////RM: hack for working on windows phone? 
            var mp = DependencyService.Get<ISocial>();
            mp.FacebookLogin();
        }

       
    }
}