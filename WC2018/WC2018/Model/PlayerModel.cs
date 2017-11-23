using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC2018.Model
{
  public  class PlayerModel
    {public string name { get; set; }
        public string age { get; set; }
        public string team { get; set; }
        public string photo { get; set; } = "tn.jpg";
        public List<string> nameSequence { get {return name.ToCharArray(0, name.Length).ToList().Select(c => c.ToString()).ToList(); } set { } }
    public static List<PlayerModel> GuetSquad(string squad) {
            var squadList = new List<PlayerModel>();

            var players = squad.Split(new string[] { "+","++" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var player in players) {
                if (!String.IsNullOrEmpty(player)) {
                    var pseudo = player;
                    //retrieve name 
                    var number = pseudo.Substring(0, pseudo.IndexOf(")")+1);
retry: try
                    {
                        pseudo = pseudo.Replace(number, "");
                    }
                    catch (Exception e) { goto retry; }
                   pseudo = pseudo.Trim();
               
                var pos= pseudo.Substring(0, 2);
                    pseudo = pseudo.Replace(pos, "");
                    pseudo = pseudo.Trim();
                    var name= pseudo.Substring(0, pseudo.IndexOf(" ") + 1);
                    retry1: try
                    {
                        pseudo = pseudo.Replace(name, ""); pseudo = pseudo.Trim();
                    }
                    catch (Exception e) { goto retry1; }
                    var lastname = pseudo.Substring(0, pseudo.IndexOf(" ") + 1);
                    retry2: try
                    {
                        pseudo = pseudo.Substring(0, pseudo.IndexOf("##") + 1);
                    }
                    catch (Exception e) { goto retry2; }
                    pseudo = pseudo.Trim();
                }
            }
            return squadList;
        }
    }


}
