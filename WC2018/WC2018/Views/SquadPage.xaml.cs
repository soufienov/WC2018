using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WC2018.ViewModel;
using WC2018.controls;
using WC2018.Model;

namespace WC2018.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SquadPage : CarouselPage
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
          
            InitializeComponent();
            Thickness padding;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                case Device.Android:
                    padding = new Thickness(0, 40, 0, 0);
                    break;
                default:
                    padding = new Thickness();
                    break;
            }

             ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    HorizontalOptions = LayoutOptions.Center
                };
                 nameLabel.SetBinding(Label.TextProperty, "name");

                var colorBoxView = new BoxView
                {
                    WidthRequest = 200,
                    HeightRequest = 200,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    Color = Color.Red
                };
                //colorBoxView.SetBinding(BoxView.ColorProperty, "age");
/*
                List<char> result = ((PlayerModel)SelectedItem).name.ToCharArray(0,nameLabel.Text.Length).ToList();
                var buttonGroupTagCloudItems = result.Select(c => c.ToString()).ToList();*/

                var buttonGroupTagCloud = new ButtonGroup
                {
                    Rounded = false,
                    IsNumber = false,
                    ViewBackgroundColor = Color.White,
                    BorderColor = Color.White,
                    OutlineColor = Color.Black,
                    BackgroundColor = Device.OnPlatform(Color.Accent, Color.Accent, Color.White),
                    TextColor = Device.OnPlatform(Color.White, Color.Black, Color.Black),
                    SelectedTextColor = Device.OnPlatform(Color.Black, Color.White, Color.White),
                    SelectedBackgroundColor = Device.OnPlatform(Color.White, Color.Accent, Color.Accent),
                    SelectedBorderColor = Device.OnPlatform(Color.White, Color.Accent, Color.Accent),
                    SelectedFrameBackgroundColor = Device.OnPlatform(Color.White, Color.Accent, Color.Accent),
                    SelectedIndex = 3,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.Center,
                    Padding = new Thickness(5),
                    Font = Device.OnPlatform(
                   Font.OfSize("HelveticaNeue-Light", NamedSize.Medium),
                   Font.OfSize("Roboto Light", NamedSize.Medium),
                   Font.OfSize("Segoe WP Light", NamedSize.Medium)),
                 
                };
                buttonGroupTagCloud.SetBinding(ButtonGroup.ItemsPropertyProperty, "nameSequence");
                return new ContentPage
                {
                    Padding = padding,
                    Content = new StackLayout
                    {
                        Children = {
                        nameLabel,
                        colorBoxView,
                        buttonGroupTagCloud
                    }
                    }
                };
            });
            ItemsSource = vm.Squad;
           
        }

    }

       
    }

  /* <forms:CarouselView x:Name="SquadCarousel" ItemsSource="{Binding Squad}">
                <forms:CarouselView.ItemTemplate>
                    <DataTemplate>
                       
                            <StackLayout x:Name="layout" Orientation="Vertical">
                            <Image Source = "{Binding photo}" />
                            </ StackLayout >
                    </ DataTemplate >
                </ forms:CarouselView.ItemTemplate>
              
            </forms:CarouselView>*/