using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WC2018.Model;

namespace WC2018.ViewModel
{
   public class SquadViewModel
    {
        private string file;

        public List<PlayerModel> Squad { get; set; }

        public SquadViewModel() {
            Squad = new List<PlayerModel> { new PlayerModel { name = "Buffon",age="39",team="juve" }, new PlayerModel { name = "Chiellini",age = "33", team = "juve" }, new PlayerModel { name = "Barzagli", age = "33", team = "juve" }, new PlayerModel { name = "Bonnuchi", age = "31", team = "milan" } };
        }

        public SquadViewModel(string file)
        {
            this.file = file;
        }
    }
}
