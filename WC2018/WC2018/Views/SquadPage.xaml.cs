using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WC2018.ViewModel;
using WC2018.Model;
using WC2018.services;
using PCLStorage;

namespace WC2018.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SquadPage : ContentPage
    {
        IFolder folder = FileSystem.Current.LocalStorage;
        private string file;
        private string score="";
        public SquadPage()
        {
            var vm = new SquadViewModel();
            BindingContext = vm;
            InitializeComponent();

        }
        public SquadPage(string file) { }

        public async Task<SquadPage> CreateSquadPage(string file)
        {
            this.file = file;
            var vm = new SquadViewModel(file);
          BindingContext = vm;
            InitializeComponent();
           await  getScoreAsync();
            createButtonsList();
            createAnswerButtons();
            SquadCarousel.ItemSelected += SquadCarousel_ItemSelected;
            return this;
        }
        public static  Task<SquadPage> generateSquadPage(string file)
        {
            var ret= new SquadPage(file);
            return ret.CreateSquadPage(file); 
        }
            
            
            private void SquadCarousel_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            btnst1.Children.Clear();
            btnst2.Children.Clear();
            name.Children.Clear();
                
            createButtonsList();
            createAnswerButtons();
           
        }

  
        private void createButtonsList()
        {
            //create keyboard
            nameSequence = ((PlayerModel)SquadCarousel.Item).nameSequence;
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
            if (bt != null)
            {
                bt.Text = s.Text;
                Grid l = (Grid)s.Parent;
                s.IsVisible = false;
            }
            
                checkAnswerAsync();
            
        }

        private async Task checkAnswerAsync()
        {
            var i = 0;
            var l = nameSequence.Count;
            var en = name.Children.GetEnumerator();
            en.MoveNext();
            var en1 = nameSequence.GetEnumerator();
            en1.MoveNext();
            while(((Button)en.Current).Text==en1.Current&& i<l)
            { en.MoveNext();en1.MoveNext();i++; }
            if (i == l)
            {
                en.Dispose();
                setAnswered(i);
                if(!score.Contains(((PlayerModel)SquadCarousel.Item).name))
                await saveScoreAsync();
            }
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
        private void createAnswerButtons() {
            var n = ((PlayerModel)SquadCarousel.Item).name;
             Button btn;
            var i = 0;
            foreach (string c in nameSequence)
            {
                if (score.Contains(n)) {  btn = new Button(); btn.BackgroundColor = Color.Green; btn.IsEnabled = false;btn.Text = c; }
                else {
                 btn = new Button();  btn.BackgroundColor = Color.Azure; btn.Clicked += Btn_Clicked1;
                }
                    name.Children.Add(btn, i, 0);
                i++;

            }
        }

        private void Btn_Clicked1(object sender, EventArgs e)
        {
            var s = ((Button)sender);
            if (!String.IsNullOrEmpty(s.Text))
            {
              
               
                var en = btnst1.Children.GetEnumerator();
                var ps = 0;
                
                    en.MoveNext();
                    while (en.Current.IsVisible&&ps<8)
                    { en.MoveNext(); ps++; }
                if (ps < 8) { var bt = ((Button)en.Current);bt.Text = s.Text; bt.IsVisible=true; }
                else
                {
                    ps = 0;
                    en = btnst2.Children.GetEnumerator(); en.MoveNext();
                    while (en.Current.IsVisible)
                    { en.MoveNext(); ps++; }
                    var bt = ((Button)en.Current); bt.Text = s.Text; bt.IsVisible = true;
                }

                s.Text = null;
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
        public async Task saveScoreAsync()
        {
            //check file existance

           var check=await FileService.IsFileExistAsync("scoreit.txt",folder);
            if (!check)
            { await FileService.CreateFile("scoreit.txt",folder);
              
            }
            score = score + "," + ((PlayerModel)SquadCarousel.Item).name;
           await  FileService.WriteTextAllAsync("scoreit.txt", score, folder);
              
        }

        public async Task getScoreAsync() {
            var check = await FileService.IsFileExistAsync("scoreit.txt", folder);
           
            if (check)
             await FileService.ReadAllTextAsync("scoreit.txt", folder).ContinueWith(r=> score=r.Result);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            getScoreAsync();
        }
        private void setAnswered(int i)
        {
          
            var en2 = name.Children.GetEnumerator();
            en2.MoveNext();
            while (i > 0)
            {
                var b = ((Button)en2.Current);
                b.BackgroundColor = Color.Green;
                b.IsEnabled = false; i--; en2.MoveNext();
            }
        }

        private void Right_ones(object sender, EventArgs e)
        {
            //gives help
            //1 look for good answers in answer buttons
            var en = name.Children.GetEnumerator();
            en.MoveNext();
            var i = 0;
            while (i < nameSequence.Count) { var b = (Button)en.Current;
                if (b.Text == nameSequence.ElementAt<string>(i)) {
                    b.BackgroundColor = Color.Green;
                    b.IsEnabled = false;
                }
                i++;en.MoveNext();
            }


        }
        private void Remove_wrong(object sender, EventArgs e)
        {
            //gives help
            //1 look for good answers in answer buttons
            var en = btnst1.Children.GetEnumerator();
            
           
            while (en.MoveNext())
            {
                var b = (Button)en.Current;
                if ( !nameSequence.Contains(b.Text))
                {
                    
                    b.IsEnabled = false;
                }
               
            }
            var en2 = btnst2.Children.GetEnumerator();


            while (en2.MoveNext())
            {
                var b = (Button)en2.Current;
                if (!nameSequence.Contains(b.Text))
                {

                    b.IsEnabled = false;
                }

            }

        }
    }

       
    }
 