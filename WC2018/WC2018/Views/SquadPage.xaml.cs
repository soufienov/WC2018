﻿using System;
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
    public partial class SquadPage : ContentPage
    {
        private string file;
        public StackLayout labels;
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

            createButtons();
            createLabels();
            SquadCarousel.ItemSelected += SquadCarousel_ItemSelected;
        }

        private void SquadCarousel_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {major.Children.Remove(buttonGroupTagCloud);
            major.Children.Remove(labels);
            createButtons();
            createLabels();
        }

        public ButtonGroup buttonGroupTagCloud { get; private set; }
        private void createButtons() {
            buttonGroupTagCloud = new ButtonGroup
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
                //Items=new List<string> { "i","l","p","o"}
            };
            buttonGroupTagCloud.Items = ((PlayerModel)SquadCarousel.Item).nameSequence;

            major.Children.Add(buttonGroupTagCloud);

        }
        private void createLabels()
        {
             labels = new StackLayout { Orientation = StackOrientation.Horizontal };
            List<string> chalist = buttonGroupTagCloud.Items;
            List<Label> lblist = new List<Label>();
            foreach (string c in chalist) {
                var lb = new Label();lb.Text = "u";
                lblist.Add(lb);
                labels.Children.Add(lb);
            }

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