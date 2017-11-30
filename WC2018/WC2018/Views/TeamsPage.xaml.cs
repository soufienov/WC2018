using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WC2018.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeamsPage : ContentPage
    {

        public TeamsPage()
        {
            InitializeComponent();
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (sender, e) =>
            {
                // cast to an image
                Image theImage = (Image)sender;
                Xamarin.Forms.FileImageSource objFileImageSource = (Xamarin.Forms.FileImageSource)theImage.Source;
                Navigation.PushAsync(await SquadPage.generateSquadPage(objFileImageSource.File));
                Tunisia.Text = objFileImageSource.File;
                // now you have a reference to the image
            };

            tn.GestureRecognizers.Add(tapGestureRecognizer);
        }

       
    }
}