﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WC2018.Model;

namespace WC2018.ViewModel
{
    public class SquadViewModel
    {
        private string file;

        public List<PlayerModel> Squad { get; set; }
        public List<string> names { get; set; }
        public SquadViewModel() {
            Squad = new List<PlayerModel> { new PlayerModel { name = "Buffon",age="39",team="juve" }, new PlayerModel { name = "Chiellini",age = "33", team = "juve" }, new PlayerModel { name = "Barzagli", age = "33", team = "juve" }, new PlayerModel { name = "Bonnuchi", age = "31", team = "milan" } };
        }

        public SquadViewModel(string file)
        {
            LoadJson();
            this.file = file;
            Squad = new List<PlayerModel> { new PlayerModel { name = "Buffon", age = "39", team = "juve" }, new PlayerModel { name = "Chiellini", age = "33", team = "juve" }, new PlayerModel { name = "Barzagli", age = "33", team = "juve" }, new PlayerModel { name = "Bonnuchi", age = "31", team = "milan" } };
            names = new List<string> { "5+215", "kjeh", "e" };
            // PlayerModel.GuetSquad("(1)  GK  Sergio Romero                      ##  45, AS Monaco (FRA) +(12)  GK  Agustín Orión                      ##   3, Boca Juniors (ARG) +(21)  GK  Mariano Andújar                    ##  10, Catania (ITA) + + (2)  DF  Ezequiel Garay                     ##  18, Benfica (POR) + (3)  DF  Hugo Campagnaro                    ##  13, Internazionale (ITA) + (4)  DF  Pablo Zabaleta                     ##  36, Manchester City (ENG) +(15)  DF  Martín Demichelis                  ##  37, Manchester City (ENG) +(16)  DF  Marcos Rojo                        ##  20, Sporting (POR) +(17)  DF  Federico Fernández                 ##  24, Napoli (ITA) +(23)  DF  José María Basanta                 ##   8, Monterrey (MEX) + + (5)  MF  Fernando Gago                      ##  47, Boca Juniors (ARG) + (6)  MF  Lucas Biglia                       ##  16, Lazio (ITA) + (7)  MF  Ángel di María                     ##  45, Real Madrid (ESP) + (8)  MF  Enzo Pérez                         ##   5, Benfica (POR) +(11)  MF  Maxi Rodríguez                     ##  53, Newell's Old Boys (ARG) +(13)  MF  Augusto Fernández                  ##   7, Celta Vigo (ESP) +(14)  MF  Javier Mascherano                  ##  96, Barcelona (ESP) +(19)  MF  Ricardo Álvarez                    ##   5, Internazionale (ITA) + + (9)  FW  Gonzalo Higuaín                    ##  36, Napoli (ITA) +(10)  FW  Lionel Messi                       ##  84, Barcelona (ESP) +(18)  FW  Rodrigo Palacio                    ##  15, Internazionale (ITA) +(20)  FW  Sergio Agüero                      ##  50, Manchester City (ENG) +(22)  FW  Ezequiel Lavezzi                   ##  29, Paris Saint-Germain (FRA)");
        }
        public void LoadJson()
        {

            byte[] byteArray = Encoding.UTF8.GetBytes("data/1990/ar-argentina.json");
            MemoryStream stream = new MemoryStream(byteArray);
            using (System.IO.StreamReader r = new System.IO.StreamReader(stream))
            {
                string json = r.ReadToEnd();
                List<PlayerModel> items = JsonConvert.DeserializeObject<List<PlayerModel>>(json);
            }
        }

    }
}
