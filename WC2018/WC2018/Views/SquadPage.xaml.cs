using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WC2018.ViewModel;
using WC2018.controls;

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
            CarouselView crv = new CarouselView();
            crv.ItemsSource = vm.Squad;
            DataTemplate dt = new DataTemplate();
            StackLayout stl = new StackLayout();
            Image im = new Image();
            im.Source = "tunisia.png";
            var buttonGroupQuantityItems = new List<string>();

            for (var i = 1; i <= 8; i++)
            {
                buttonGroupQuantityItems.Add(i.ToString(CultureInfo.InvariantCulture));
            }
            var buttonGroupQuantity = new ButtonGroup
            {
                IsNumber = true,
                Rounded = true,
                ViewBackgroundColor = Color.Black,
                BorderColor = Color.White,
                OutlineColor = Color.Black,
                BackgroundColor = Device.OnPlatform(Color.Accent, Color.Accent, Color.White),
                TextColor = Device.OnPlatform(Color.White, Color.White, Color.Black),
                SelectedTextColor = Device.OnPlatform(Color.Black, Color.White, Color.White),
                SelectedBackgroundColor = Device.OnPlatform(Color.White, Color.Black, Color.Black),
                SelectedBorderColor = Device.OnPlatform(Color.White, Color.Silver, Color.Silver),
                SelectedFrameBackgroundColor = Device.OnPlatform(Color.Black, Color.Black, Color.Black),
                SelectedIndex = 3,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(5),
                Font = Device.OnPlatform(
                   Font.OfSize("HelveticaNeue-Light", NamedSize.Medium),
                   Font.OfSize("Roboto Light", NamedSize.Medium),
                   Font.OfSize("Segoe WP Light", NamedSize.Medium)),
                Items = buttonGroupQuantityItems,
            };
            stl.Children.Add(im);
            stl.Children.Add(buttonGroupQuantity);
            

        }

        private void SquadCarousel_ChildAdded(object sender, FocusEventArgs e)
        {
            Button b1 = new Button();
            b1.Text = "oghdgk";
          
            var ly = SquadCarousel.FindByName<StackLayout>("layout");

            ly.Children.Add(b1);
        }
    }
}
   <forms:CarouselView x:Name="SquadCarousel" ItemsSource="{Binding Squad}">
                <forms:CarouselView.ItemTemplate>
                    <DataTemplate>
                       
                            <StackLayout x:Name="layout" Orientation="Vertical">
                            <Image Source = "{Binding photo}" />
                            </ StackLayout >
                    </ DataTemplate >
                </ forms:CarouselView.ItemTemplate>
              
            </forms:CarouselView>