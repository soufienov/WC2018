using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WC2018.controls
{
   public class Bgroup: StackLayout
    {
        public string word { get; set; }
        public Bgroup() {
            Button b1 = new Button(); b1.Text = "a";
            Button b2 = new Button(); b2.Text = "b";
            Button b3 = new Button(); b3.Text = "c";
            StackLayout sl = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children ={ b1,
            b2,b3}
            };
        
        }
    }
}
