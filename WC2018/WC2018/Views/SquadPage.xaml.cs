using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WC2018.ViewModel;
namespace WC2018.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SquadPage : ContentPage
    {
        private string file;

        public SquadPage()
        {
            var vm = new SquadViewModel();
            BindingContext = vm;
            InitializeComponent();

        }

        public SquadPage(string file)
        {
            this.file = file;
            var vm = new SquadViewModel(file);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}