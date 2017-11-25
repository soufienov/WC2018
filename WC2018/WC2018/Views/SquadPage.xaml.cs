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

            createButtonsList();
            createAnswerButtons();
            SquadCarousel.ItemSelected += SquadCarousel_ItemSelected;
        }

        private void SquadCarousel_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            btnst1.Children.Clear();
            btnst2.Children.Clear();
            name.Children.Clear();
                
            createButtonsList();
            createAnswerButtons();
        }

        public ButtonGroup buttonGroupTagCloud { get; private set; }
  
        private void createButtonsList()
        {nameSequence = ((PlayerModel)SquadCarousel.Item).nameSequence;
            List<string> chalist = new List<string>();chalist.AddRange( nameSequence);
            
            while (chalist.Count < 16)
                chalist.Add(GetLetter());
            Shuffle<string>(chalist);
            var i = 0;
            foreach (string c in chalist)
            {
               
                var btn = new Button(); btn.Text = c; btn.BackgroundColor = Color.Red; btn.Clicked += Btn_Clicked;
                if (i < 8)
                    btnst1.Children.Add(btn,i,0);
                else
                    btnst2.Children.Add(btn,i-8,0);
                i++;
               
            }
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            var s = ((Button)sender);
           var bt= findFirstEmpty();
            bt.Text = s.Text;
            Grid l =(Grid) s.Parent;l.Children.Remove(s);
            
        }
        private Button findFirstEmpty()
        {
            var btns = name.Children;
          List<Button>  btl=btns.OfType<Button>().ToList<Button>();
           foreach(var bt in btl)
            {
                if (String.IsNullOrEmpty(bt.Text))
                    return bt;
            }
            return null;
        }
        private void createAnswerButtons() { var i = 0;
            foreach (string c in nameSequence)
            {
               
                var btn = new Button();  btn.BackgroundColor = Color.Azure;
               
                    name.Children.Add(btn, i, 0);
                i++;

            }
        }
        static Random _random = new Random();
        private List<string> nameSequence;

        public static string GetLetter()
        {
            // This method returns a random lowercase letter.
            // ... Between 'a' and 'z' inclusize.
            int num = _random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let.ToString();
        }
        public static void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
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