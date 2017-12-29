using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WC2018.Model;

namespace WC2018.ViewModel
{
    public class SquadViewModel
    {
        private string file;
        public Dictionary<string, Dictionary<string, List<PlayerModel>>> squads = new Dictionary<string, Dictionary<string, List<PlayerModel>>> ();
        public List<PlayerModel> Squad { get; set; }
        public List<string> names { get; set; }
        public SquadViewModel()
        {
            Squad = new List<PlayerModel> { new PlayerModel { name = "Buffon", age = "39", team = "juve" }, new PlayerModel { name = "Chiellini", age = "33", team = "juve" }, new PlayerModel { name = "Barzagli", age = "33", team = "juve" }, new PlayerModel { name = "Bonnuchi", age = "31", team = "milan" } };
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
    squads.Add(
"1990", new Dictionary<string, List<PlayerModel>> {

 {
 "ae-united-arab-emirates", new List<PlayerModel>
 {
 new PlayerModel {
 name = "Abdullah ", age = "-", team = "Al-Ahli", number = "(1)", lastname = "Musa " },
     new PlayerModel {
 name = "Muhsin ", age = "-", team = "Sharjah", number = "(17)", lastname = "Musabah " },
     new PlayerModel {
 name = "Abdulqadir ", age = "-", team = "Al Shabab", number = "(22)", lastname = "Hassan " },
     new PlayerModel {
 name = "Khalil ", age = "-", team = "Al Khaleej Club", number = " (2)", lastname = "Ghanim " },
     new PlayerModel {
 name = "Mubarak ", age = "-", team = "Al Khaleej Club", number = " (4)", lastname = "Ghanim " },
     new PlayerModel {
 name = "Abdulrahman ", age = "-", team = "Al-Nasr", number = " (6)", lastname = "Mohamed " },
     new PlayerModel {
 name = "Ibrahim ", age = "-", team = "Sharjah", number = "(15)", lastname = "Meer " },
     new PlayerModel {
 name = "Mohamed ", age = "-", team = "Al-Ahli", number = "(16)", lastname = "Salim " },
     new PlayerModel {
 name = "Eissa ", age = "-", team = "Sharjah", number = "(19)", lastname = "Meer " },
     new PlayerModel {
 name = "Yousuf ", age = "-", team = "Sharjah", number = "(20)", lastname = "Hussain " },
     new PlayerModel {
 name = "Abdulrahman ", age = "-", team = "Sharjah", number = "(21)", lastname = "Al-Haddad " },
   new  PlayerModel {
 name = "Ali ", age = "-", team = "Sharjah", number = " (3)", lastname = "Thani " },
     new PlayerModel {
 name = "Abdualla ", age = "-", team = "Al Khaleej Club", number = " (5)", lastname = "Sultan " },
     new PlayerModel {
 name = "Khalid ", age = "-", team = "Al-Nasr", number = " (8)", lastname = "Ismaïl " },
     new PlayerModel {
 name = "Hussain ", age = "-", team = "Sharjah", number = "(12)", lastname = "Ghuloum " },
     new PlayerModel {
 name = "Hassan ", age = "-", team = "Al-Wasl", number = "(13)", lastname = "Mohamed " },
     new PlayerModel {
 name = "Nasir ", age = "-", team = "Al-Wasl", number = "(14)", lastname = "Khamees " },
     new PlayerModel {
 name = "Fahad ", age = "-", team = "Al-Wasl", number = "(18)", lastname = "Abdulrahman " },
     new PlayerModel {
 name = "Fahad ", age = "-", team = "Al-Wasl", number = " (7)", lastname = "Khamees " },
     new PlayerModel {
 name = "Abdulaziz ", age = "-", team = "Sharjah", number = " (9)", lastname = "Mohamed " },
     new PlayerModel {
 name = "Adnan ", age = "-", team = "Al Shaab", number = "(10)", lastname = "Al " },
     new PlayerModel {
 name = "Zuhair ", age = "-", team = "Al-Wasl", number = "(11)", lastname = "Bakhit " }
 }
},
{
 "ar-argentina", new List<PlayerModel> {
 new PlayerModel {
 name = "Nery ", age = "-", team = "Real Betis", number = "(1)", lastname = "Pumpido " }, new PlayerModel {
 name = "Sergio ", age = "-", team = "Millonarios", number = "(12)", lastname = "Goycochea " }, new PlayerModel {
 name = "Fabián ", age = "-", team = "Ferro Carril Oeste", number = "(22)", lastname = "Cancelarich " }, new PlayerModel {
 name = "Edgardo ", age = "-", team = "Veracruz", number = " (5)", lastname = "Bauza " }, new PlayerModel {
 name = "Néstor ", age = "-", team = "Racing", number = "(11)", lastname = "Fabbri " }, new PlayerModel {
 name = "Néstor ", age = "-", team = "Bari", number = "(13)", lastname = "Lorenzo " }, new PlayerModel {
 name = "Pedro ", age = "-", team = "Independiente", number = "(15)", lastname = "Monzón " }, new PlayerModel {
 name = "Julio ", age = "-", team = "Racing", number = "(16)", lastname = "Olarticoechea " }, new PlayerModel {
 name = "Roberto ", age = "-", team = "Udinese", number = "(17)", lastname = "Néstor " }, new PlayerModel {
 name = "José ", age = "-", team = "River Plate", number = "(18)", lastname = "Serrizuela " }, new PlayerModel {
 name = "Oscar ", age = "-", team = "Real Madrid", number = "(19)", lastname = "Ruggeri " }, new PlayerModel {
 name = "Juan ", age = "-", team = "Boca Juniors", number = "(20)", lastname = "Simón " }, new PlayerModel {
 name = "Sergio ", age = "-", team = "River Plate", number = " (2)", lastname = "Batista " }, new PlayerModel {
 name = "José ", age = "-", team = "VfB Stuttgart", number = " (4)", lastname = "Basualdo " }, new PlayerModel {
 name = "Gabriel ", age = "-", team = "Paris Saint-Germain", number = " (6)", lastname = "Calderón " }, new PlayerModel {
 name = "Jorge ", age = "-", team = "Nantes", number = " (7)", lastname = "Burruchaga " }, new PlayerModel {
 name = "Diego ", age = "-", team = "Napoli", number = "(10)", lastname = "Maradona " }, new PlayerModel {
 name = "Ricardo ", age = "-", team = "Independiente", number = "(14)", lastname = "Giusti " }, new PlayerModel {
 name = "Pedro ", age = "-", team = "Lazio", number = "(21)", lastname = "Troglio " }, new PlayerModel {
 name = "Abel ", age = "-", team = "Udinese", number = " (3)", lastname = "Balbo " }, new PlayerModel {
 name = "Claudio ", age = "-", team = "Atalanta", number = " (8)", lastname = "Caniggia " }, new PlayerModel {
 name = "Gustavo ", age = "-", team = "Cremonese", number = " (9)", lastname = "Dezotti " }, new PlayerModel {
 name = "", age = "", team = "", number = "#", lastname = "" }, new PlayerModel {
 name = "p", age = "", team = "cements", number = "# Argentina (ARG)", lastname = "l" }, new PlayerModel {
 name = "1 ", age = "", team = "ayers", number = "#", lastname = "p" }, new PlayerModel {
 name = "Ángel ", age = "-", team = "River Plate", number = " (1)", lastname = "Comizzo " } } }, {
 "at-austria", new List<PlayerModel> {
 new PlayerModel {
 name = "Klaus ", age = "-", team = "Swarovski Tirol", number = "(1)", lastname = "Lindenberger " }, new PlayerModel {
 name = "Michael ", age = "-", team = "Rapid Vienna", number = "(21)", lastname = "Konsel " }, new PlayerModel {
 name = "Otto ", age = "-", team = "Sturm Graz", number = "(22)", lastname = "Konrad " }, new PlayerModel {
 name = "Ernst ", age = "-", team = "Austria Vienna", number = " (2)", lastname = "Aigner " }, new PlayerModel {
 name = "Robert ", age = "-", team = "Rapid Vienna", number = " (3)", lastname = "Pecl " }, new PlayerModel {
 name = "Peter ", age = "-", team = "Rapid Vienna", number = " (5)", lastname = "Schöttel " }, new PlayerModel {
 name = "Peter ", age = "-", team = "Admira Wacker", number = " (8)", lastname = "Artner " }, new PlayerModel {
 name = "Andreas ", age = "-", team = "Rapid Vienna", number = "(16)", lastname = "Reisinger " }, new PlayerModel {
 name = "Michael ", age = "-", team = "Swarovski Tirol", number = "(18)", lastname = "Streiter " }, new PlayerModel {
 name = "Anton ", age = "-", team = "Austria Vienna", number = " (4)", lastname = "Pfeffer " }, new PlayerModel {
 name = "Manfred ", age = "-", team = "Austria Vienna", number = " (6)", lastname = "Zsak " }, new PlayerModel {
 name = "Kurt ", age = "-", team = "First Vienna FC", number = " (7)", lastname = "Russ " }, new PlayerModel {
 name = "Manfred ", age = "-", team = "Swarovski Tirol", number = "(10)", lastname = "Linzmaier " }, new PlayerModel {
 name = "Alfred ", age = "-", team = "Swarovski Tirol", number = "(11)", lastname = "Hörtnagl " }, new PlayerModel {
 name = "Michael ", age = "-", team = "Swarovski Tirol", number = "(12)", lastname = "Baur " }, new PlayerModel {
 name = "Andreas ", age = "-", team = "Austria Vienna", number = "(13)", lastname = "Ogris " }, new PlayerModel {
 name = "Heimo ", age = "-", team = "Rapid Vienna", number = "(17)", lastname = "Pfeifenberger " }, new PlayerModel {
 name = "Andreas ", age = "-", team = "Rapid Vienna", number = "(20)", lastname = "Herzog " }, new PlayerModel {
 name = "Toni ", age = "-", team = "Sevilla", number = " (9)", lastname = "Polster " }, new PlayerModel {
 name = "Gerhard ", age = "-", team = "Admira Wacker", number = "(14)", lastname = "Rodax " }, new PlayerModel {
 name = "Christian ", age = "-", team = "Rapid Vienna", number = "(15)", lastname = "Keglevits " }, new PlayerModel {
 name = "Gerald ", age = "-", team = "First Vienna FC", number = "(19)", lastname = "Glatzmayer " } } }, {
 "be-belgium", new List<PlayerModel> {
 new PlayerModel {
 name = "Michel ", age = "-", team = "Mechelen", number = "(1)", lastname = "Preud'homme " }, new PlayerModel {
 name = "Gilbert ", age = "-", team = "Standard Liège", number = "(12)", lastname = "Bodart " }, new PlayerModel {
 name = "Filip ", age = "-", team = "Anderlecht", number = "(20)", lastname = "De " }, new PlayerModel {
 name = "Eric ", age = "-", team = "PSV", number = " (2)", lastname = "Gerets " }, new PlayerModel {
 name = "Philippe ", age = "-", team = "Mechelen", number = " (3)", lastname = "Albert " }, new PlayerModel {
 name = "Lei ", age = "-", team = "Mechelen", number = " (4)", lastname = "Clijsters " }, new PlayerModel {
 name = "Marc ", age = "-", team = "Mechelen", number = " (6)", lastname = "Emmers " }, new PlayerModel {
 name = "Stéphane ", age = "-", team = "Porto", number = " (7)", lastname = "Demol " }, new PlayerModel {
 name = "Georges ", age = "-", team = "Anderlecht", number = "(13)", lastname = "Grün " }, new PlayerModel {
 name = "Michel ", age = "-", team = "Kortrijk", number = "(16)", lastname = "De " }, new PlayerModel {
 name = "Pascal ", age = "-", team = "Club Brugge", number = "(17)", lastname = "Plovie " }, new PlayerModel {
 name = "Bruno ", age = "-", team = "Mechelen", number = " (5)", lastname = "Versavel " }, new PlayerModel {
 name = "Franky ", age = "-", team = "Club Brugge", number = " (8)", lastname = "Van " }, new PlayerModel {
 name = "Enzo ", age = "-", team = "Auxerre", number = "(10)", lastname = "Scifo " }, new PlayerModel {
 name = "Jean-François ", age = "-", team = "FC Liège", number = "(15)", lastname = "De " }, new PlayerModel {
 name = "Lorenzo ", age = "-", team = "Club Brugge", number = "(18)", lastname = "Staelens " }, new PlayerModel {
 name = "Marc ", age = "-", team = "Mechelen", number = "(21)", lastname = "Wilmots " }, new PlayerModel {
 name = "Patrick ", age = "-", team = "Anderlecht", number = "(22)", lastname = "Vervoort " }, new PlayerModel {
 name = "Marc ", age = "-", team = "Anderlecht", number = " (9)", lastname = "Degryse " }, new PlayerModel {
 name = "Jan ", age = "-", team = "Club Brugge", number = "(11)", lastname = "Ceulemans " }, new PlayerModel {
 name = "Nico ", age = "-", team = "Royal Antwerp", number = "(14)", lastname = "Claesen " }, new PlayerModel {
 name = "Marc ", age = "-", team = "Anderlecht", number = "(19)", lastname = "Van " } } }, {
 "br-brazil", new List<PlayerModel> {
 new PlayerModel {
 name = "Taffarel ", age = "-", team = "Internacional", number = "(1)", lastname = "## " }, new PlayerModel {
 name = "Acácio ", age = "-", team = "Vasco da Gama", number = "(12)", lastname = "## " }, new PlayerModel {
 name = "Zé ", age = "-", team = "Flamengo", number = "(22)", lastname = "Carlos " }, new PlayerModel {
 name = "Jorginho ", age = "-", team = "Bayer Leverkusen", number = " (2)", lastname = "## " }, new PlayerModel {
 name = "Ricardo ", age = "-", team = "Benfica", number = " (3)", lastname = "Gomes " }, new PlayerModel {
 name = "Branco ", age = "-", team = "Porto", number = " (6)", lastname = "## " }, new PlayerModel {
 name = "Carlos ", age = "-", team = "Marseille", number = "(13)", lastname = "Mozer " }, new PlayerModel {
 name = "Aldair ", age = "-", team = "Benfica", number = "(14)", lastname = "## " }, new PlayerModel {
 name = "Ricardo ", age = "-", team = "São Paulo", number = "(19)", lastname = "Rocha " }, new PlayerModel {
 name = "Mauro ", age = "-", team = "Botafogo", number = "(21)", lastname = "Galvão " }, new PlayerModel {
 name = "Dunga ", age = "-", team = "Fiorentina", number = " (4)", lastname = "## " }, new PlayerModel {
 name = "Alemão ", age = "-", team = "Napoli", number = " (5)", lastname = "## " }, new PlayerModel {
 name = "Bismarck ", age = "-", team = "Vasco da Gama", number = " (7)", lastname = "## " }, new PlayerModel {
 name = "Valdo ", age = "-", team = "Benfica", number = " (8)", lastname = "## " }, new PlayerModel {
 name = "Silas ", age = "-", team = "Central Español", number = "(10)", lastname = "## " }, new PlayerModel {
 name = "Mazinho ", age = "-", team = "Vasco da Gama", number = "(18)", lastname = "## " }, new PlayerModel {
 name = "Careca ", age = "-", team = "Napoli", number = " (9)", lastname = "## " }, new PlayerModel {
 name = "Romário ", age = "-", team = "PSV", number = "(11)", lastname = "## " }, new PlayerModel {
 name = "Müller ", age = "-", team = "Torino", number = "(15)", lastname = "## " }, new PlayerModel {
 name = "Bebeto ", age = "-", team = "Vasco da Gama", number = "(16)", lastname = "## " }, new PlayerModel {
 name = "Renato ", age = "-", team = "Flamengo", number = "(17)", lastname = "Gaúcho " }, new PlayerModel {
 name = "Tita ", age = "-", team = "Vasco da Gama", number = "(20)", lastname = "## " } } }, {
 "cm-cameroon", new List<PlayerModel> {
 new PlayerModel {
 name = "Joseph-Antoine ", age = "-", team = "Bordeaux", number = "(1)", lastname = "Bell " }, new PlayerModel {
 name = "Thomas ", age = "-", team = "Espanyol", number = "(16)", lastname = "N'Kono " }, new PlayerModel {
 name = "Jacques ", age = "-", team = "Toulon", number = "(22)", lastname = "Songo'o " }, new PlayerModel {
 name = "André ", age = "-", team = "Metz", number = " (2)", lastname = "Kana-Biyik " }, new PlayerModel {
 name = "Jules ", age = "-", team = "Canon Yaoundé", number = " (3)", lastname = "Onana " }, new PlayerModel {
 name = "Benjamin ", age = "-", team = "Créteil", number = " (4)", lastname = "Massing " }, new PlayerModel {
 name = "Bertin ", age = "-", team = "Tonnerre Yaoundé", number = " (5)", lastname = "Ebwellé " }, new PlayerModel {
 name = "Alphonse ", age = "-", team = "Canon Yaoundé", number = "(12)", lastname = "Yombi " }, new PlayerModel {
 name = "Stephen ", age = "-", team = "Tonnerre Yaoundé", number = "(14)", lastname = "Tataw " }, new PlayerModel {
 name = "Victor ", age = "-", team = "Canon Yaoundé", number = "(17)", lastname = "N'Dip " }, new PlayerModel {
 name = "Emmanuel ", age = "-", team = "Prévoyance Yaoundé", number = " (6)", lastname = "Kundé " }, new PlayerModel {
 name = "Emile ", age = "-", team = "Le Havre", number = " (8)", lastname = "M'Bouh " }, new PlayerModel {
 name = "Jean-Claude ", age = "-", team = "La Roche Vendée", number = "(13)", lastname = "Pagal " }, new PlayerModel {
 name = "Thomas ", age = "-", team = "Tonnerre Yaoundé", number = "(15)", lastname = "Libiih " }, new PlayerModel {
 name = "Roger ", age = "-", team = "Union Douala", number = "(19)", lastname = "Feutmba " }, new PlayerModel {
 name = "Cyrille ", age = "-", team = "Toulon", number = "(20)", lastname = "Makanaky " }, new PlayerModel {
 name = "Emmanuel ", age = "-", team = "Canon Yaoundé", number = "(21)", lastname = "Maboang " }, new PlayerModel {
 name = "François ", age = "-", team = "Stade Lavallois", number = " (7)", lastname = "Omam-Biyik " }, new PlayerModel {
 name = "Roger ", age = "-", team = "JS Saint-Pierroise", number = " (9)", lastname = "Milla " }, new PlayerModel {
 name = "Louis-Paul ", age = "-", team = "Canon Yaoundé", number = "(10)", lastname = "M'Fédé " }, new PlayerModel {
 name = "Eugène ", age = "-", team = "Valenciennes", number = "(11)", lastname = "Ekéké " }, new PlayerModel {
 name = "Bonaventure ", age = "-", team = "Union Douala", number = "(18)", lastname = "Djonkep " } } }, {
 "co-colombia", new List<PlayerModel> {
 new PlayerModel {
 name = "René ", age = "-", team = "Atlético Nacional", number = "(1)", lastname = "Higuita " }, new PlayerModel {
 name = "Eduardo ", age = "-", team = "Independiente Santa Fe", number = "(12)", lastname = "Niño " }, new PlayerModel {
 name = "Andrés ", age = "-", team = "Young Boys", number = " (2)", lastname = "Escobar " }, new PlayerModel {
 name = "Gildardo ", age = "-", team = "Atlético Nacional", number = " (3)", lastname = "Gómez " }, new PlayerModel {
 name = "Luis ", age = "-", team = "Atlético Nacional", number = " (4)", lastname = "Fernando " }, new PlayerModel {
 name = "José ", age = "-", team = "Atlético Nacional", number = " (6)", lastname = "Ricardo " }, new PlayerModel {
 name = "Carlos ", age = "-", team = "Atlético Junior", number = "(13)", lastname = "Hoyos " }, new PlayerModel {
 name = "Luis ", age = "-", team = "Atlético Nacional", number = "(15)", lastname = "Carlos " }, new PlayerModel {
 name = "Geovanis ", age = "-", team = "Millonarios", number = "(17)", lastname = "Cassiani " }, new PlayerModel {
 name = "Wilmer ", age = "-", team = "América de Cali", number = "(18)", lastname = "Cabrera " }, new PlayerModel {
 name = "Alexis ", age = "-", team = "Atlético Junior", number = "(21)", lastname = "Mendoza " }, new PlayerModel {
 name = "Gabriel ", age = "-", team = "Independiente Medellín", number = " (8)", lastname = "Gómez " }, new PlayerModel {
 name = "Carlos ", age = "-", team = "Montpellier", number = "(10)", lastname = "Valderrama " }, new PlayerModel {
 name = "Bernardo ", age = "-", team = "Deportivo Cali", number = "(11)", lastname = "Redín " }, new PlayerModel {
 name = "Leonel ", age = "-", team = "Atlético Nacional", number = "(14)", lastname = "Álvarez " }, new PlayerModel {
 name = "Freddy ", age = "-", team = "América de Cali", number = "(19)", lastname = "Rincón " }, new PlayerModel {
 name = "Luis ", age = "-", team = "Atlético Nacional", number = "(20)", lastname = "Fajardo " }, new PlayerModel {
 name = "León ", age = "-", team = "Atlético Nacional", number = " (5)", lastname = "Villa " }, new PlayerModel {
 name = "Carlos ", age = "-", team = "Millonarios", number = " (7)", lastname = "Estrada " }, new PlayerModel {
 name = "Miguel ", age = "-", team = "América de Cali", number = " (9)", lastname = "Guerrero " }, new PlayerModel {
 name = "Arnoldo ", age = "-", team = "Millonarios", number = "(16)", lastname = "Iguarán " }, new PlayerModel {
 name = "Rubén ", age = "-", team = "Millonarios", number = "(22)", lastname = "Darío " } } }, {
 "cr-costa-rica", new List<PlayerModel> {
 new PlayerModel {
 name = "Luis ", age = "-", team = "AD Ramonense", number = "(1)", lastname = "Gabelo " }, new PlayerModel {
 name = "Hermidio ", age = "-", team = "Municipal Puntarenas", number = "(21)", lastname = "Barrantes " }, new PlayerModel {
 name = "Miguel ", age = "-", team = "Deportivo Saprissa", number = "(22)", lastname = "Segura " }, new PlayerModel {
 name = "Vladimir ", age = "-", team = "Deportivo Saprissa", number = " (2)", lastname = "Quesada " }, new PlayerModel {
 name = "Róger ", age = "-", team = "Deportivo Saprissa", number = " (3)", lastname = "Flores " }, new PlayerModel {
 name = "Rónald ", age = "-", team = "Deportivo Saprissa", number = " (4)", lastname = "González " }, new PlayerModel {
 name = "Marvin ", age = "-", team = "CS Herediano", number = " (5)", lastname = "Obando " }, new PlayerModel {
 name = "Miguel ", age = "-", team = "Alajuelense", number = "(13)", lastname = "Davis " }, new PlayerModel {
 name = "Rónald ", age = "-", team = "CS Herediano", number = "(15)", lastname = "Marín " }, new PlayerModel {
 name = "Geovanny ", age = "-", team = "CS Herediano", number = "(18)", lastname = "Jara " }, new PlayerModel {
 name = "Mauricio ", age = "-", team = "Alajuelense", number = "(20)", lastname = "Montero " }, new PlayerModel {
 name = "José ", age = "-", team = "LD Alajuelense", number = " (6)", lastname = "Carlos " }, new PlayerModel {
 name = "Germán ", age = "-", team = "CS Herediano", number = " (8)", lastname = "Chavarría " }, new PlayerModel {
 name = "Oscar ", age = "-", team = "Alajuelense", number = "(10)", lastname = "Ramírez " }, new PlayerModel {
 name = "Róger ", age = "-", team = "CS Cartaginés", number = "(12)", lastname = "Gómez " }, new PlayerModel {
 name = "Juan ", age = "-", team = "Deportivo Saprissa", number = "(14)", lastname = "Cayasso " }, new PlayerModel {
 name = "José ", age = "-", team = "Deportivo Saprissa", number = "(16)", lastname = "Jaikel " }, new PlayerModel {
 name = "Héctor ", age = "-", team = "CS Cartaginés", number = "(19)", lastname = "Marchena " }, new PlayerModel {
 name = "Hernán ", age = "-", team = "Deportivo Saprissa", number = " (7)", lastname = "Medford " }, new PlayerModel {
 name = "Alexandre ", age = "-", team = "Deportivo Saprissa", number = " (9)", lastname = "Guimarães " }, new PlayerModel {
 name = "Claudio ", age = "-", team = "CS Herediano", number = "(11)", lastname = "Jara " }, new PlayerModel {
 name = "Roy ", age = "-", team = "AS Limonense", number = "(17)", lastname = "Myers " } } }, {
 "eg-egypt", new List<PlayerModel> {
 new PlayerModel {
 name = "Ahmed ", age = "-", team = "Al-Ahly", number = "(1)", lastname = "Shobair " }, new PlayerModel {
 name = "Ayman ", age = "-", team = "Zamalek", number = "(21)", lastname = "Taher " }, new PlayerModel {
 name = "Thabet ", age = "-", team = "Al-Ahly", number = "(22)", lastname = "El-Batal " }, new PlayerModel {
 name = "Ibrahim ", age = "-", team = "Al-Ahly", number = " (2)", lastname = "Hassan " }, new PlayerModel {
 name = "Rabie ", age = "-", team = "Al-Ahly", number = " (3)", lastname = "Yassin " }, new PlayerModel {
 name = "Hany ", age = "-", team = "Al-Ahly", number = " (4)", lastname = "Ramzy " }, new PlayerModel {
 name = "Hesham ", age = "-", team = "Zamalek", number = " (5)", lastname = "Yakan " }, new PlayerModel {
 name = "Ashraf ", age = "-", team = "Zamalek", number = " (6)", lastname = "Kasem " }, new PlayerModel {
 name = "Ahmed ", age = "-", team = "Zamalek", number = "(13)", lastname = "Ramzy " }, new PlayerModel {
 name = "Magdi ", age = "-", team = "Beira-Mar", number = " (8)", lastname = "Abdelghani " }, new PlayerModel {
 name = "Gamal ", age = "-", team = "Zamalek", number = "(10)", lastname = "Abdelhamid " }, new PlayerModel {
 name = "Taher ", age = "-", team = "Al-Ahly", number = "(12)", lastname = "Abouzaid " }, new PlayerModel {
 name = "Alaa ", age = "-", team = "Al-Ahly", number = "(14)", lastname = "Maihoub " }, new PlayerModel {
 name = "Saber ", age = "-", team = "Ghazl El-Mehalla", number = "(15)", lastname = "Eid " }, new PlayerModel {
 name = "Magdy ", age = "-", team = "PAOK", number = "(16)", lastname = "Tolba " }, new PlayerModel {
 name = "Osama ", age = "-", team = "Al-Ahly", number = "(18)", lastname = "Oraby " }, new PlayerModel {
 name = "Ahmed ", age = "-", team = "El-Olympi Alexandria", number = "(20)", lastname = "El-Kass " }, new PlayerModel {
 name = "Ismail ", age = "-", team = "Zamalek", number = " (7)", lastname = "Youssef " }, new PlayerModel {
 name = "Hossam ", age = "-", team = "Al-Ahly", number = " (9)", lastname = "Hassan " }, new PlayerModel {
 name = "Tarek ", age = "-", team = "Al-Masry", number = "(11)", lastname = "Soliman " }, new PlayerModel {
 name = "Ayman ", age = "-", team = "Al-Ahly", number = "(17)", lastname = "Shawky " }, new PlayerModel {
 name = "Adel ", age = "-", team = "Al-Ahly", number = "(19)", lastname = "Abdelrahman " } } }, {
 "en-england", new List<PlayerModel> {
 new PlayerModel {
 name = "Peter ", age = "118", team = "Derby County", number = "(1)", lastname = "Shilton " }, new PlayerModel {
 name = "K", age = "2", team = "QueensParkRangers", number = " ", lastname = "D" }, new PlayerModel {
 name = "Chris ", age = "16", team = "Rangers", number = "(13)", lastname = "Woods " }, new PlayerModel {
 name = "K", age = "2", team = "Chelsea", number = " ", lastname = "D" }, new PlayerModel {
 name = "Gary ", age = "39", team = "Rangers", number = " (2)", lastname = "Stevens " }, new PlayerModel {
 name = "Stuart ", age = "24", team = "Nottingham Forest", number = " (3)", lastname = "Pearce " }, new PlayerModel {
 name = "Des ", age = "18", team = "Nottingham Forest", number = " (5)", lastname = "Walker " }, new PlayerModel {
 name = "Terry ", age = "72", team = "Rangers", number = " (6)", lastname = "Butcher " }, new PlayerModel {
 name = "Paul ", age = "5", team = "Queens Park Rangers", number = "(12)", lastname = "Parker " }, new PlayerModel {
 name = "Mark ", age = "24", team = "Derby County", number = "(14)", lastname = "Wright " }, new PlayerModel {
 name = "Tony ", age = "3", team = "Chelsea", number = "(15)", lastname = "Dorigo " }, new PlayerModel {
 name = "Neil ", age = "24", team = "Manchester United", number = " (4)", lastname = "Webb " }, new PlayerModel {
 name = "Bryan ", age = "85", team = "Manchester United", number = " (7)", lastname = "Robson " }, new PlayerModel {
 name = "Chris ", age = "52", team = "Marseille", number = " (8)", lastname = "Waddle " }, new PlayerModel {
 name = "John ", age = "53", team = "Liverpool", number = "(11)", lastname = "Barnes " }, new PlayerModel {
 name = "Steve ", age = "12", team = "Liverpool", number = "(16)", lastname = "McMahon " }, new PlayerModel {
 name = "David ", age = "5", team = "Aston Villa", number = "(17)", lastname = "Platt " }, new PlayerModel {
 name = "Steve ", age = "22", team = "Nottingham Forest", number = "(18)", lastname = "Hodge " }, new PlayerModel {
 name = "Paul ", age = "11", team = "Tottenham Hotspur", number = "(19)", lastname = "Gascoigne " }, new PlayerModel {
 name = "Trevor ", age = "26", team = "Rangers", number = "(20)", lastname = "Steven " }, new PlayerModel {
 name = "Peter ", age = "40", team = "Liverpool", number = " (9)", lastname = "Beardsley " }, new PlayerModel {
 name = "Gary ", age = "51", team = "Tottenham Hotspur", number = "(10)", lastname = "Lineker " }, new PlayerModel {
 name = "Steve ", age = "7", team = "Wolverhampton Wanderers", number = "(21)", lastname = "Bull " } } }, {
 "es-espana", new List<PlayerModel> {
 new PlayerModel {
 name = "Andoni ", age = "49", team = "Barcelona", number = "(1)", lastname = "Zubizarreta " }, new PlayerModel {
 name = "Juan ", age = "2", team = "Sporting Gijón", number = "(13)", lastname = "Carlos " }, new PlayerModel {
 name = "José ", age = "1", team = "Valencia", number = "(22)", lastname = "Manuel " }, new PlayerModel {
 name = "Chendo ", age = "17", team = "Real Madrid", number = " (2)", lastname = "## " }, new PlayerModel {
 name = "Manuel ", age = "13", team = "Sevilla", number = " (3)", lastname = "Jiménez " }, new PlayerModel {
 name = "Genar ", age = "24", team = "Athletic Club", number = " (4)", lastname = "Andrinúa " }, new PlayerModel {
 name = "Manuel ", age = "30", team = "Real Madrid", number = " (5)", lastname = "Sanchís " }, new PlayerModel {
 name = "Quique ", age = "11", team = "Valencia", number = " (8)", lastname = "## " }, new PlayerModel {
 name = "Rafael ", age = "1", team = "Athletic Club", number = "(12)", lastname = "Alkorta " }, new PlayerModel {
 name = "Alberto ", age = "8", team = "Real Sociedad", number = "(14)", lastname = "Górriz " }, new PlayerModel {
 name = "Fernando ", age = "2", team = "Real Madrid", number = "(17)", lastname = "Hierro " }, new PlayerModel {
 name = "Rafael ", age = "22", team = "Real Madrid", number = " (6)", lastname = "Martín " }, new PlayerModel {
 name = "Fernando ", age = "2", team = "Valencia", number = "(10)", lastname = "## " }, new PlayerModel {
 name = "Francisco ", age = "7", team = "Real Zaragoza", number = "(11)", lastname = "Villarroya " }, new PlayerModel {
 name = "Roberto ", age = "22", team = "Barcelona", number = "(15)", lastname = "## " }, new PlayerModel {
 name = "José ", age = "11", team = "Barcelona", number = "(16)", lastname = "Mari " }, new PlayerModel {
 name = "Rafael ", age = "3", team = "Sevilla", number = "(18)", lastname = "Paz " }, new PlayerModel {
 name = "Míchel ", age = "44", team = "Real Madrid", number = "(21)", lastname = "## " }, new PlayerModel {
 name = "Miguel ", age = "4", team = "Real Zaragoza", number = " (7)", lastname = "Pardeza " }, new PlayerModel {
 name = "Emilio ", age = "49", team = "Real Madrid", number = " (9)", lastname = "Butragueño " }, new PlayerModel {
 name = "Julio ", age = "26", team = "Barcelona", number = "(19)", lastname = "Salinas " }, new PlayerModel {
 name = "Manolo ", age = "13", team = "Atlético Madrid", number = "(20)", lastname = "## " } } }, {
 "frg-west-germany", new List<PlayerModel> {
 new PlayerModel {
 name = "Bodo ", age = "15", team = "1. FC Köln", number = " (1)", lastname = "Illgner " }, new PlayerModel {
 name = "Raimond ", age = "3", team = "Bayern Munich", number = "(12)", lastname = "Aumann " }, new PlayerModel {
 name = "Andreas ", age = "1", team = "1. FC Nürnberg", number = "(22)", lastname = "Köpke " }, new PlayerModel {
 name = "Stefan ", age = "16", team = "Bayern Munich", number = " (2)", lastname = "Reuter " }, new PlayerModel {
 name = "Andreas ", age = "51", team = "Internazionale", number = " (3)", lastname = "Brehme " }, new PlayerModel {
 name = "Jürgen ", age = "27", team = "Bayern Munich", number = " (4)", lastname = "Kohler " }, new PlayerModel {
 name = "Klaus ", age = "20", team = "Bayern Munich", number = " (5)", lastname = "Augenthaler " }, new PlayerModel {
 name = "Guido ", age = "32", team = "VfB Stuttgart", number = " (6)", lastname = "Buchwald " }, new PlayerModel {
 name = "Thomas ", age = "35", team = "Roma", number = "(14)", lastname = "Berthold " }, new PlayerModel {
 name = "Paul ", age = "1", team = "1. FC Köln", number = "(16)", lastname = "Steiner " }, new PlayerModel {
 name = "Hans ", age = "10", team = "Bayern Munich", number = "(19)", lastname = "Pflügler " }, new PlayerModel {
 name = "Pierre ", age = "67", team = "1. FC Köln", number = " (7)", lastname = "Littbarski " }, new PlayerModel {
 name = "Thomas ", age = "12", team = "1. FC Köln", number = " (8)", lastname = "Häßler " }, new PlayerModel {
 name = "Lothar ", age = "74", team = "Internazionale", number = "(10)", lastname = "Matthäus " }, new PlayerModel {
 name = "Uwe ", age = "6", team = "Eintracht Frankfurt", number = "(15)", lastname = "Bein " }, new PlayerModel {
 name = "Andreas ", age = "10", team = "Borussia Dortmund", number = "(17)", lastname = "Möller " }, new PlayerModel {
 name = "Olaf ", age = "33", team = "Bayern Munich", number = "(20)", lastname = "Thon " }, new PlayerModel {
 name = "Günter ", age = "2", team = "Werder Bremen", number = "(21)", lastname = "Hermann " }, new PlayerModel {
 name = "Rudi ", age = "63", team = "Roma", number = " (9)", lastname = "Völler " }, new PlayerModel {
 name = "Frank ", age = "17", team = "Borussia Dortmund", number = "(11)", lastname = "Mill " }, new PlayerModel {
 name = "Karl-Heinz ", age = "6", team = "Werder Bremen", number = "(13)", lastname = "Riedle " }, new PlayerModel {
 name = "Jürgen ", age = "18", team = "Internazionale", number = "(18)", lastname = "Klinsmann " } } }, {
 "ie-ireland", new List<PlayerModel> {
 new PlayerModel {
 name = "Packie ", age = "38", team = "Celtic", number = "(1)", lastname = "Bonner " }, new PlayerModel {
 name = "Gerry ", age = "28", team = "Bournemouth", number = "(22)", lastname = "Peyton " }, new PlayerModel {
 name = "Chris ", age = "21", team = "Celtic", number = " (2)", lastname = "Morris " }, new PlayerModel {
 name = "Steve ", age = "13", team = "Liverpool", number = " (3)", lastname = "Staunton " }, new PlayerModel {
 name = "Mick ", age = "42", team = "Millwall", number = " (4)", lastname = "McCarthy " }, new PlayerModel {
 name = "Kevin ", age = "55", team = "Blackburn Rovers", number = " (5)", lastname = "Moran " }, new PlayerModel {
 name = "Paul ", age = "36", team = "Aston Villa", number = " (7)", lastname = "McGrath " }, new PlayerModel {
 name = "David ", age = "51", team = "Arsenal", number = "(12)", lastname = "O'Leary " }, new PlayerModel {
 name = "Chris ", age = "50", team = "Tottenham Hotspur", number = "(14)", lastname = "Hughton " }, new PlayerModel {
 name = "John ", age = "19", team = "Le Havre", number = "(20)", lastname = "Byrne " }, new PlayerModel {
 name = "Ronnie ", age = "38", team = "Liverpool", number = " (6)", lastname = "Whelan " }, new PlayerModel {
 name = "Ray ", age = "29", team = "Liverpool", number = " (8)", lastname = "Houghton " }, new PlayerModel {
 name = "Kevin ", age = "28", team = "Everton", number = "(11)", lastname = "Sheedy " }, new PlayerModel {
 name = "Andy ", age = "12", team = "Norwich City", number = "(13)", lastname = "Townsend " }, new PlayerModel {
 name = "John ", age = "8", team = "Sheffield Wednesday", number = "(16)", lastname = "Sheridan " }, new PlayerModel {
 name = "Alan ", age = "1", team = "Swindon Town", number = "(21)", lastname = "McLoughlin " }, new PlayerModel {
 name = "John ", age = "30", team = "Real Sociedad", number = " (9)", lastname = "Aldridge " }, new PlayerModel {
 name = "Tony ", age = "21", team = "Aston Villa", number = "(10)", lastname = "Cascarino " }, new PlayerModel {
 name = "Bernie ", age = "4", team = "Middlesbrough", number = "(15)", lastname = "Slaven " }, new PlayerModel {
 name = "Niall ", age = "15", team = "Manchester City", number = "(17)", lastname = "Quinn " }, new PlayerModel {
 name = "Frank ", age = "71", team = "Blackburn Rovers", number = "(18)", lastname = "Stapleton " }, new PlayerModel {
 name = "David ", age = "6", team = "Leicester City", number = "(19)", lastname = "Kelly " } } }, {
 "it-italy", new List<PlayerModel> {
 new PlayerModel {
 name = "Walter ", age = "35", team = "Internazionale", number = "(1)", lastname = "Zenga " }, new PlayerModel {
 name = "Stefano ", age = "5", team = "Juventus", number = "(12)", lastname = "Tacconi " }, new PlayerModel {
 name = "Gianluca ", age = "0", team = "Sampdoria", number = "(22)", lastname = "Pagliuca " }, new PlayerModel {
 name = "Franco ", age = "39", team = "Milan", number = " (2)", lastname = "Baresi " }, new PlayerModel {
 name = "Giuseppe ", age = "65", team = "Internazionale", number = " (3)", lastname = "Bergomi " }, new PlayerModel {
 name = "Luigi ", age = "24", team = "Juventus", number = " (4)", lastname = "De " }, new PlayerModel {
 name = "Ciro ", age = "16", team = "Napoli", number = " (5)", lastname = "Ferrara " }, new PlayerModel {
 name = "Riccardo ", age = "29", team = "Internazionale", number = " (6)", lastname = "Ferri " }, new PlayerModel {
 name = "Paolo ", age = "19", team = "Milan", number = " (7)", lastname = "Maldini " }, new PlayerModel {
 name = "Pietro ", age = "29", team = "Sampdoria", number = " (8)", lastname = "Vierchowod " }, new PlayerModel {
 name = "Carlo ", age = "22", team = "Milan", number = " (9)", lastname = "Ancelotti " }, new PlayerModel {
 name = "Nicola ", age = "11", team = "Internazionale", number = "(10)", lastname = "Berti " }, new PlayerModel {
 name = "Fernando ", age = "38", team = "Napoli", number = "(11)", lastname = "De " }, new PlayerModel {
 name = "Giuseppe ", age = "34", team = "Roma", number = "(13)", lastname = "Giannini " }, new PlayerModel {
 name = "Giancarlo ", age = "7", team = "Juventus", number = "(14)", lastname = "Marocchi " }, new PlayerModel {
 name = "Roberto ", age = "29", team = "Milan", number = "(17)", lastname = "Donadoni " }, new PlayerModel {
 name = "Roberto ", age = "8", team = "Fiorentina", number = "(15)", lastname = "Baggio " }, new PlayerModel {
 name = "Andrea ", age = "8", team = "Napoli", number = "(16)", lastname = "Carnevale " }, new PlayerModel {
 name = "Roberto ", age = "20", team = "Sampdoria", number = "(18)", lastname = "Mancini " }, new PlayerModel {
 name = "Salvatore ", age = "1", team = "Juventus", number = "(19)", lastname = "Schillaci " }, new PlayerModel {
 name = "Aldo ", age = "18", team = "Internazionale", number = "(20)", lastname = "Serena " }, new PlayerModel {
 name = "Gianluca ", age = "42", team = "Sampdoria", number = "(21)", lastname = "Vialli " } } }, {
 "kr-south-korea", new List<PlayerModel> {
 new PlayerModel {
 name = "Kim ", age = "-", team = "Daewoo Royals", number = "(1)", lastname = "Poong-Joo " }, new PlayerModel {
 name = "Jeong ", age = "-", team = "POSCO Atoms", number = "(19)", lastname = "Gi-Dong " }, new PlayerModel {
 name = "Choi ", age = "-", team = "Hyundai Horangi", number = "(21)", lastname = "In-Young " }, new PlayerModel {
 name = "Park ", age = "-", team = "POSCO Atoms", number = " (2)", lastname = "Kyung-Hoon " }, new PlayerModel {
 name = "Choi ", age = "-", team = "Hyundai Horangi", number = " (3)", lastname = "Kang-Hee " }, new PlayerModel {
 name = "Chung ", age = "-", team = "Daewoo Royals", number = " (5)", lastname = "Yong-Hwan " }, new PlayerModel {
 name = "Noh ", age = "-", team = "Yukong Elephants", number = " (7)", lastname = "Soo-Jin " }, new PlayerModel {
 name = "Chung ", age = "-", team = "Hyundai Horangi", number = "(13)", lastname = "Jong-Soo " }, new PlayerModel {
 name = "Cho ", age = "-", team = "Lucky-Goldstar Hwangso", number = "(15)", lastname = "Min-Kook " }, new PlayerModel {
 name = "Gu ", age = "-", team = "Lucky-Goldstar Hwangso", number = "(17)", lastname = "Sang-Bum " }, new PlayerModel {
 name = "Hong ", age = "-", team = "Korea University", number = "(20)", lastname = "Myung-Bo " }, new PlayerModel {
 name = "Yoon ", age = "-", team = "Hyundai Horangi", number = " (4)", lastname = "Deuk-Yeo " }, new PlayerModel {
 name = "Lee ", age = "-", team = "Daewoo Royals", number = " (6)", lastname = "Tae-Ho " }, new PlayerModel {
 name = "Lee ", age = "-", team = "Ilhwa Chunma", number = "(10)", lastname = "Sang-Yoon " }, new PlayerModel {
 name = "Lee ", age = "-", team = "POSCO Atoms", number = "(12)", lastname = "Heung-Sil " }, new PlayerModel {
 name = "Choi ", age = "-", team = "Lucky-Goldstar Hwangso", number = "(14)", lastname = "Soon-Ho " }, new PlayerModel {
 name = "Kim ", age = "-", team = "Daewoo Royals", number = "(16)", lastname = "Joo-Sung " }, new PlayerModel {
 name = "Lee ", age = "-", team = "Lucky-Goldstar Hwangso", number = "(22)", lastname = "Young-jin " }, new PlayerModel {
 name = "Chung ", age = "-", team = "Daewoo Royals", number = " (8)", lastname = "Hae-Won " }, new PlayerModel {
 name = "Hwangbo ", age = "-", team = "Yukong Elephants", number = " (9)", lastname = "Kwan " }, new PlayerModel {
 name = "Byun ", age = "-", team = "Hyundai Horangi", number = "(11)", lastname = "Byung-Joo " }, new PlayerModel {
 name = "Hwang ", age = "-", team = "Konkuk University", number = "(18)", lastname = "Sun-Hong " } } }, {
 "nl-netherlands", new List<PlayerModel> {
 new PlayerModel {
 name = "Hans ", age = "52", team = "PSV", number = "(1)", lastname = "van " }, new PlayerModel {
 name = "Joop ", age = "6", team = "Feyenoord", number = "(16)", lastname = "Hiele " }, new PlayerModel {
 name = "Stanley ", age = "1", team = "Ajax", number = "(22)", lastname = "Menzo " }, new PlayerModel {
 name = "Berry ", age = "22", team = "PSV", number = " (2)", lastname = "van " }, new PlayerModel {
 name = "Ronald ", age = "43", team = "Barcelona", number = " (4)", lastname = "Koeman " }, new PlayerModel {
 name = "Adri ", age = "40", team = "Anderlecht", number = " (5)", lastname = "van " }, new PlayerModel {
 name = "Graeme ", age = "7", team = "Mechelen", number = "(13)", lastname = "Rutjes " }, new PlayerModel {
 name = "Henk ", age = "2", team = "Roda JC", number = "(18)", lastname = "Fräser " }, new PlayerModel {
 name = "Danny ", age = "5", team = "Ajax", number = "(21)", lastname = "Blind " }, new PlayerModel {
 name = "Frank ", age = "42", team = "Milan", number = " (3)", lastname = "Rijkaard " }, new PlayerModel {
 name = "Jan ", age = "30", team = "Ajax", number = " (6)", lastname = "Wouters " }, new PlayerModel {
 name = "Erwin ", age = "23", team = "Mechelen", number = " (7)", lastname = "Koeman " }, new PlayerModel {
 name = "Gerald ", age = "36", team = "PSV", number = " (8)", lastname = "Vanenburg " }, new PlayerModel {
 name = "Ruud ", age = "44", team = "Milan", number = "(10)", lastname = "Gullit " }, new PlayerModel {
 name = "Richard ", age = "4", team = "Ajax", number = "(11)", lastname = "Witschge " }, new PlayerModel {
 name = "John ", age = "22", team = "Ajax", number = "(14)", lastname = "van " }, new PlayerModel {
 name = "Bryan ", age = "2", team = "Ajax", number = "(15)", lastname = "Roy " }, new PlayerModel {
 name = "Aron ", age = "11", team = "Ajax", number = "(20)", lastname = "Winter " }, new PlayerModel {
 name = "Marco ", age = "35", team = "Milan", number = " (9)", lastname = "van " }, new PlayerModel {
 name = "Wim ", age = "27", team = "PSV", number = "(12)", lastname = "Kieft " }, new PlayerModel {
 name = "Hans ", age = "2", team = "Aberdeen", number = "(17)", lastname = "Gillhaus " }, new PlayerModel {
 name = "John ", age = "6", team = "Roda JC", number = "(19)", lastname = "van " } } }, {
 "ro-romania", new List<PlayerModel> {
 new PlayerModel {
 name = "Silviu ", age = "65", team = "Steaua Bucureşti", number = "(1)", lastname = "Lung " }, new PlayerModel {
 name = "Bogdan ", age = "3", team = "Dinamo Bucureşti", number = "(12)", lastname = "Stelea " }, new PlayerModel {
 name = "Gheorghe ", age = "2", team = "Petrolul Ploieşti", number = "(22)", lastname = "Liliac " }, new PlayerModel {
 name = "Mircea ", age = "74", team = "Dinamo Bucureşti", number = " (2)", lastname = "Rednic " }, new PlayerModel {
 name = "Michael ", age = "78", team = "Dinamo Bucureşti", number = " (3)", lastname = "Klein " }, new PlayerModel {
 name = "Ioan ", age = "49", team = "Dinamo Bucureşti", number = " (4)", lastname = "Andone " }, new PlayerModel {
 name = "Iosif ", age = "11", team = "Steaua Bucureşti", number = " (5)", lastname = "Rotariu " }, new PlayerModel {
 name = "Gheorghe ", age = "18", team = "Universitatea Craiova", number = " (6)", lastname = "Popescu " }, new PlayerModel {
 name = "Adrian ", age = "1", team = "Universitatea Craiova", number = "(13)", lastname = "Popescu " }, new PlayerModel {
 name = "Emil ", age = "8", team = "Universitatea Craiova", number = "(19)", lastname = "Săndoi " }, new PlayerModel {
 name = "Ioan ", age = "21", team = "Dinamo Bucureşti", number = " (8)", lastname = "Sabău " }, new PlayerModel {
 name = "Gheorghe ", age = "59", team = "Steaua Bucureşti", number = "(10)", lastname = "Hagi " }, new PlayerModel {
 name = "Dănuţ ", age = "7", team = "Dinamo Bucureşti", number = "(11)", lastname = "Lupu " }, new PlayerModel {
 name = "Dorin ", age = "45", team = "Dinamo Bucureşti", number = "(15)", lastname = "Mateuţ " }, new PlayerModel {
 name = "Daniel ", age = "4", team = "Dinamo Bucureşti", number = "(16)", lastname = "Timofte " }, new PlayerModel {
 name = "Zsolt ", age = "6", team = "Steaua Bucureşti", number = "(20)", lastname = "Muzsnay " }, new PlayerModel {
 name = "Ioan ", age = "4", team = "Dinamo Bucureşti", number = "(21)", lastname = "Lupescu " }, new PlayerModel {
 name = "Marius ", age = "38", team = "Steaua Bucureşti", number = " (7)", lastname = "Lăcătuş " }, new PlayerModel {
 name = "Rodion ", age = "74", team = "Charleroi", number = " (9)", lastname = "Cămătaru " }, new PlayerModel {
 name = "Florin ", age = "3", team = "Dinamo Bucureşti", number = "(14)", lastname = "Răducioiu " }, new PlayerModel {
 name = "Ilie ", age = "9", team = "Steaua Bucureşti", number = "(17)", lastname = "Dumitrescu " }, new PlayerModel {
 name = "Gavril ", age = "24", team = "Steaua Bucureşti", number = "(18)", lastname = "Balint " } } }, {
 "sco-scotland", new List<PlayerModel> {
 new PlayerModel {
 name = "Jim ", age = "55", team = "Manchester United", number = "(1)", lastname = "Leighton " }, new PlayerModel {
 name = "Andy ", age = "9", team = "Hibernian", number = "(12)", lastname = "Goram " }, new PlayerModel {
 name = "Bryan ", age = "1", team = "Norwich City", number = "(22)", lastname = "Gunn " }, new PlayerModel {
 name = "Alex ", age = "69", team = "Aberdeen", number = " (2)", lastname = "McLeish " }, new PlayerModel {
 name = "Roy ", age = "53", team = "Newcastle United", number = " (3)", lastname = "Aitken " }, new PlayerModel {
 name = "Richard ", age = "49", team = "Rangers", number = " (4)", lastname = "Gough " }, new PlayerModel {
 name = "Maurice ", age = "34", team = "Dundee United", number = " (6)", lastname = "Malpas " }, new PlayerModel {
 name = "Gary ", age = "11", team = "Liverpool", number = "(11)", lastname = "Gillespie " }, new PlayerModel {
 name = "Craig ", age = "5", team = "Heart of Midlothian", number = "(15)", lastname = "Levein " }, new PlayerModel {
 name = "Stewart ", age = "4", team = "Aberdeen", number = "(17)", lastname = "McKimmie " }, new PlayerModel {
 name = "David ", age = "4", team = "Heart of Midlothian", number = "(19)", lastname = "McPherson " }, new PlayerModel {
 name = "Paul ", age = "46", team = "Celtic", number = " (5)", lastname = "McStay " }, new PlayerModel {
 name = "Jim ", age = "24", team = "Aberdeen", number = " (8)", lastname = "Bett " }, new PlayerModel {
 name = "Murdo ", age = "14", team = "Borussia Dortmund", number = "(10)", lastname = "MacLeod " }, new PlayerModel {
 name = "Stuart ", age = "5", team = "Everton", number = "(16)", lastname = "McCall " }, new PlayerModel {
 name = "John ", age = "4", team = "Hibernian", number = "(18)", lastname = "Collins " }, new PlayerModel {
 name = "Gary ", age = "3", team = "Leicester City", number = "(20)", lastname = "McAllister " }, new PlayerModel {
 name = "Robert ", age = "1", team = "Norwich City", number = "(21)", lastname = "Fleck " }, new PlayerModel {
 name = "Mo ", age = "33", team = "Rangers", number = " (7)", lastname = "Johnston " }, new PlayerModel {
 name = "Ally ", age = "23", team = "Rangers", number = " (9)", lastname = "McCoist " }, new PlayerModel {
 name = "Gordon ", age = "6", team = "Chelsea", number = "(13)", lastname = "Durie " }, new PlayerModel {
 name = "Alan ", age = "7", team = "Bayern Munich", number = "(14)", lastname = "McInally " } } }, {
 "se-sweden", new List<PlayerModel> {
 new PlayerModel {
 name = "Sven ", age = "-", team = "Örgryte", number = "(1)", lastname = "Andersson " }, new PlayerModel {
 name = "Lars ", age = "-", team = "Norrköping", number = "(12)", lastname = "Eriksson " }, new PlayerModel {
 name = "Thomas ", age = "-", team = "IFK Göteborg", number = "(22)", lastname = "Ravelli " }, new PlayerModel {
 name = "Jan ", age = "-", team = "AIK", number = " (2)", lastname = "Eriksson " }, new PlayerModel {
 name = "Glenn ", age = "-", team = "Liverpool", number = " (3)", lastname = "Hysén " }, new PlayerModel {
 name = "Peter ", age = "-", team = "Ajax", number = " (4)", lastname = "Larsson " }, new PlayerModel {
 name = "Roger ", age = "-", team = "Young Boys", number = " (5)", lastname = "Ljung " }, new PlayerModel {
 name = "Roland ", age = "-", team = "Sheffield Wednesday", number = " (6)", lastname = "Nilsson " }, new PlayerModel {
 name = "Niklas ", age = "-", team = "Malmö", number = " (7)", lastname = "Nyhlén " }, new PlayerModel {
 name = "Stefan ", age = "-", team = "Malmö", number = " (8)", lastname = "Schwarz " }, new PlayerModel {
 name = "Leif ", age = "-", team = "Malmö", number = " (9)", lastname = "Engqvist " }, new PlayerModel {
 name = "Klas ", age = "-", team = "IFK Göteborg", number = "(10)", lastname = "Ingesson " }, new PlayerModel {
 name = "Ulrik ", age = "-", team = "", number = "(11)", lastname = "Jansson " }, new PlayerModel {
 name = "Anders ", age = "-", team = "Cremonese", number = "(13)", lastname = "Limpar " }, new PlayerModel {
 name = "Joakim ", age = "-", team = "Malmö", number = "(14)", lastname = "Nilsson " }, new PlayerModel {
 name = "Glenn ", age = "-", team = "Atalanta", number = "(15)", lastname = "Strömberg " }, new PlayerModel {
 name = "Jonas ", age = "-", team = "Benfica", number = "(16)", lastname = "Thern " }, new PlayerModel {
 name = "Mats ", age = "-", team = "Grasshopper", number = "(19)", lastname = "Gren " }, new PlayerModel {
 name = "Tomas ", age = "-", team = "Norrköping", number = "(17)", lastname = "Brolin " }, new PlayerModel {
 name = "Johnny ", age = "-", team = "Cannes", number = "(18)", lastname = "Ekström " }, new PlayerModel {
 name = "Mats ", age = "-", team = "Benfica", number = "(20)", lastname = "Magnusson " }, new PlayerModel {
 name = "Stefan ", age = "-", team = "Ajax", number = "(21)", lastname = "Pettersson " } } }, {
 "tch-czechoslovakia", new List<PlayerModel> {
 new PlayerModel {
 name = "Jan ", age = "-", team = "Sparta Prague", number = "(1)", lastname = "Stejskal " }, new PlayerModel {
 name = "Luděk ", age = "-", team = "West Ham United", number = "(21)", lastname = "Mikloško " }, new PlayerModel {
 name = "Peter ", age = "-", team = "Plastika Nitra", number = "(22)", lastname = "Palúch " }, new PlayerModel {
 name = "Július ", age = "-", team = "Sparta Prague", number = " (2)", lastname = "Bielik " }, new PlayerModel {
 name = "Miroslav ", age = "-", team = "TJ Vítkovice", number = " (3)", lastname = "Kadlec " }, new PlayerModel {
 name = "Ján ", age = "-", team = "FC St. Pauli", number = " (5)", lastname = "Kocian " }, new PlayerModel {
 name = "František ", age = "-", team = "Borussia Mönchengladbach", number = " (6)", lastname = "Straka " }, new PlayerModel {
 name = "Vladimír ", age = "-", team = "Inter Bratislava", number = "(14)", lastname = "Weiss " }, new PlayerModel {
 name = "Vladimír ", age = "-", team = "Slovan Bratislava", number = "(15)", lastname = "Kinier " }, new PlayerModel {
 name = "Ivan ", age = "-", team = "Sparta Prague", number = " (4)", lastname = "Hašek " }, new PlayerModel {
 name = "Michal ", age = "-", team = "Sparta Prague", number = " (7)", lastname = "Bílek " }, new PlayerModel {
 name = "Jozef ", age = "-", team = "PSV", number = " (8)", lastname = "Chovanec " }, new PlayerModel {
 name = "Luboš ", age = "-", team = "Fiorentina", number = " (9)", lastname = "Kubík " }, new PlayerModel {
 name = "Ľubomír ", age = "-", team = "Plastika Nitra", number = "(11)", lastname = "Moravčík " }, new PlayerModel {
 name = "Peter ", age = "-", team = "Dunajská Streda", number = "(12)", lastname = "Fieber " }, new PlayerModel {
 name = "Jiří ", age = "-", team = "Dukla Prague", number = "(13)", lastname = "Němec " }, new PlayerModel {
 name = "Viliam ", age = "-", team = "Baník Ostrava", number = "(16)", lastname = "Hýravý " }, new PlayerModel {
 name = "Václav ", age = "-", team = "Sparta Prague", number = "(20)", lastname = "Němeček " }, new PlayerModel {
 name = "Tomáš ", age = "-", team = "Sparta Prague", number = "(10)", lastname = "Skuhravý " }, new PlayerModel {
 name = "Ivo ", age = "-", team = "FC St. Pauli", number = "(17)", lastname = "Knoflíček " }, new PlayerModel {
 name = "Milan ", age = "-", team = "Sporting Gijón", number = "(18)", lastname = "Luhový " }, new PlayerModel {
 name = "Stanislav ", age = "-", team = "Feyenoord", number = "(19)", lastname = "Griga " } } }, {
 "urs-soviet-union", new List<PlayerModel> {
 new PlayerModel {
 name = "Rinat ", age = "90", team = "Sevilla", number = "(1)", lastname = "Dasayev " }, new PlayerModel {
 name = "Viktor ", age = "21", team = "Dynamo Kyiv", number = "(16)", lastname = "Chanov " }, new PlayerModel {
 name = "Aleksandr ", age = "1", team = "Dynamo Moscow", number = "(22)", lastname = "Uvarov " }, new PlayerModel {
 name = "Volodymyr ", age = "77", team = "Dynamo Kyiv", number = " (2)", lastname = "Bezsonov " }, new PlayerModel {
 name = "Vagiz ", age = "55", team = "Toulouse", number = " (3)", lastname = "Khidiyatullin " }, new PlayerModel {
 name = "Oleh ", age = "49", team = "Dynamo Kyiv", number = " (4)", lastname = "Kuznetsov " }, new PlayerModel {
 name = "Anatoliy ", age = "79", team = "Dynamo Kyiv", number = " (5)", lastname = "Demyanenko " }, new PlayerModel {
 name = "Akhrik ", age = "3", team = "Dynamo Kyiv", number = "(13)", lastname = "Tsveiba " }, new PlayerModel {
 name = "Andrei ", age = "34", team = "Dynamo Minsk", number = "(17)", lastname = "Zygmantovich " }, new PlayerModel {
 name = "Sergei ", age = "3", team = "CSKA Moscow", number = "(19)", lastname = "Fokin " }, new PlayerModel {
 name = "Sergei ", age = "15", team = "Borussia Dortmund", number = "(20)", lastname = "Gorlukovich " }, new PlayerModel {
 name = "Vasyl ", age = "46", team = "Dynamo Kyiv", number = " (6)", lastname = "Rats " }, new PlayerModel {
 name = "Sergei ", age = "61", team = "Juventus", number = " (7)", lastname = "Aleinikov " }, new PlayerModel {
 name = "Gennadiy ", age = "54", team = "Dynamo Kyiv", number = " (8)", lastname = "Lytovchenko " }, new PlayerModel {
 name = "Oleksandr ", age = "38", team = "Juventus", number = " (9)", lastname = "Zavarov " }, new PlayerModel {
 name = "Ivan ", age = "16", team = "Dynamo Kyiv", number = "(15)", lastname = "Yaremchuk " }, new PlayerModel {
 name = "Igor ", age = "0", team = "Spartak Moscow", number = "(18)", lastname = "Shalimov " }, new PlayerModel {
 name = "Valeri ", age = "2", team = "CSKA Moscow", number = "(21)", lastname = "Broshin " }, new PlayerModel {
 name = "Oleh ", age = "60", team = "Dynamo Kyiv", number = "(10)", lastname = "Protasov " }, new PlayerModel {
 name = "Igor ", age = "13", team = "Dynamo Moscow", number = "(11)", lastname = "Dobrovolski " }, new PlayerModel {
 name = "Aleksandr ", age = "5", team = "Schalke 04", number = "(12)", lastname = "Borodyuk " }, new PlayerModel {
 name = "Volodymyr ", age = "2", team = "Schalke 04", number = "(14)", lastname = "Lyutyi " } } }, {
 "us-united-states", new List<PlayerModel> {
 new PlayerModel {
 name = "Tony ", age = "-", team = "U.S. Soccer Federation (USA)", number = "(1)", lastname = "Meola " }, new PlayerModel {
 name = "Kasey ", age = "-", team = "Portland Timbers (USA)", number = "(18)", lastname = "Keller " }, new PlayerModel {
 name = "David ", age = "-", team = "Los Angeles Heat (USA)", number = "(22)", lastname = "Vanole " }, new PlayerModel {
 name = "Steve ", age = "-", team = "Tampa Bay Rowdies (USA)", number = " (2)", lastname = "Trittschuh " }, new PlayerModel {
 name = "John ", age = "-", team = "S.F. Bay Blackhawks (USA)", number = " (3)", lastname = "Doyle " }, new PlayerModel {
 name = "Jimmy ", age = "-", team = "Milwaukee Wave (USA)", number = " (4)", lastname = "Banks " }, new PlayerModel {
 name = "Mike ", age = "-", team = "Albany Capitals (USA)", number = " (5)", lastname = "Windischmann " }, new PlayerModel {
 name = "Desmond ", age = "-", team = "Baltimore Blast (USA)", number = "(15)", lastname = "Armstrong " }, new PlayerModel {
 name = "Marcelo ", age = "-", team = "San Diego Sockers (USA)", number = "(17)", lastname = "Balboa " }, new PlayerModel {
 name = "John ", age = "-", team = "Albany Capitals (USA)", number = " (6)", lastname = "Harkes " }, new PlayerModel {
 name = "Tab ", age = "-", team = "Figueres", number = " (7)", lastname = "Ramos " }, new PlayerModel {
 name = "Brian ", age = "-", team = "Albany Capitals (USA)", number = " (8)", lastname = "Bliss " }, new PlayerModel {
 name = "Paul ", age = "-", team = "Real Santa Barbara (USA)", number = "(12)", lastname = "Krumpe " }, new PlayerModel {
 name = "Eric ", age = "-", team = "Fort Lauderdale Strikers (USA)", number = "(13)", lastname = "Eichmann " }, new PlayerModel {
 name = "John ", age = "-", team = "Washington Stars (USA)", number = "(14)", lastname = "Stollmeyer " }, new PlayerModel {
 name = "Chris ", age = "-", team = "UCLA Bruins (USA)", number = "(19)", lastname = "Henderson " }, new PlayerModel {
 name = "Paul ", age = "-", team = "SV Meppen (GER)", number = "(20)", lastname = "Caligiuri " }, new PlayerModel {
 name = "Neil ", age = "-", team = "Wake Forest Demon Deacons (USA)", number = "(21)", lastname = "Covone " }, new PlayerModel {
 name = "Christopher ", age = "-", team = "Győri (HUN)", number = " (9)", lastname = "Sullivan " }, new PlayerModel {
 name = "Peter ", age = "-", team = "Volendam (NED)", number = "(10)", lastname = "Vermes " }, new PlayerModel {
 name = "Eric ", age = "-", team = "S.F. Bay Blackhawks (USA)", number = "(11)", lastname = "Wynalda " }, new PlayerModel {
 name = "Bruce ", age = "-", team = "Washington Stars (USA)", number = "(16)", lastname = "Murray " } } }, {
 "uy-uruguay", new List<PlayerModel> {
 new PlayerModel {
 name = "Fernando ", age = "-", team = "Peñarol", number = "(1)", lastname = "Álvez " }, new PlayerModel {
 name = "Eduardo ", age = "-", team = "Independiente", number = "(12)", lastname = "Pereira " }, new PlayerModel {
 name = "Javier ", age = "-", team = "Danubio", number = "(22)", lastname = "Zeoli " }, new PlayerModel {
 name = "Nelson ", age = "-", team = "Verona", number = " (2)", lastname = "Gutiérrez " }, new PlayerModel {
 name = "Hugo ", age = "-", team = "River Plate", number = " (3)", lastname = "de " }, new PlayerModel {
 name = "José ", age = "-", team = "Figueres", number = " (4)", lastname = "Oscar " }, new PlayerModel {
 name = "Alfonso ", age = "-", team = "Peñarol", number = " (6)", lastname = "Domínguez " }, new PlayerModel {
 name = "Daniel ", age = "-", team = "Nacional", number = "(13)", lastname = "Revelez " }, new PlayerModel {
 name = "José ", age = "-", team = "Nacional", number = "(14)", lastname = "Pintos " }, new PlayerModel {
 name = "José ", age = "-", team = "Genoa", number = " (5)", lastname = "Perdomo " }, new PlayerModel {
 name = "Santiago ", age = "-", team = "Cruz Azul", number = " (8)", lastname = "Ostolaza " }, new PlayerModel {
 name = "Enzo ", age = "-", team = "Marseille", number = " (9)", lastname = "Francescoli " }, new PlayerModel {
 name = "Rubén ", age = "-", team = "Genoa", number = "(10)", lastname = "Paz " }, new PlayerModel {
 name = "Gabriel ", age = "-", team = "Peñarol", number = "(15)", lastname = "Correa " }, new PlayerModel {
 name = "Pablo ", age = "-", team = "Sevilla", number = "(16)", lastname = "Bengoechea " }, new PlayerModel {
 name = "Rubén ", age = "-", team = "Danubio", number = "(20)", lastname = "Pereira " }, new PlayerModel {
 name = "William ", age = "-", team = "Nacional", number = "(21)", lastname = "Castro " }, new PlayerModel {
 name = "Antonio ", age = "-", team = "Logroñés", number = " (7)", lastname = "Alzamendi " }, new PlayerModel {
 name = "Rubén ", age = "-", team = "Lazio", number = "(11)", lastname = "Sosa " }, new PlayerModel {
 name = "Sergio ", age = "-", team = "Defensor Sporting", number = "(17)", lastname = "Martínez " }, new PlayerModel {
 name = "Carlos ", age = "-", team = "Genoa", number = "(18)", lastname = "Aguilera " }, new PlayerModel {
 name = "Daniel ", age = "-", team = "Nacional", number = "(19)", lastname = "Fonseca " } } }, {
 "yug-yugoslavia", new List<PlayerModel> {
 new PlayerModel {
 name = "Tomislav ", age = "26", team = "Sporting CP", number = "(1)", lastname = "Ivković " }, new PlayerModel {
 name = "Fahrudin ", age = "0", team = "FK Partizan (SFR)", number = "(12)", lastname = "Omerović " }, new PlayerModel {
 name = "Dragoje ", age = "3", team = "Budućnost Titograd (SFR)", number = "(22)", lastname = "Leković " }, new PlayerModel {
 name = "Vujadin ", age = "16", team = "FK Partizan (SFR)", number = " (2)", lastname = "Stanojković " }, new PlayerModel {
 name = "Predrag ", age = "18", team = "FK Partizan (SFR)", number = " (3)", lastname = "Spasić " }, new PlayerModel {
 name = "Zoran ", age = "15", team = "Mallorca", number = " (4)", lastname = "Vulić " }, new PlayerModel {
 name = "Faruk ", age = "45", team = "Sochaux", number = " (5)", lastname = "Hadžibegić " }, new PlayerModel {
 name = "Davor ", age = "17", team = "Cesena", number = " (6)", lastname = "Jozić " }, new PlayerModel {
 name = "Robert ", age = "1", team = "Hajduk Split (SFR)", number = "(17)", lastname = "Jarni " }, new PlayerModel {
 name = "Mirsad ", age = "28", team = "Sion", number = "(18)", lastname = "Baljić " }, new PlayerModel {
 name = "Andrej ", age = "3", team = "Dinamo Zagreb (SFR)", number = "(21)", lastname = "Panadić " }, new PlayerModel {
 name = "Dragoljub ", age = "20", team = "Metz", number = " (7)", lastname = "Brnović " }, new PlayerModel {
 name = "Safet ", age = "47", team = "Paris Saint-Germain", number = " (8)", lastname = "Sušić " }, new PlayerModel {
 name = "Dragan ", age = "33", team = "Red Star Belgrade (SFR)", number = "(10)", lastname = "Stojković " }, new PlayerModel {
 name = "Srečko ", age = "26", team = "Sampdoria", number = "(13)", lastname = "Katanec " }, new PlayerModel {
 name = "Robert ", age = "7", team = "Red Star Belgrade (SFR)", number = "(15)", lastname = "Prosinečki " }, new PlayerModel {
 name = "Refik ", age = "4", team = "Red Star Belgrade (SFR)", number = "(16)", lastname = "Šabanadžović " }, new PlayerModel {
 name = "Darko ", age = "14", team = "Red Star Belgrade (SFR)", number = " (9)", lastname = "Pančev " }, new PlayerModel {
 name = "Zlatko ", age = "63", team = "Paris Saint-Germain", number = "(11)", lastname = "Vujović " }, new PlayerModel {
 name = "Alen ", age = "0", team = "Hajduk Split (SFR)", number = "(14)", lastname = "Bokšić " }, new PlayerModel {
 name = "Dejan ", age = "13", team = "Red Star Belgrade (SFR)", number = "(19)", lastname = "Savićević " }, new PlayerModel {
 name = "Davor ", age = "0", team = "Dinamo Zagreb (SFR)", number = "(20)", lastname = "Šuker " } }

 }}
 );
 squads.Add(
 "1998",new Dictionary<string, List<PlayerModel>>
{
{
"us-united-states",new List<PlayerModel>{
new PlayerModel {
 name = "Tony ",age="-",team="Buffalo Blizzard",number=" (1)",lastname="Meola " },new PlayerModel {
 name = "Juergen ",age="-",team="Luton Town",number="(12)",lastname="Sommer " },new PlayerModel {
 name = "Brad ",age="-",team="Newcastle United",number="(18)",lastname="Friedel " },new PlayerModel {
 name = "Mike ",age="-",team="VfL Wolfsburg",number=" (2)",lastname="Lapper " },new PlayerModel {
 name = "Mike ",age="-",team="Viborg",number=" (3)",lastname="Burns " },new PlayerModel {
 name = "Cle ",age="-",team="Cruz Azul",number=" (4)",lastname="Kooiman " },new PlayerModel {
 name = "Thomas ",age="-",team="Bayer Leverkusen",number=" (5)",lastname="Dooley " },new PlayerModel {
 name = "Marcelo ",age="-",team="León",number="(17)",lastname="Balboa " },new PlayerModel {
 name = "Paul ",age="-",team="SC Freiburg",number="(20)",lastname="Caligiuri " },new PlayerModel {
 name = "Fernando ",age="-",team="St. Louis Storm",number="(21)",lastname="Clavijo " },new PlayerModel {
 name = "Alexi ",age="-",team="Padova",number="(22)",lastname="Lalas " },new PlayerModel {
 name = "John ",age="-",team="Derby County",number=" (6)",lastname="Harkes " },new PlayerModel {
 name = "Hugo ",age="-",team="San Diego Sockers",number=" (7)",lastname="Perez " },new PlayerModel {
 name = "Tab ",age="-",team="Real Betis",number=" (9)",lastname="Ramos " },new PlayerModel {
 name = "Cobi ",age="-",team="Coventry City",number="(13)",lastname="Jones " },new PlayerModel {
 name = "Mike ",age="-",team="UNAM Pumas",number="(16)",lastname="Sorber " },new PlayerModel {
 name = "Claudio ",age="-",team="Virginia Cavaliers",number="(19)",lastname="Reyna " },new PlayerModel {
 name = "Earnie ",age="-",team="Willem II",number=" (8)",lastname="Stewart " },new PlayerModel {
 name = "Roy ",age="-",team="Coventry City",number="(10)",lastname="Wegerle " },new PlayerModel {
 name = "Eric ",age="-",team="1. FC Saarbrücken",number="(11)",lastname="Wynalda " },new PlayerModel {
 name = "Frank ",age="-",team="AEK Athens FC",number="(14)",lastname="Klopas " },new PlayerModel {
 name = "Joe-Max ",age="-",team="1. FC Saarbrücken",number="(15)",lastname="Moore " }}}
 ,{
"ar-argentina",new List<PlayerModel>{
new PlayerModel {
 name = "Carlos ",age="-",team="Mallorca",number="(1)",lastname="Roa " },new PlayerModel {
 name = "Germán ",age="-",team="River Plate",number="(12)",lastname="Burgos " },new PlayerModel {
 name = "Pablo ",age="-",team="Vélez Sársfield",number="(17)",lastname="Cavallero " },new PlayerModel {
 name = "Roberto ",age="-",team="Napoli",number=" (2)",lastname="Ayala " },new PlayerModel {
 name = "José ",age="-",team="Lazio",number=" (3)",lastname="Chamot " },new PlayerModel {
 name = "Mauricio ",age="-",team="Udinese",number=" (4)",lastname="Pineda " },new PlayerModel {
 name = "Roberto ",age="-",team="Parma",number=" (6)",lastname="Néstor " },new PlayerModel {
 name = "Pablo ",age="-",team="Tenerife",number="(13)",lastname="Paz " },new PlayerModel {
 name = "Nelson ",age="-",team="Lugano",number="(14)",lastname="Vivas " },new PlayerModel {
 name = "Javier ",age="-",team="Internazionale",number="(22)",lastname="Zanetti " },new PlayerModel {
 name = "Matías ",age="-",team="Lazio",number=" (5)",lastname="Almeyda " },new PlayerModel {
 name = "Diego ",age="-",team="Internazionale",number=" (8)",lastname="Simeone " },new PlayerModel {
 name = "Ariel ",age="-",team="Valencia",number="(10)",lastname="Ortega " },new PlayerModel {
 name = "Juan ",age="-",team="Sampdoria",number="(11)",lastname="Sebastián " },new PlayerModel {
 name = "Leonardo ",age="-",team="River Plate",number="(15)",lastname="Astrada " },new PlayerModel {
 name = "Sergio ",age="-",team="River Plate",number="(16)",lastname="Berti " },new PlayerModel {
 name = "Marcelo ",age="-",team="River Plate",number="(20)",lastname="Gallardo " },new PlayerModel {
 name = "Claudio ",age="-",team="Valencia",number=" (7)",lastname="López " },new PlayerModel {
 name = "Gabriel ",age="-",team="Fiorentina",number=" (9)",lastname="Batistuta " },new PlayerModel {
 name = "Abel ",age="-",team="Roma",number="(18)",lastname="Balbo " },new PlayerModel {
 name = "Hernán ",age="-",team="Parma",number="(19)",lastname="Crespo " },new PlayerModel {
 name = "Marcelo ",age="-",team="Racing",number="(21)",lastname="Delgado " }}},{
"at-austria",new List<PlayerModel>{
new PlayerModel {
 name = "Michael ",age="-",team="Roma",number="(1)",lastname="Konsel " },new PlayerModel {
 name = "Franz ",age="-",team="VfB Stuttgart",number="(16)",lastname="Wohlfahrt " },new PlayerModel {
 name = "Wolfgang ",age="-",team="Austria Wien",number="(21)",lastname="Knaller " },new PlayerModel {
 name = "Peter ",age="-",team="Rapid Wien",number=" (3)",lastname="Schöttel " },new PlayerModel {
 name = "Anton ",age="-",team="Austria Wien",number=" (4)",lastname="Pfeffer " },new PlayerModel {
 name = "Wolfgang ",age="-",team="Borussia Dortmund",number=" (5)",lastname="Feiersinger " },new PlayerModel {
 name = "Walter ",age="-",team="Cannes",number=" (6)",lastname="Kogler " },new PlayerModel {
 name = "Martin ",age="-",team="Leeds United",number="(12)",lastname="Hiden " },new PlayerModel {
 name = "Markus ",age="-",team="Sturm Graz",number=" (2)",lastname="Schopp " },new PlayerModel {
 name = "Heimo ",age="-",team="Werder Bremen",number=" (8)",lastname="Pfeifenberger " },new PlayerModel {
 name = "Andreas ",age="-",team="Werder Bremen",number="(10)",lastname="Herzog " },new PlayerModel {
 name = "Martin ",age="-",team="Austria Salzburg",number="(11)",lastname="Amerhauser " },new PlayerModel {
 name = "Harald ",age="-",team="1860 Munich",number="(13)",lastname="Cerny " },new PlayerModel {
 name = "Arnold ",age="-",team="Rapid Wien",number="(15)",lastname="Wetl " },new PlayerModel {
 name = "Roman ",age="-",team="Sturm Graz",number="(17)",lastname="Mählich " },new PlayerModel {
 name = "Peter ",age="-",team="LASK Linz",number="(18)",lastname="Stöger " },new PlayerModel {
 name = "Andreas ",age="-",team="Rapid Wien",number="(20)",lastname="Heraf " },new PlayerModel {
 name = "Dietmar ",age="-",team="Real Sociedad",number="(22)",lastname="Kühbauer " },new PlayerModel {
 name = "Mario ",age="-",team="Sturm Graz",number=" (7)",lastname="Haas " },new PlayerModel {
 name = "Ivica ",age="-",team="Sturm Graz",number=" (9)",lastname="Vastić " },new PlayerModel {
 name = "Hannes ",age="-",team="Sturm Graz",number="(14)",lastname="Reinmayr " },new PlayerModel {
 name = "Toni ",age="-",team="1. FC Köln",number="(19)",lastname="Polster " }}},{
"be-belgium",new List<PlayerModel>{
new PlayerModel {
 name = "Filip ",age="-",team="Anderlecht",number="(1)",lastname="De " },new PlayerModel {
 name = "Philippe ",age="-",team="Eendracht Aalst",number="(12)",lastname="Vande " },new PlayerModel {
 name = "Dany ",age="-",team="Club Brugge",number="(13)",lastname="Verlinden " },new PlayerModel {
 name = "Bertrand ",age="-",team="Napoli",number=" (2)",lastname="Crasson " },new PlayerModel {
 name = "Lorenzo ",age="-",team="Club Brugge",number=" (3)",lastname="Staelens " },new PlayerModel {
 name = "Gordan ",age="-",team="Mouscron",number=" (4)",lastname="Vidović " },new PlayerModel {
 name = "Vital ",age="-",team="Club Brugge",number=" (5)",lastname="Borkelmans " },new PlayerModel {
 name = "Glen ",age="-",team="Anderlecht",number="(16)",lastname="De " },new PlayerModel {
 name = "Mike ",age="-",team="Germinal Ekeren",number="(17)",lastname="Verstraeten " },new PlayerModel {
 name = "Eric ",age="-",team="Lierse",number="(19)",lastname="Van " },new PlayerModel {
 name = "Eric ",age="-",team="Club Brugge",number="(22)",lastname="Deflandre " },new PlayerModel {
 name = "Franky ",age="-",team="Club Brugge",number=" (6)",lastname="Van " },new PlayerModel {
 name = "Marc ",age="-",team="Schalke 04",number=" (7)",lastname="Wilmots " },new PlayerModel {
 name = "Nico ",age="-",team="Lierse",number="(11)",lastname="Van " },new PlayerModel {
 name = "Enzo ",age="-",team="Anderlecht",number="(14)",lastname="Scifo " },new PlayerModel {
 name = "Philippe ",age="-",team="Racing Genk",number="(15)",lastname="Clement " },new PlayerModel {
 name = "Danny ",age="-",team="Metz",number="(21)",lastname="Boffin " },new PlayerModel {
 name = "Luis ",age="-",team="Fiorentina",number=" (8)",lastname="Oliveira " },new PlayerModel {
 name = "Mbo ",age="-",team="Standard Liège",number=" (9)",lastname="Mpenza " },new PlayerModel {
 name = "Luc ",age="-",team="PSV",number="(10)",lastname="Nilis " },new PlayerModel {
 name = "Gert ",age="-",team="Club Brugge",number="(18)",lastname="Verheyen " },new PlayerModel {
 name = "Émile ",age="-",team="Standard Liège",number="(20)",lastname="Mpenza " }}},{
"bg-bulgaria",new List<PlayerModel>{
new PlayerModel {
 name = "Zdravko ",age="16",team="Istanbulspor",number="(1)",lastname="Zdravkov " },new PlayerModel {
 name = "Borislav ",age="96",team="Slavia Sofia",number="(12)",lastname="Mikhailov " },new PlayerModel {
 name = "Radostin ",age="22",team="Litex Lovech",number=" (2)",lastname="Kishishev " },new PlayerModel {
 name = "Trifon ",age="72",team="CSKA Sofia",number=" (3)",lastname="Ivanov " },new PlayerModel {
 name = "Ivaylo ",age="10",team="Litex Lovech",number=" (4)",lastname="Petkov " },new PlayerModel {
 name = "Gosho ",age="15",team="Antalyaspor",number="(13)",lastname="Ginchev " },new PlayerModel {
 name = "Adalbert ",age="6",team="Arminia Bielefeld",number="(15)",lastname="Zafirov " },new PlayerModel {
 name = "Rosen ",age="3",team="Litex Lovech",number="(21)",lastname="Kirilov " },new PlayerModel {
 name = "Ivaylo ",age="38",team="Sporting CP",number=" (5)",lastname="Yordanov " },new PlayerModel {
 name = "Zlatko ",age="67",team="Beşiktaş",number=" (6)",lastname="Yankov " },new PlayerModel {
 name = "Krassimir ",age="66",team="VfB Stuttgart",number="(10)",lastname="Balakov " },new PlayerModel {
 name = "Ilian ",age="15",team="Bursaspor",number="(11)",lastname="Iliev " },new PlayerModel {
 name = "Marian ",age="9",team="1. FC Kaiserslautern",number="(14)",lastname="Hristov " },new PlayerModel {
 name = "Anatoli ",age="15",team="Lokomotiv Sofia",number="(16)",lastname="Nankov " },new PlayerModel {
 name = "Stoycho ",age="1",team="Litex Lovech",number="(17)",lastname="Stoilov " },new PlayerModel {
 name = "Daniel ",age="36",team="1860 Munich",number="(18)",lastname="Borimirov " },new PlayerModel {
 name = "Milen ",age="5",team="CSKA Sofia",number="(22)",lastname="Petkov " },new PlayerModel {
 name = "Emil ",age="67",team="CSKA Sofia",number=" (7)",lastname="Kostadinov " },new PlayerModel {
 name = "Hristo ",age="70",team="CSKA Sofia",number=" (8)",lastname="Stoichkov " },new PlayerModel {
 name = "Lyuboslav ",age="58",team="Compostela",number=" (9)",lastname="Penev " },new PlayerModel {
 name = "Georgi ",age="4",team="Slavia Sofia",number="(19)",lastname="Bachev " },new PlayerModel {
 name = "Georgi ",age="4",team="Levski Sofia",number="(20)",lastname="Ivanov " }}},{
"br-brazil",new List<PlayerModel>{
new PlayerModel {
 name = "Taffarel ",age="-",team="Atlético Mineiro",number="(1)",lastname="## " },new PlayerModel {
 name = "Carlos ",age="-",team="Vasco da Gama",number="(12)",lastname="Germano " },new PlayerModel {
 name = "Dida ",age="-",team="Cruzeiro",number="(22)",lastname="## " },new PlayerModel {
 name = "Cafu ",age="-",team="Roma",number=" (2)",lastname="## " },new PlayerModel {
 name = "Aldair ",age="-",team="Roma",number=" (3)",lastname="## " },new PlayerModel {
 name = "Júnior ",age="-",team="Flamengo",number=" (4)",lastname="Baiano " },new PlayerModel {
 name = "Roberto ",age="-",team="Real Madrid",number=" (6)",lastname="Carlos " },new PlayerModel {
 name = "Zé ",age="-",team="São Paulo",number="(13)",lastname="Carlos " },new PlayerModel {
 name = "Gonçalves ",age="-",team="Botafogo",number="(14)",lastname="## " },new PlayerModel {
 name = "André ",age="-",team="Milan",number="(15)",lastname="Cruz " },new PlayerModel {
 name = "César ",age="-",team="Yokohama Flügels",number=" (5)",lastname="Sampaio " },new PlayerModel {
 name = "Giovanni ",age="-",team="Barcelona",number=" (7)",lastname="## " },new PlayerModel {
 name = "Dunga ",age="-",team="Júbilo Iwata",number=" (8)",lastname="## " },new PlayerModel {
 name = "Rivaldo ",age="-",team="Barcelona",number="(10)",lastname="## " },new PlayerModel {
 name = "Emerson ",age="-",team="Bayer Leverkusen",number="(11)",lastname="## " },new PlayerModel {
 name = "Zé ",age="-",team="Flamengo",number="(16)",lastname="Roberto " },new PlayerModel {
 name = "Doriva ",age="-",team="Porto",number="(17)",lastname="## " },new PlayerModel {
 name = "Leonardo ",age="-",team="Milan",number="(18)",lastname="## " },new PlayerModel {
 name = "Denílson ",age="-",team="São Paulo",number="(19)",lastname="## " },new PlayerModel {
 name = "Ronaldo ",age="-",team="Internazionale",number=" (9)",lastname="## " },new PlayerModel {
 name = "Bebeto ",age="-",team="Botafogo",number="(20)",lastname="## " },new PlayerModel {
 name = "Edmundo ",age="-",team="Fiorentina",number="(21)",lastname="## " }}},{
"cl-chile",new List<PlayerModel>{
new PlayerModel {
 name = "Nelson ",age="34",team="Universidad Católica",number="(1)",lastname="Tapia " },new PlayerModel {
 name = "Marcelo ",age="19",team="Colo-Colo",number="(12)",lastname="Ramírez " },new PlayerModel {
 name = "Carlos ",age="0",team="Coquimbo Unido",number="(22)",lastname="Tejas " },new PlayerModel {
 name = "Cristián ",age="24",team="Universidad de Chile",number=" (2)",lastname="Castañeda " },new PlayerModel {
 name = "Ronald ",age="41",team="Universidad de Chile",number=" (3)",lastname="Fuentes " },new PlayerModel {
 name = "Francisco ",age="12",team="Colo-Colo",number=" (4)",lastname="Rojas " },new PlayerModel {
 name = "Javier ",age="52",team="Universidad Católica",number=" (5)",lastname="Margas " },new PlayerModel {
 name = "Pedro ",age="24",team="Colo-Colo",number=" (6)",lastname="Reyes " },new PlayerModel {
 name = "Miguel ",age="38",team="Universidad Católica",number="(14)",lastname="Ramírez " },new PlayerModel {
 name = "Moisés ",age="10",team="Santiago Wanderers",number="(15)",lastname="Villarroel " },new PlayerModel {
 name = "Mauricio ",age="4",team="Universidad de Chile",number="(16)",lastname="Aros " },new PlayerModel {
 name = "Nelson ",age="37",team="Universidad Católica",number=" (7)",lastname="Parraguez " },new PlayerModel {
 name = "Clarence ",age="28",team="Universidad de Chile",number=" (8)",lastname="Acuña " },new PlayerModel {
 name = "José ",age="31",team="Colo-Colo",number="(10)",lastname="Luis " },new PlayerModel {
 name = "Marcelo ",age="29",team="MetroStars (USA)",number="(17)",lastname="Vega " },new PlayerModel {
 name = "Luis ",age="27",team="Universidad de Chile",number="(18)",lastname="Musrri " },new PlayerModel {
 name = "Fernando ",age="27",team="Cobreloa",number="(19)",lastname="Cornejo " },new PlayerModel {
 name = "Fabián ",age="48",team="Toluca",number="(20)",lastname="Estay " },new PlayerModel {
 name = "Iván ",age="42",team="Internazionale",number=" (9)",lastname="Zamorano " },new PlayerModel {
 name = "Marcelo ",age="39",team="River Plate",number="(11)",lastname="Salas " },new PlayerModel {
 name = "Manuel ",age="5",team="Colo-Colo",number="(13)",lastname="Neira " },new PlayerModel {
 name = "Rodrigo ",age="22",team="Universidad de Chile",number="(21)",lastname="Barrera " }}},{
"cm-cameroon",new List<PlayerModel>{
new PlayerModel {
 name = "Jacques ",age="-",team="Deportivo La Coruña",number="(1)",lastname="Songo'o " },new PlayerModel {
 name = "Bassey ",age="-",team="Boavista",number="(16)",lastname="William " },new PlayerModel {
 name = "Alioum ",age="-",team="Samsunspor",number="(22)",lastname="Boukar " },new PlayerModel {
 name = "Pierre ",age="-",team="Lucchese",number=" (3)",lastname="Wome " },new PlayerModel {
 name = "Rigobert ",age="-",team="Metz",number=" (4)",lastname="Song " },new PlayerModel {
 name = "Raymond ",age="-",team="Panahaiki",number=" (5)",lastname="Kalla " },new PlayerModel {
 name = "Pierre ",age="-",team="Olympic Mvolyé",number=" (6)",lastname="Njanka " },new PlayerModel {
 name = "Lauren ",age="-",team="Levante",number="(12)",lastname="Etame " },new PlayerModel {
 name = "Patrice ",age="-",team="Tonnerre Yaoundé",number="(13)",lastname="Abanda " },new PlayerModel {
 name = "Michel ",age="-",team="Cheonan Ilhwa Chunma",number="(17)",lastname="Pensée " },new PlayerModel {
 name = "Joseph ",age="-",team="Tonnerre Yaoundé",number=" (2)",lastname="Elanga " },new PlayerModel {
 name = "Didier ",age="-",team="Nice",number=" (8)",lastname="Angibeaud " },new PlayerModel {
 name = "Augustine ",age="-",team="Saint-Étienne",number="(14)",lastname="Simo " },new PlayerModel {
 name = "Joseph ",age="-",team="Cottonsport Garoua",number="(15)",lastname="N'Do " },new PlayerModel {
 name = "Marcel ",age="-",team="Montpellier",number="(19)",lastname="Mahouvé " },new PlayerModel {
 name = "Salomon ",age="-",team="Nantes",number="(20)",lastname="Olembé " },new PlayerModel {
 name = "François ",age="-",team="Sampdoria",number=" (7)",lastname="Omam-Biyik " },new PlayerModel {
 name = "Alphonse ",age="-",team="Hertha BSC",number=" (9)",lastname="Tchami " },new PlayerModel {
 name = "Patrick ",age="-",team="Gamba Osaka",number="(10)",lastname="M'Boma " },new PlayerModel {
 name = "Samuel ",age="-",team="Leganés",number="(11)",lastname="Eto'o " },new PlayerModel {
 name = "Samuel ",age="-",team="Rapid Wien",number="(18)",lastname="Ipoua " },new PlayerModel {
 name = "Joseph-Désiré ",age="-",team="Lyon",number="(21)",lastname="Job " }}},{
"co-colombia",new List<PlayerModel>{
new PlayerModel {
 name = "Óscar ",age="-",team="Boca Juniors",number="(1)",lastname="Córdoba " },new PlayerModel {
 name = "Miguel ",age="-",team="Atlético Nacional",number="(12)",lastname="Calero " },new PlayerModel {
 name = "Farid ",age="-",team="Independiente",number="(22)",lastname="Mondragón " },new PlayerModel {
 name = "Iván ",age="-",team="San Lorenzo",number=" (2)",lastname="Córdoba " },new PlayerModel {
 name = "Ever ",age="-",team="Deportivo Cali",number=" (3)",lastname="Palacios " },new PlayerModel {
 name = "José ",age="-",team="Atlético Nacional",number=" (4)",lastname="Santa " },new PlayerModel {
 name = "Jorge ",age="-",team="Boca Juniors",number=" (5)",lastname="Bermúdez " },new PlayerModel {
 name = "Wilmer ",age="-",team="Millonarios",number="(13)",lastname="Cabrera " },new PlayerModel {
 name = "Luis ",age="-",team="Deportes Tolima",number="(16)",lastname="Antonio " },new PlayerModel {
 name = "Mauricio ",age="-",team="Boca Juniors",number=" (6)",lastname="Serna " },new PlayerModel {
 name = "John ",age="-",team="Real Valladolid",number=" (8)",lastname="Harold " },new PlayerModel {
 name = "Carlos ",age="-",team="Miami Fusion (USA)",number="(10)",lastname="Valderrama " },new PlayerModel {
 name = "Jorge ",age="-",team="Atlético Junior",number="(14)",lastname="Bolaño " },new PlayerModel {
 name = "Andrés ",age="-",team="Deportivo Cali",number="(17)",lastname="Estrada " },new PlayerModel {
 name = "John ",age="-",team="Deportivo Cali",number="(18)",lastname="Wilmar " },new PlayerModel {
 name = "Freddy ",age="-",team="Corinthians",number="(19)",lastname="Rincón " },new PlayerModel {
 name = "Antony ",age="-",team="Barcelona",number=" (7)",lastname="de " },new PlayerModel {
 name = "Adolfo ",age="-",team="Independiente Medellín",number=" (9)",lastname="Valencia " },new PlayerModel {
 name = "Faustino ",age="-",team="Parma",number="(11)",lastname="Asprilla " },new PlayerModel {
 name = "Víctor ",age="-",team="São Paulo",number="(15)",lastname="Aristizábal " },new PlayerModel {
 name = "Hamilton ",age="-",team="Middlesbrough",number="(20)",lastname="Ricard " },new PlayerModel {
 name = "Léider ",age="-",team="Santa Fe",number="(21)",lastname="Preciado " }}},{
"de-deutschland",new List<PlayerModel>{
new PlayerModel {
 name = "Andreas ",age="54",team="Marseille",number="(1)",lastname="Köpke " },new PlayerModel {
 name = "Oliver ",age="10",team="Bayern Munich",number="(12)",lastname="Kahn " },new PlayerModel {
 name = "Jens ",age="2",team="Schalke 04",number="(22)",lastname="Lehmann " },new PlayerModel {
 name = "Christian ",age="17",team="Bayer Leverkusen",number=" (2)",lastname="Wörns " },new PlayerModel {
 name = "Jörg ",age="15",team="Borussia Dortmund",number=" (3)",lastname="Heinrich " },new PlayerModel {
 name = "Jürgen ",age="101",team="Borussia Dortmund",number=" (4)",lastname="Kohler " },new PlayerModel {
 name = "Thomas ",age="66",team="Bayern Munich",number=" (5)",lastname="Helmer " },new PlayerModel {
 name = "Olaf ",age="48",team="Schalke 04",number=" (6)",lastname="Thon " },new PlayerModel {
 name = "Lothar ",age="125",team="Bayern Munich",number=" (8)",lastname="Matthäus " },new PlayerModel {
 name = "Markus ",age="30",team="Bayern Munich",number="(14)",lastname="Babbel " },new PlayerModel {
 name = "Christian ",age="37",team="Milan",number="(17)",lastname="Ziege " },new PlayerModel {
 name = "Stefan ",age="68",team="Borussia Dortmund",number="(19)",lastname="Reuter " },new PlayerModel {
 name = "Michael ",age="12",team="Bayern Munich",number="(21)",lastname="Tarnat " },new PlayerModel {
 name = "Andreas ",age="79",team="Borussia Dortmund",number=" (7)",lastname="Möller " },new PlayerModel {
 name = "Thomas ",age="93",team="Karlsruher SC",number="(10)",lastname="Häßler " },new PlayerModel {
 name = "Jens ",age="5",team="1860 Munich",number="(13)",lastname="Jeremies " },new PlayerModel {
 name = "Steffen ",age="21",team="Borussia Dortmund",number="(15)",lastname="Freund " },new PlayerModel {
 name = "Dietmar ",age="7",team="Bayern Munich",number="(16)",lastname="Hamann " },new PlayerModel {
 name = "Ulf ",age="32",team="Bayer Leverkusen",number=" (9)",lastname="Kirsten " },new PlayerModel {
 name = "Olaf ",age="7",team="1. FC Kaiserslautern",number="(11)",lastname="Marschall " },new PlayerModel {
 name = "Jürgen ",age="103",team="Tottenham Hotspur",number="(18)",lastname="Klinsmann " },new PlayerModel {
 name = "Oliver ",age="26",team="Udinese",number="(20)",lastname="Bierhoff " }}},{
"dk-denmark",new List<PlayerModel>{
new PlayerModel {
 name = "Peter ",age="100",team="Manchester United",number="(1)",lastname="Schmeichel " },new PlayerModel {
 name = "Mogens ",age="8",team="Brøndby",number="(16)",lastname="Krogh " },new PlayerModel {
 name = "Peter ",age="0",team="Silkeborg",number="(22)",lastname="Kjær " },new PlayerModel {
 name = "Michael ",age="28",team="1. FC Kaiserslautern",number=" (2)",lastname="Schjønberg " },new PlayerModel {
 name = "Marc ",age="53",team="Celtic",number=" (3)",lastname="Rieper " },new PlayerModel {
 name = "Jes ",age="37",team="Fenerbahçe",number=" (4)",lastname="Høgh " },new PlayerModel {
 name = "Jan ",age="39",team="Bayer Leverkusen",number=" (5)",lastname="Heintze " },new PlayerModel {
 name = "Thomas ",age="30",team="Udinese",number=" (6)",lastname="Helveg " },new PlayerModel {
 name = "Søren ",age="4",team="Brøndby",number="(12)",lastname="Colding " },new PlayerModel {
 name = "Jacob ",age="22",team="Derby County",number="(13)",lastname="Laursen " },new PlayerModel {
 name = "René ",age="2",team="Akademisk",number="(20)",lastname="Henriksen " },new PlayerModel {
 name = "Allan ",age="18",team="Tottenham Hotspur",number=" (7)",lastname="Nielsen " },new PlayerModel {
 name = "Per ",age="12",team="Bolton Wanderers",number=" (8)",lastname="Frandsen " },new PlayerModel {
 name = "Michael ",age="99",team="Ajax",number="(10)",lastname="Laudrup " },new PlayerModel {
 name = "Morten ",age="11",team="Celtic",number="(14)",lastname="Wieghorst " },new PlayerModel {
 name = "Stig ",age="4",team="MSV Duisburg",number="(15)",lastname="Tøfting " },new PlayerModel {
 name = "Bjarne ",age="11",team="Copenhagen",number="(17)",lastname="Goldbæk " },new PlayerModel {
 name = "Martin ",age="4",team="Udinese",number="(21)",lastname="Jørgensen " },new PlayerModel {
 name = "Miklos ",age="9",team="Sevilla",number=" (9)",lastname="Molnar " },new PlayerModel {
 name = "Brian ",age="77",team="Rangers",number="(11)",lastname="Laudrup " },new PlayerModel {
 name = "Peter ",age="11",team="PSV",number="(18)",lastname="Møller " },new PlayerModel {
 name = "Ebbe ",age="2",team="Brøndby",number="(19)",lastname="Sand " }}},{
"en-england",new List<PlayerModel>{
new PlayerModel {
 name = "David ",age="40",team="Arsenal",number="(1)",lastname="Seaman " },new PlayerModel {
 name = "Nigel ",age="7",team="Leeds United",number="(13)",lastname="Martyn " },new PlayerModel {
 name = "Tim ",age="11",team="Blackburn Rovers",number="(22)",lastname="Flowers " },new PlayerModel {
 name = "Sol ",age="16",team="Tottenham Hotspur",number=" (2)",lastname="Campbell " },new PlayerModel {
 name = "Graeme ",age="25",team="Chelsea",number=" (3)",lastname="Le " },new PlayerModel {
 name = "Tony ",age="51",team="Arsenal",number=" (5)",lastname="Adams " },new PlayerModel {
 name = "Gareth ",age="25",team="Aston Villa",number=" (6)",lastname="Southgate " },new PlayerModel {
 name = "Gary ",age="27",team="Manchester United",number="(12)",lastname="Neville " },new PlayerModel {
 name = "Martin ",age="18",team="Arsenal",number="(18)",lastname="Keown " },new PlayerModel {
 name = "Rio ",age="3",team="West Ham United",number="(21)",lastname="Ferdinand " },new PlayerModel {
 name = "Paul ",age="39",team="Liverpool",number=" (4)",lastname="Ince " },new PlayerModel {
 name = "David ",age="15",team="Manchester United",number=" (7)",lastname="Beckham " },new PlayerModel {
 name = "David ",age="31",team="Newcastle United",number=" (8)",lastname="Batty " },new PlayerModel {
 name = "Steve ",age="21",team="Liverpool",number="(11)",lastname="McManaman " },new PlayerModel {
 name = "Darren ",age="18",team="Tottenham Hotspur",number="(14)",lastname="Anderton " },new PlayerModel {
 name = "Paul ",age="18",team="Middlesbrough",number="(15)",lastname="Merson " },new PlayerModel {
 name = "Paul ",age="7",team="Manchester United",number="(16)",lastname="Scholes " },new PlayerModel {
 name = "Rob ",age="17",team="Newcastle United",number="(17)",lastname="Lee " },new PlayerModel {
 name = "Alan ",age="39",team="Newcastle United",number=" (9)",lastname="Shearer " },new PlayerModel {
 name = "Teddy ",age="33",team="Manchester United",number="(10)",lastname="Sheringham " },new PlayerModel {
 name = "Les ",age="17",team="Tottenham Hotspur",number="(19)",lastname="Ferdinand " },new PlayerModel {
 name = "Michael ",age="5",team="Liverpool",number="(20)",lastname="Owen " }}},{
"es-espana",new List<PlayerModel>{
new PlayerModel {
 name = "Andoni ",age="123",team="Valencia",number="(1)",lastname="Zubizarreta " },new PlayerModel {
 name = "Santiago ",age="10",team="Real Madrid",number="(13)",lastname="Cañizares " },new PlayerModel {
 name = "José ",age="1",team="Atlético Madrid",number="(22)",lastname="Molina " },new PlayerModel {
 name = "Albert ",age="34",team="Barcelona",number=" (2)",lastname="Ferrer " },new PlayerModel {
 name = "Agustín ",age="6",team="Real Sociedad",number=" (3)",lastname="Aranzábal " },new PlayerModel {
 name = "Rafael ",age="48",team="Athletic Bilbao",number=" (4)",lastname="Alkorta " },new PlayerModel {
 name = "Abelardo ",age="40",team="Barcelona",number=" (5)",lastname="## " },new PlayerModel {
 name = "Fernando ",age="55",team="Real Madrid",number=" (6)",lastname="Hierro " },new PlayerModel {
 name = "Sergi ",age="33",team="Barcelona",number="(12)",lastname="## " },new PlayerModel {
 name = "Iván ",age="2",team="Mallorca",number="(14)",lastname="Campo " },new PlayerModel {
 name = "Carlos ",age="4",team="Atlético Madrid",number="(15)",lastname="Aguilera " },new PlayerModel {
 name = "Miguel ",age="43",team="Barcelona",number="(20)",lastname="Ángel " },new PlayerModel {
 name = "Julen ",age="31",team="Athletic Bilbao",number=" (8)",lastname="Guerrero " },new PlayerModel {
 name = "Albert ",age="1",team="Barcelona",number="(16)",lastname="Celades " },new PlayerModel {
 name = "Joseba ",age="4",team="Athletic Bilbao",number="(17)",lastname="Etxeberria " },new PlayerModel {
 name = "Guillermo ",age="33",team="Barcelona",number="(18)",lastname="Amor " },new PlayerModel {
 name = "Luis ",age="35",team="Barcelona",number="(21)",lastname="Enrique " },new PlayerModel {
 name = "Fernando ",age="2",team="Real Madrid",number=" (7)",lastname="Morientes " },new PlayerModel {
 name = "Juan ",age="21",team="Barcelona",number=" (9)",lastname="Antonio " },new PlayerModel {
 name = "Raúl ",age="13",team="Real Madrid",number="(10)",lastname="## " },new PlayerModel {
 name = "Alfonso ",age="26",team="Real Betis",number="(11)",lastname="## " },new PlayerModel {
 name = "Kiko ",age="21",team="Atlético Madrid",number="(19)",lastname="## " }}},{
"fr-france",new List<PlayerModel>{
new PlayerModel {
 name = "Bernard ",age="37",team="Paris Saint Germain",number="(1)",lastname="Lama " },new PlayerModel {
 name = "Fabien ",age="12",team="AS Monaco",number="(16)",lastname="Barthez " },new PlayerModel {
 name = "Lionel ",age="1",team="Auxerre",number="(22)",lastname="Charbonnier " },new PlayerModel {
 name = "Vincent ",age="10",team="Roma",number=" (2)",lastname="Candela " },new PlayerModel {
 name = "Bixente ",age="32",team="Bayern Munich",number=" (3)",lastname="Lizarazu " },new PlayerModel {
 name = "Laurent ",age="68",team="Marseille",number=" (5)",lastname="Blanc " },new PlayerModel {
 name = "Marcel ",age="41",team="Milan",number=" (8)",lastname="Desailly " },new PlayerModel {
 name = "Lilian ",age="32",team="Parma",number="(15)",lastname="Thuram " },new PlayerModel {
 name = "Frank ",age="13",team="Chelsea",number="(18)",lastname="Lebœuf " },new PlayerModel {
 name = "Patrick ",age="7",team="Arsenal",number=" (4)",lastname="Vieira " },new PlayerModel {
 name = "Didier ",age="69",team="Juventus",number=" (7)",lastname="Deschamps " },new PlayerModel {
 name = "Zinedine ",age="33",team="Juventus",number="(10)",lastname="Zidane " },new PlayerModel {
 name = "Robert ",age="13",team="Metz",number="(11)",lastname="Pirès " },new PlayerModel {
 name = "Bernard ",age="6",team="Auxerre",number="(13)",lastname="Diomède " },new PlayerModel {
 name = "Alain ",age="6",team="Sampdoria",number="(14)",lastname="Boghossian " },new PlayerModel {
 name = "Emmanuel ",age="17",team="Arsenal",number="(17)",lastname="Petit " },new PlayerModel {
 name = "Christian ",age="31",team="Real Madrid",number="(19)",lastname="Karembeu " },new PlayerModel {
 name = "Youri ",age="37",team="Internazionale",number=" (6)",lastname="Djorkaeff " },new PlayerModel {
 name = "Stéphane ",age="6",team="Auxerre",number=" (9)",lastname="Guivarc'h " },new PlayerModel {
 name = "Thierry ",age="3",team="AS Monaco",number="(12)",lastname="Henry " },new PlayerModel {
 name = "David ",age="4",team="AS Monaco",number="(20)",lastname="Trezeguet " },new PlayerModel {
 name = "Christophe ",age="23",team="Marseille",number="(21)",lastname="Dugarry " }}},{
"hr-croatia",new List<PlayerModel>{
new PlayerModel {
 name = "Dražen ",age="41",team="Croatia Zagreb",number="(1)",lastname="Ladić " },new PlayerModel {
 name = "Marijan ",age="12",team="Beşiktaş",number="(12)",lastname="Mrmić " },new PlayerModel {
 name = "Vladimir ",age="1",team="Hrvatski Dragovoljac",number="(22)",lastname="Vasilj " },new PlayerModel {
 name = "Anthony ",age="3",team="Hajduk Split",number=" (3)",lastname="Šerić " },new PlayerModel {
 name = "Igor ",age="29",team="Derby County",number=" (4)",lastname="Štimac " },new PlayerModel {
 name = "Goran ",age="11",team="Croatia Zagreb",number=" (5)",lastname="Jurić " },new PlayerModel {
 name = "Slaven ",age="36",team="Everton",number=" (6)",lastname="Bilić " },new PlayerModel {
 name = "Igor ",age="5",team="Hajduk Split",number="(15)",lastname="Tudor " },new PlayerModel {
 name = "Robert ",age="38",team="Real Betis",number="(17)",lastname="Jarni " },new PlayerModel {
 name = "Dario ",age="17",team="Croatia Zagreb",number="(20)",lastname="Šimić " },new PlayerModel {
 name = "Aljoša ",age="39",team="Napoli",number=" (7)",lastname="Asanović " },new PlayerModel {
 name = "Robert ",age="29",team="Croatia Zagreb",number=" (8)",lastname="Prosinečki " },new PlayerModel {
 name = "Zvonimir ",age="35",team="Milan",number="(10)",lastname="Boban " },new PlayerModel {
 name = "Silvio ",age="7",team="Croatia Zagreb",number="(11)",lastname="Marić " },new PlayerModel {
 name = "Mario ",age="16",team="Parma",number="(13)",lastname="Stanić " },new PlayerModel {
 name = "Zvonimir ",age="26",team="VfB Stuttgart",number="(14)",lastname="Soldo " },new PlayerModel {
 name = "Zoran ",age="6",team="VfL Bochum",number="(18)",lastname="Mamić " },new PlayerModel {
 name = "Krunoslav ",age="9",team="Croatia Zagreb",number="(21)",lastname="Jurčić " },new PlayerModel {
 name = "Petar ",age="1",team="Osijek",number=" (2)",lastname="Krpan " },new PlayerModel {
 name = "Davor ",age="36",team="Real Madrid",number=" (9)",lastname="Šuker " },new PlayerModel {
 name = "Ardian ",age="7",team="Bastia",number="(16)",lastname="Kozniku " },new PlayerModel {
 name = "Goran ",age="28",team="Valencia",number="(19)",lastname="Vlaović " }}},{
"ir-iran",new List<PlayerModel>{
new PlayerModel {
 name = "Ahmad ",age="66",team="Persepolis",number="(1)",lastname="Reza " },new PlayerModel {
 name = "Nima ",age="6",team="Persepolis",number="(12)",lastname="Nakisa " },new PlayerModel {
 name = "Parviz ",age="0",team="Esteghlal",number="(22)",lastname="Broumand " },new PlayerModel {
 name = "Naeim ",age="8",team="Persepolis",number=" (3)",lastname="Saadavi " },new PlayerModel {
 name = "Mohammad ",age="37",team="Bahman",number=" (4)",lastname="Khakpour " },new PlayerModel {
 name = "Afshin ",age="37",team="Persepolis",number=" (5)",lastname="Peyrovani " },new PlayerModel {
 name = "Nader ",age="16",team="Polyacryl",number="(14)",lastname="Mohammadkhani " },new PlayerModel {
 name = "Ali ",age="29",team="Zob Ahan",number="(15)",lastname="Akbar " },new PlayerModel {
 name = "Reza ",age="34",team="Persepolis",number="(16)",lastname="Shahroudi " },new PlayerModel {
 name = "Javad ",age="55",team="Esteghlal",number="(17)",lastname="Zarincheh " },new PlayerModel {
 name = "Mehdi ",age="4",team="Esteghlal",number="(20)",lastname="Pashazadeh " },new PlayerModel {
 name = "Mehdi ",age="24",team="Persepolis",number=" (2)",lastname="Mahdavikia " },new PlayerModel {
 name = "Karim ",age="44",team="Arminia Bielefeld",number=" (6)",lastname="Bagheri " },new PlayerModel {
 name = "Alireza ",age="33",team="Esteghlal",number=" (7)",lastname="Mansourian " },new PlayerModel {
 name = "Sirous ",age="16",team="Shahrdari Tabriz",number=" (8)",lastname="Dinmohammadi " },new PlayerModel {
 name = "Hamid ",age="44",team="Bahman",number=" (9)",lastname="Estili " },new PlayerModel {
 name = "Sattar ",age="3",team="Bahman",number="(18)",lastname="Hamedani " },new PlayerModel {
 name = "Mehrdad ",age="23",team="Persepolis",number="(21)",lastname="Minavand " },new PlayerModel {
 name = "Ali ",age="50",team="Arminia Bielefeld",number="(10)",lastname="Daei " },new PlayerModel {
 name = "Khodadad ",age="27",team="1. FC Köln",number="(11)",lastname="Azizi " },new PlayerModel {
 name = "Ali ",age="0",team="Bahman",number="(13)",lastname="Latifi " },new PlayerModel {
 name = "Behnam ",age="0",team="Sanat Naft",number="(19)",lastname="Seraj " }}},{
"it-italy",new List<PlayerModel>{
new PlayerModel {
 name = "Francesco ",age="6",team="Fiorentina",number="(1)",lastname="Toldo " },new PlayerModel {
 name = "Gianluca ",age="34",team="Internazionale",number="(12)",lastname="Pagliuca " },new PlayerModel {
 name = "Gianluigi ",age="2",team="Parma",number="(22)",lastname="Buffon " },new PlayerModel {
 name = "Giuseppe ",age="78",team="Internazionale",number=" (2)",lastname="Bergomi " },new PlayerModel {
 name = "Paolo ",age="88",team="Milan",number=" (3)",lastname="Maldini " },new PlayerModel {
 name = "Fabio ",age="14",team="Parma",number=" (4)",lastname="Cannavaro " },new PlayerModel {
 name = "Alessandro ",age="54",team="Milan",number=" (5)",lastname="Costacurta " },new PlayerModel {
 name = "Alessandro ",age="12",team="Lazio",number=" (6)",lastname="Nesta " },new PlayerModel {
 name = "Gianluca ",age="4",team="Juventus",number=" (7)",lastname="Pessotto " },new PlayerModel {
 name = "Moreno ",age="6",team="Juventus",number=" (8)",lastname="Torricelli " },new PlayerModel {
 name = "Demetrio ",age="57",team="Milan",number=" (9)",lastname="Albertini " },new PlayerModel {
 name = "Dino ",age="46",team="Parma",number="(11)",lastname="Baggio " },new PlayerModel {
 name = "Sandro ",age="1",team="Fiorentina",number="(13)",lastname="Cois " },new PlayerModel {
 name = "Luigi ",age="13",team="Roma",number="(14)",lastname="Di " },new PlayerModel {
 name = "Angelo ",age="21",team="Juventus",number="(15)",lastname="Di " },new PlayerModel {
 name = "Roberto ",age="32",team="Chelsea",number="(16)",lastname="Di " },new PlayerModel {
 name = "Francesco ",age="3",team="Internazionale",number="(17)",lastname="Moriero " },new PlayerModel {
 name = "Alessandro ",age="19",team="Juventus",number="(10)",lastname="Del " },new PlayerModel {
 name = "Roberto ",age="48",team="Bologna",number="(18)",lastname="Baggio " },new PlayerModel {
 name = "Filippo ",age="4",team="Juventus",number="(19)",lastname="Inzaghi " },new PlayerModel {
 name = "Enrico ",age="6",team="Parma",number="(20)",lastname="Chiesa " },new PlayerModel {
 name = "Christian ",age="8",team="Atlético Madrid",number="(21)",lastname="Vieri " }}},{
"jm-jamaica",new List<PlayerModel>{
new PlayerModel {
 name = "Warren ",age="128",team="Violet Kickers",number="(1)",lastname="Barrett " },new PlayerModel {
 name = "Aaron ",age="17",team="Reno",number="(13)",lastname="Lawrence " },new PlayerModel {
 name = "Donovan ",age="0",team="Wadadah",number="(14)",lastname="Ricketts " },new PlayerModel {
 name = "Stephen ",age="62",team="Seba United",number=" (2)",lastname="Malcolm " },new PlayerModel {
 name = "Chris ",age="-",team="Galaxy",number=" (3)",lastname="Dawes " },new PlayerModel {
 name = "Linval ",age="104",team="Hazard",number=" (4)",lastname="Dixon " },new PlayerModel {
 name = "Ian ",age="55",team="Olympic Gardens",number=" (5)",lastname="Goodison " },new PlayerModel {
 name = "Dean ",age="4",team="Constant Spring",number="(12)",lastname="Sewell " },new PlayerModel {
 name = "Ricardo ",age="34",team="Harbour View",number="(15)",lastname="Gardner " },new PlayerModel {
 name = "Frank ",age="5",team="Chelsea",number="(19)",lastname="Sinclair " },new PlayerModel {
 name = "Durrant ",age="125",team="Wadadah",number="(21)",lastname="Brown " },new PlayerModel {
 name = "Fitzroy ",age="23",team="Portsmouth",number=" (6)",lastname="Simpson " },new PlayerModel {
 name = "Peter ",age="76",team="Harbour View",number=" (7)",lastname="Cargill " },new PlayerModel {
 name = "Theodore ",age="76",team="Seba United",number="(11)",lastname="Whitmore " },new PlayerModel {
 name = "Robbie ",age="8",team="Wimbledon",number="(16)",lastname="Earle " },new PlayerModel {
 name = "Darryl ",age="2",team="Derby County",number="(20)",lastname="Powell " },new PlayerModel {
 name = "Marcus ",age="5",team="Wimbledon",number=" (8)",lastname="Gayle " },new PlayerModel {
 name = "Andy ",age="25",team="Columbus Crew (USA)",number=" (9)",lastname="Williams " },new PlayerModel {
 name = "Walter ",age="57",team="Arnett Gardens",number="(10)",lastname="Boyd " },new PlayerModel {
 name = "Onandi ",age="30",team="Harbour View",number="(17)",lastname="Lowe " },new PlayerModel {
 name = "Deon ",age="18",team="Derby County",number="(18)",lastname="Burton " },new PlayerModel {
 name = "Paul ",age="23",team="Portsmouth",number="(22)",lastname="Hall " }}},{
"jp-japan",new List<PlayerModel>{
new PlayerModel {
 name = "Nobuyuki ",age="5",team="Bellmare Hiratsuka",number="(1)",lastname="Kojima " },new PlayerModel {
 name = "Yoshikatsu ",age="27",team="Yokohama Marinos",number="(20)",lastname="Kawaguchi " },new PlayerModel {
 name = "Seigo ",age="2",team="Yokohama Marinos",number="(21)",lastname="Narazaki " },new PlayerModel {
 name = "Akira ",age="29",team="Kashima Antlers",number=" (2)",lastname="Narahashi " },new PlayerModel {
 name = "Naoki ",age="50",team="Kashima Antlers",number=" (3)",lastname="Soma " },new PlayerModel {
 name = "Masami ",age="116",team="Yokohama Marinos",number=" (4)",lastname="Ihara " },new PlayerModel {
 name = "Norio ",age="31",team="Yokohama Marinos",number=" (5)",lastname="Omura " },new PlayerModel {
 name = "Toshihide ",age="14",team="Shimizu S-Pulse",number="(16)",lastname="Saito " },new PlayerModel {
 name = "Yutaka ",age="27",team="Kashima Antlers",number="(17)",lastname="Akita " },new PlayerModel {
 name = "Eisuke ",age="7",team="JEF United Ichihara",number="(19)",lastname="Nakanishi " },new PlayerModel {
 name = "Motohiro ",age="56",team="Yokohama Marinos",number=" (6)",lastname="Yamaguchi " },new PlayerModel {
 name = "Teruyoshi ",age="2",team="Shimizu S-Pulse",number=" (7)",lastname="Ito " },new PlayerModel {
 name = "Hidetoshi ",age="21",team="Bellmare Hiratsuka",number=" (8)",lastname="Nakata " },new PlayerModel {
 name = "Hiroshi ",age="44",team="Jubilo Iwata",number="(10)",lastname="Nanami " },new PlayerModel {
 name = "Shinji ",age="2",team="Urawa Red Diamonds",number="(11)",lastname="Ono " },new PlayerModel {
 name = "Toshihiro ",age="6",team="Jubilo Iwata",number="(13)",lastname="Hattori " },new PlayerModel {
 name = "Hiroaki ",age="36",team="Cerezo Osaka",number="(15)",lastname="Morishima " },new PlayerModel {
 name = "Takashi ",age="10",team="Nagoya Grampus Eight",number="(22)",lastname="Hirano " },new PlayerModel {
 name = "Masashi ",age="27",team="Jubilo Iwata",number=" (9)",lastname="Nakayama " },new PlayerModel {
 name = "Wagner ",age="10",team="Bellmare Hiratsuka",number="(12)",lastname="Lopes " },new PlayerModel {
 name = "Masayuki ",age="25",team="Urawa Red Diamonds",number="(14)",lastname="Okano " },new PlayerModel {
 name = "Shoji ",age="24",team="Yokohama Marinos",number="(18)",lastname="Jo " }}},{
"kr-south-korea",new List<PlayerModel>{
new PlayerModel {
 name = "Kim ",age="34",team="Ulsan Hyundai Horangi",number="(1)",lastname="Byung-Ji " },new PlayerModel {
 name = "Seo ",age="21",team="Sangmu",number="(22)",lastname="Dong-Myung " },new PlayerModel {
 name = "Lee ",age="17",team="Bucheon SK",number=" (3)",lastname="Lim-Saeng " },new PlayerModel {
 name = "Choi ",age="54",team="Busan Daewoo Royals",number=" (4)",lastname="Young-Il " },new PlayerModel {
 name = "Lee ",age="29",team="Busan Daewoo Royals",number=" (5)",lastname="Min-Sung " },new PlayerModel {
 name = "Yoo ",age="57",team="Ulsan Hyundai Horangi",number=" (6)",lastname="Sang-Chul " },new PlayerModel {
 name = "Lee ",age="13",team="Anyang LG Cheetahs",number="(12)",lastname="Sang-Hun " },new PlayerModel {
 name = "Kim ",age="35",team="Jeonnam Dragons",number="(13)",lastname="Tae-Young " },new PlayerModel {
 name = "Jang ",age="7",team="Ulsan Hyundai Horangi",number="(16)",lastname="Hyung-Seok " },new PlayerModel {
 name = "Jang ",age="14",team="Cheonan Ilhwa Chunma",number="(19)",lastname="Dae-Il " },new PlayerModel {
 name = "Hong ",age="94",team="Bellmare Hiratsuka",number="(20)",lastname="Myung-Bo " },new PlayerModel {
 name = "Choi ",age="27",team="Sangmu",number=" (2)",lastname="Sung-Yong " },new PlayerModel {
 name = "Kim ",age="13",team="Jeonnam Dragons",number=" (7)",lastname="Do-Keun " },new PlayerModel {
 name = "Noh ",age="36",team="NAC Breda",number=" (8)",lastname="Jung-Yoon " },new PlayerModel {
 name = "Ko ",age="22",team="Suwon Samsung Bluewings",number="(14)",lastname="Jong-Soo " },new PlayerModel {
 name = "Lee ",age="28",team="Cheonan Ilhwa Chunma",number="(15)",lastname="Sang-Yoon " },new PlayerModel {
 name = "Ha ",age="80",team="Cerezo Osaka",number="(17)",lastname="Seok-Ju " },new PlayerModel {
 name = "Kim ",age="37",team="Vissel Kobe",number=" (9)",lastname="Do-Hoon " },new PlayerModel {
 name = "Choi ",age="33",team="Sangmu",number="(10)",lastname="Yong-Soo " },new PlayerModel {
 name = "Seo ",age="73",team="Strasbourg",number="(11)",lastname="Jung-Won " },new PlayerModel {
 name = "Hwang ",age="80",team="Pohang Steelers",number="(18)",lastname="Sun-Hong " },new PlayerModel {
 name = "Lee ",age="0",team="Pohang Steelers",number="(21)",lastname="Dong-Gook " }}},{
"ma-morocco",new List<PlayerModel>{
new PlayerModel {
 name = "Abelkader ",age="37",team="FAR Rabat",number="(1)",lastname="El " },new PlayerModel {
 name = "Driss ",age="6",team="RS Settat",number="(12)",lastname="Benzekri " },new PlayerModel {
 name = "Mustapha ",age="0",team="Raja Casablanca",number="(22)",lastname="Chadili " },new PlayerModel {
 name = "Abdelilah ",age="25",team="Sporting CP",number=" (2)",lastname="Saber " },new PlayerModel {
 name = "Abdelkrim ",age="59",team="Benfica",number=" (3)",lastname="El " },new PlayerModel {
 name = "Youssef ",age="20",team="Rennes",number=" (4)",lastname="Rossi " },new PlayerModel {
 name = "Smahi ",age="16",team="Lausanne",number=" (5)",lastname="Triki " },new PlayerModel {
 name = "Noureddine ",age="91",team="Deportivo La Coruña",number=" (6)",lastname="Naybet " },new PlayerModel {
 name = "Rachid ",age="13",team="Bari",number="(13)",lastname="Neqrouz " },new PlayerModel {
 name = "Lahcen ",age="41",team="Wydad Casablanca",number="(15)",lastname="Abrami " },new PlayerModel {
 name = "Jamal ",age="0",team="Raja Casablanca",number="(19)",lastname="Sellami " },new PlayerModel {
 name = "Tahar ",age="54",team="Benfica",number="(20)",lastname="El " },new PlayerModel {
 name = "Mustapha ",age="42",team="Deportivo La Coruña",number=" (7)",lastname="Hadji " },new PlayerModel {
 name = "Saïd ",age="23",team="Compostela",number=" (8)",lastname="Chiba " },new PlayerModel {
 name = "Ali ",age="6",team="Heerenveen",number="(11)",lastname="El " },new PlayerModel {
 name = "Rachid ",age="35",team="Greuther Fürth",number="(16)",lastname="Azzouzi " },new PlayerModel {
 name = "Gharib ",age="2",team="Mulhouse",number="(17)",lastname="Amzine " },new PlayerModel {
 name = "Youssef ",age="20",team="Porto",number="(18)",lastname="Chippo " },new PlayerModel {
 name = "Abdeljalil ",age="11",team="Club Africain",number=" (9)",lastname="Hadda " },new PlayerModel {
 name = "Abderrahim ",age="8",team="1860 Munich",number="(10)",lastname="Ouakili " },new PlayerModel {
 name = "Salaheddine ",age="26",team="Deportivo La Coruña",number="(14)",lastname="Bassir " },new PlayerModel {
 name = "Rachid ",age="2",team="SCCM Mohammédia",number="(21)",lastname="Rokki " }}},{
"mx-mexico",new List<PlayerModel>{
new PlayerModel {
 name = "Jorge ",age="106",team="Chicago Fire (USA)",number="(1)",lastname="Campos " },new PlayerModel {
 name = "Oswaldo ",age="9",team="América",number="(12)",lastname="Sánchez " },new PlayerModel {
 name = "Óscar ",age="8",team="Cruz Azul",number="(22)",lastname="Pérez " },new PlayerModel {
 name = "Claudio ",age="121",team="Guadalajara",number=" (2)",lastname="Suárez " },new PlayerModel {
 name = "Joel ",age="20",team="Guadalajara",number=" (3)",lastname="Sánchez " },new PlayerModel {
 name = "Duilio ",age="48",team="América",number=" (5)",lastname="Davino " },new PlayerModel {
 name = "Isaac ",age="7",team="América",number="(16)",lastname="Terrazas " },new PlayerModel {
 name = "Salvador ",age="16",team="Toluca",number="(18)",lastname="Carmona " },new PlayerModel {
 name = "Germán ",age="36",team="América",number=" (4)",lastname="Villa " },new PlayerModel {
 name = "Marcelino ",age="72",team="Monterrey",number=" (6)",lastname="Bernal " },new PlayerModel {
 name = "Ramón ",age="92",team="Guadalajara",number=" (7)",lastname="Ramírez " },new PlayerModel {
 name = "Alberto ",age="82",team="América",number=" (8)",lastname="García " },new PlayerModel {
 name = "Pável ",age="43",team="Atlas",number="(13)",lastname="Pardo " },new PlayerModel {
 name = "Raúl ",age="24",team="América",number="(14)",lastname="Lara " },new PlayerModel {
 name = "Braulio ",age="15",team="UNAM Pumas",number="(19)",lastname="Luna " },new PlayerModel {
 name = "Jaime ",age="21",team="Toluca",number="(20)",lastname="Ordiales " },new PlayerModel {
 name = "Jesús ",age="7",team="Guadalajara",number="(21)",lastname="Arellano " },new PlayerModel {
 name = "Ricardo ",age="41",team="América",number=" (9)",lastname="Peláez " },new PlayerModel {
 name = "Luis ",age="89",team="Atlante",number="(10)",lastname="García " },new PlayerModel {
 name = "Cuauhtémoc ",age="42",team="Necaxa",number="(11)",lastname="Blanco " },new PlayerModel {
 name = "Luis ",age="46",team="Necaxa",number="(15)",lastname="Hernández " },new PlayerModel {
 name = "Francisco ",age="27",team="Cruz Azul",number="(17)",lastname="Palencia " }}},{
"ng-nigeria",new List<PlayerModel>{
new PlayerModel {
 name = "Peter ",age="45",team="Deportivo La Coruña",number="(1)",lastname="Rufai " },new PlayerModel {
 name = "William ",age="5",team="Orlando Pirates",number="(12)",lastname="Okpara " },new PlayerModel {
 name = "Abiodun ",age="3",team="Sion",number="(22)",lastname="Baruwa " },new PlayerModel {
 name = "Mobi ",age="3",team="Kapellen",number=" (2)",lastname="Oparaku " },new PlayerModel {
 name = "Celestine ",age="6",team="Chelsea",number=" (3)",lastname="Babayaro " },new PlayerModel {
 name = "Uche ",age="41",team="Fenerbahçe",number=" (5)",lastname="Okechukwu " },new PlayerModel {
 name = "Taribo ",age="8",team="Internazionale",number=" (6)",lastname="West " },new PlayerModel {
 name = "Uche ",age="33",team="Kansas City Wizards (USA)",number="(16)",lastname="Okafor " },new PlayerModel {
 name = "Augustine ",age="52",team="Torpedo Moscow",number="(17)",lastname="Eguavoen " },new PlayerModel {
 name = "Benedict ",age="33",team="Elche",number="(19)",lastname="Iroha " },new PlayerModel {
 name = "Godwin ",age="6",team="Strasbourg",number="(21)",lastname="Okpara " },new PlayerModel {
 name = "Finidi ",age="36",team="Real Betis",number=" (7)",lastname="George " },new PlayerModel {
 name = "Mutiu ",age="35",team="Real Sociedad",number=" (8)",lastname="Adepoju " },new PlayerModel {
 name = "Jay-Jay ",age="26",team="Fenerbahçe",number="(10)",lastname="Okocha " },new PlayerModel {
 name = "Garba ",age="3",team="Roda JC",number="(11)",lastname="Lawal " },new PlayerModel {
 name = "Tijjani ",age="4",team="Ajax",number="(13)",lastname="Babangida " },new PlayerModel {
 name = "Sunday ",age="22",team="Ajax",number="(15)",lastname="Oliseh " },new PlayerModel {
 name = "Wilson ",age="4",team="Lens",number="(18)",lastname="Oruma " },new PlayerModel {
 name = "Nwankwo ",age="7",team="Internazionale",number=" (4)",lastname="Kanu " },new PlayerModel {
 name = "Rashidi ",age="63",team="Zürich",number=" (9)",lastname="Yekini " },new PlayerModel {
 name = "Daniel ",age="43",team="Beşiktaş",number="(14)",lastname="Amokachi " },new PlayerModel {
 name = "Victor ",age="15",team="AS Monaco",number="(20)",lastname="Ikpeba " }}},{
"nl-netherlands",new List<PlayerModel>{
new PlayerModel {
 name = "Edwin ",age="25",team="Ajax",number="(1)",lastname="van " },new PlayerModel {
 name = "Ed ",age="31",team="Chelsea",number="(18)",lastname="de " },new PlayerModel {
 name = "Ruud ",age="0",team="Barcelona",number="(22)",lastname="Hesp " },new PlayerModel {
 name = "Michael ",age="26",team="Barcelona",number=" (2)",lastname="Reiziger " },new PlayerModel {
 name = "Jaap ",age="14",team="PSV",number=" (3)",lastname="Stam " },new PlayerModel {
 name = "Frank ",age="55",team="Ajax",number=" (4)",lastname="de " },new PlayerModel {
 name = "Arthur ",age="29",team="PSV",number=" (5)",lastname="Numan " },new PlayerModel {
 name = "André ",age="0",team="PSV",number="(13)",lastname="Ooijer " },new PlayerModel {
 name = "Winston ",age="14",team="Barcelona",number="(15)",lastname="Bogarde " },new PlayerModel {
 name = "Wim ",age="42",team="PSV",number=" (6)",lastname="Jonk " },new PlayerModel {
 name = "Ronald ",age="41",team="Ajax",number=" (7)",lastname="de " },new PlayerModel {
 name = "Clarence ",age="31",team="Real Madrid",number="(10)",lastname="Seedorf " },new PlayerModel {
 name = "Phillip ",age="20",team="PSV",number="(11)",lastname="Cocu " },new PlayerModel {
 name = "Boudewijn ",age="6",team="PSV",number="(12)",lastname="Zenden " },new PlayerModel {
 name = "Marc ",age="40",team="Arsenal",number="(14)",lastname="Overmars " },new PlayerModel {
 name = "Edgar ",age="12",team="Juventus",number="(16)",lastname="Davids " },new PlayerModel {
 name = "Giovanni ",age="8",team="Feyenoord",number="(19)",lastname="van " },new PlayerModel {
 name = "Aron ",age="72",team="Internazionale",number="(20)",lastname="Winter " },new PlayerModel {
 name = "Dennis ",age="57",team="Arsenal",number=" (8)",lastname="Bergkamp " },new PlayerModel {
 name = "Patrick ",age="19",team="Milan",number=" (9)",lastname="Kluivert " },new PlayerModel {
 name = "Pierre ",age="12",team="Nottingham Forest",number="(17)",lastname="van " },new PlayerModel {
 name = "Jimmy ",age="3",team="Leeds United",number="(21)",lastname="Floyd " }}},{
"no-norway",new List<PlayerModel>{
new PlayerModel {
 name = "Frode ",age="39",team="Tottenham Hotspur",number="(1)",lastname="Grodås " },new PlayerModel {
 name = "Thomas ",age="1",team="Everton",number="(12)",lastname="Myhre " },new PlayerModel {
 name = "Espen ",age="1",team="Tottenham Hotspur",number="(13)",lastname="Baardsen " },new PlayerModel {
 name = "Gunnar ",age="60",team="Leeds United",number=" (2)",lastname="Halle " },new PlayerModel {
 name = "Ronny ",age="33",team="Manchester United",number=" (3)",lastname="Johnsen " },new PlayerModel {
 name = "Henning ",age="52",team="Manchester United",number=" (4)",lastname="Berg " },new PlayerModel {
 name = "Stig ",age="62",team="Liverpool",number=" (5)",lastname="Inge " },new PlayerModel {
 name = "Vegard ",age="1",team="Rosenborg",number="(14)",lastname="Heggem " },new PlayerModel {
 name = "Dan ",age="13",team="Celta Vigo",number="(15)",lastname="Eggen " },new PlayerModel {
 name = "Erik ",age="1",team="Rosenborg",number="(19)",lastname="Hoftun " },new PlayerModel {
 name = "Ståle ",age="34",team="AaB",number=" (6)",lastname="Solbakken " },new PlayerModel {
 name = "Erik ",age="54",team="Panathinaikos",number=" (7)",lastname="Mykland " },new PlayerModel {
 name = "Øyvind ",age="55",team="Liverpool",number=" (8)",lastname="Leonhardsen " },new PlayerModel {
 name = "Kjetil ",age="66",team="Hertha BSC",number="(10)",lastname="Rekdal " },new PlayerModel {
 name = "Mini ",age="64",team="Rosenborg",number="(11)",lastname="Jakobsen " },new PlayerModel {
 name = "Jostein ",age="44",team="Strømsgodset",number="(16)",lastname="Flo " },new PlayerModel {
 name = "Håvard ",age="9",team="Werder Bremen",number="(17)",lastname="Flo " },new PlayerModel {
 name = "Vidar ",age="4",team="LASK Linz",number="(21)",lastname="Riseth " },new PlayerModel {
 name = "Roar ",age="5",team="Rosenborg",number="(22)",lastname="Strand " },new PlayerModel {
 name = "Tore ",age="25",team="Chelsea",number=" (9)",lastname="André " },new PlayerModel {
 name = "Egil ",age="13",team="Southampton",number="(18)",lastname="Østenstad " },new PlayerModel {
 name = "Ole ",age="13",team="Manchester United",number="(20)",lastname="Gunnar " }}},{
"py-paraguay",new List<PlayerModel>{
new PlayerModel {
 name = "José ",age="40",team="Vélez Sársfield",number="(1)",lastname="Luis " },new PlayerModel {
 name = "Danilo ",age="3",team="Unión de Santa Fe",number="(12)",lastname="Aceval " },new PlayerModel {
 name = "Rubén ",age="12",team="Monterrey",number="(22)",lastname="Ruiz " },new PlayerModel {
 name = "Francisco ",age="28",team="Palmeiras",number=" (2)",lastname="Arce " },new PlayerModel {
 name = "Catalino ",age="49",team="Grêmio",number=" (3)",lastname="Rivarola " },new PlayerModel {
 name = "Carlos ",age="48",team="Corinthians",number=" (4)",lastname="Gamarra " },new PlayerModel {
 name = "Celso ",age="42",team="River Plate",number=" (5)",lastname="Ayala " },new PlayerModel {
 name = "Edgar ",age="1",team="Cerro Corá",number=" (6)",lastname="Aguilera " },new PlayerModel {
 name = "Pedro ",age="20",team="River Plate",number="(11)",lastname="Sarabia " },new PlayerModel {
 name = "Ricardo ",age="6",team="Estudiantes",number="(14)",lastname="Rojas " },new PlayerModel {
 name = "Denis ",age="8",team="Olimpia",number="(20)",lastname="Caniza " },new PlayerModel {
 name = "Julio ",age="6",team="Cruz Azul",number=" (7)",lastname="César " },new PlayerModel {
 name = "Roberto ",age="40",team="Real Zaragoza",number="(10)",lastname="Acuña " },new PlayerModel {
 name = "Carlos ",age="3",team="Olimpia",number="(13)",lastname="Paredes " },new PlayerModel {
 name = "Julio ",age="4",team="Internacional",number="(16)",lastname="César " },new PlayerModel {
 name = "Carlos ",age="0",team="Gimnasia de Jujuy",number="(19)",lastname="Morales " },new PlayerModel {
 name = "Jorge ",age="10",team="Beijing Guo'an",number="(21)",lastname="Luis " },new PlayerModel {
 name = "Arístides ",age="5",team="Unión de Santa Fe",number=" (8)",lastname="Rojas " },new PlayerModel {
 name = "José ",age="12",team="Toluca",number=" (9)",lastname="Cardozo " },new PlayerModel {
 name = "Miguel ",age="32",team="Espanyol",number="(15)",lastname="Ángel " },new PlayerModel {
 name = "Hugo ",age="11",team="Argentinos Juniors",number="(17)",lastname="Brizuela " },new PlayerModel {
 name = "César ",age="3",team="Sporting CP",number="(18)",lastname="Ramírez " }}},{
"ro-romania",new List<PlayerModel>{
new PlayerModel {
 name = "Dumitru ",age="5",team="Kocaelispor",number="(1)",lastname="Stângaciu " },new PlayerModel {
 name = "Bogdan ",age="46",team="Salamanca",number="(12)",lastname="Stelea " },new PlayerModel {
 name = "Florin ",age="35",team="Universitatea Craiova",number="(22)",lastname="Prunea " },new PlayerModel {
 name = "Dan ",age="68",team="Chelsea",number=" (2)",lastname="Petrescu " },new PlayerModel {
 name = "Cristian ",age="5",team="Rapid Bucureşti",number=" (3)",lastname="Dulca " },new PlayerModel {
 name = "Anton ",age="21",team="AEK Athens",number=" (4)",lastname="Doboş " },new PlayerModel {
 name = "Gheorghe ",age="78",team="Galatasaray",number=" (6)",lastname="Popescu " },new PlayerModel {
 name = "Liviu ",age="4",team="Naţional Bucureşti",number="(13)",lastname="Ciobotariu " },new PlayerModel {
 name = "Tibor ",age="44",team="Anderlecht",number="(20)",lastname="Selymes " },new PlayerModel {
 name = "Constantin ",age="32",team="Espanyol",number=" (5)",lastname="Gâlcă " },new PlayerModel {
 name = "Dorinel ",age="63",team="1. FC Köln",number=" (8)",lastname="Munteanu " },new PlayerModel {
 name = "Gheorghe ",age="111",team="Galatasaray",number="(10)",lastname="Hagi " },new PlayerModel {
 name = "Radu ",age="11",team="Naţional Bucureşti",number="(14)",lastname="Niculescu " },new PlayerModel {
 name = "Lucian ",age="4",team="Rapid Bucureşti",number="(15)",lastname="Marinescu " },new PlayerModel {
 name = "Gabriel ",age="12",team="Salamanca",number="(16)",lastname="Popescu " },new PlayerModel {
 name = "Iulian ",age="15",team="Galatasaray",number="(18)",lastname="Filipescu " },new PlayerModel {
 name = "Ovidiu ",age="19",team="PSV",number="(19)",lastname="Stîngă " },new PlayerModel {
 name = "Marius ",age="81",team="Steaua Bucureşti",number=" (7)",lastname="Lăcătuş " },new PlayerModel {
 name = "Viorel ",age="24",team="Coventry City",number=" (9)",lastname="Moldovan " },new PlayerModel {
 name = "Adrian ",age="20",team="Valencia",number="(11)",lastname="Ilie " },new PlayerModel {
 name = "Ilie ",age="62",team="Atlante",number="(17)",lastname="Dumitrescu " },new PlayerModel {
 name = "Gheorghe ",age="18",team="Real Sociedad",number="(21)",lastname="Craioveanu " }}},{
"sa-saudi-arabia",new List<PlayerModel>{
new PlayerModel {
 name = "Mohamed ",age="94",team="Al-Ta'ee",number="(1)",lastname="Al-Deayea " },new PlayerModel {
 name = "Hussein ",age="64",team="Al-Qadisiya",number="(21)",lastname="Al-Sadiq " },new PlayerModel {
 name = "Tisir ",age="0",team="Al-Ittifaq",number="(22)",lastname="Al-Antaif " },new PlayerModel {
 name = "Mohammed ",age="64",team="Al-Ahli",number=" (2)",lastname="Al-Jahani " },new PlayerModel {
 name = "Mohammed ",age="86",team="Al-Ittihad",number=" (3)",lastname="Al-Khilaiwi " },new PlayerModel {
 name = "Ahmad ",age="94",team="Al-Ittihad",number=" (5)",lastname="Jamil " },new PlayerModel {
 name = "Hussein ",age="40",team="Al-Ahli",number="(13)",lastname="Sulaimani " },new PlayerModel {
 name = "Ahmed ",age="12",team="Al-Hilal",number="(17)",lastname="Dokhi " },new PlayerModel {
 name = "Abdulaziz ",age="3",team="Al-Nasr",number="(19)",lastname="Al-Janoubi " },new PlayerModel {
 name = "Abdullah ",age="83",team="Al-Ahli",number=" (4)",lastname="Zubromawi " },new PlayerModel {
 name = "Fuad ",age="95",team="Al-Shabab",number=" (6)",lastname="Amin " },new PlayerModel {
 name = "Ibrahim ",age="47",team="Al-Nasr",number="(12)",lastname="Al-Harbi " },new PlayerModel {
 name = "Khalid ",age="91",team="Al-Ahli",number="(14)",lastname="Al-Muwallid " },new PlayerModel {
 name = "Yousuf ",age="86",team="Al-Hilal",number="(15)",lastname="Al-Thunayan " },new PlayerModel {
 name = "Khamis ",age="48",team="Al-Hilal",number="(16)",lastname="Al-Owairan " },new PlayerModel {
 name = "Nawaf ",age="0",team="Al-Hilal",number="(18)",lastname="Al-Temyat " },new PlayerModel {
 name = "Hamzah ",age="38",team="Al-Ahli",number="(20)",lastname="Saleh " },new PlayerModel {
 name = "Ibrahim ",age="19",team="Al-Ahli",number=" (7)",lastname="Al-Shahrani " },new PlayerModel {
 name = "Obeid ",age="61",team="Al-Wehda",number=" (8)",lastname="Al-Dosari " },new PlayerModel {
 name = "Sami ",age="85",team="Al-Hilal",number=" (9)",lastname="Al-Jaber " },new PlayerModel {
 name = "Saeed ",age="55",team="Al-Shabab",number="(10)",lastname="Al-Owairan " },new PlayerModel {
 name = "Fahad ",age="85",team="Al-Shabab",number="(11)",lastname="Al-Mehallel " }}},{
"sco-scotland",new List<PlayerModel>{
new PlayerModel {
 name = "Jim ",age="86",team="Aberdeen",number="(1)",lastname="Leighton " },new PlayerModel {
 name = "Neil ",age="3",team="Wimbledon",number="(12)",lastname="Sullivan " },new PlayerModel {
 name = "Jonathan ",age="0",team="Celtic",number="(21)",lastname="Gould " },new PlayerModel {
 name = "Tom ",age="55",team="Celtic",number=" (3)",lastname="Boyd " },new PlayerModel {
 name = "Colin ",age="28",team="Tottenham Hotspur",number=" (4)",lastname="Calderwood " },new PlayerModel {
 name = "Colin ",age="32",team="Blackburn Rovers",number=" (5)",lastname="Hendry " },new PlayerModel {
 name = "Tosh ",age="19",team="Celtic",number=" (6)",lastname="McKinlay " },new PlayerModel {
 name = "David ",age="5",team="Hearts",number="(16)",lastname="Weir " },new PlayerModel {
 name = "Matt ",age="3",team="Leicester City",number="(18)",lastname="Elliott " },new PlayerModel {
 name = "Derek ",age="11",team="Aberdeen",number="(19)",lastname="Whyte " },new PlayerModel {
 name = "Christian ",age="10",team="Derby County",number="(22)",lastname="Dailly " },new PlayerModel {
 name = "Jackie ",age="6",team="Celtic",number=" (2)",lastname="McNamara " },new PlayerModel {
 name = "Craig ",age="25",team="Celtic",number=" (8)",lastname="Burley " },new PlayerModel {
 name = "Darren ",age="24",team="Celtic",number="(10)",lastname="Jackson " },new PlayerModel {
 name = "John ",age="49",team="AS Monaco",number="(11)",lastname="Collins " },new PlayerModel {
 name = "Paul ",age="12",team="Celtic",number="(14)",lastname="Lambert " },new PlayerModel {
 name = "Scot ",age="13",team="Nottingham Forest",number="(15)",lastname="Gemmill " },new PlayerModel {
 name = "Billy ",age="25",team="Blackburn Rovers",number="(17)",lastname="McKinlay " },new PlayerModel {
 name = "Kevin ",age="36",team="Blackburn Rovers",number=" (7)",lastname="Gallacher " },new PlayerModel {
 name = "Gordon ",age="40",team="Rangers",number=" (9)",lastname="Durie " },new PlayerModel {
 name = "Simon ",age="8",team="Celtic",number="(13)",lastname="Donnelly " },new PlayerModel {
 name = "Scott ",age="16",team="Utrecht",number="(20)",lastname="Booth " }}},{
"tn-tunisia",new List<PlayerModel>{
new PlayerModel {
 name = "Chokri ",age="51",team="Espérance",number="(1)",lastname="El " },new PlayerModel {
 name = "Radhouane ",age="5",team="Étoile Sahel",number="(16)",lastname="Salhi " },new PlayerModel {
 name = "Ali ",age="12",team="Bastia",number="(22)",lastname="Boumnijel " },new PlayerModel {
 name = "Sami ",age="45",team="CS Sfaxien",number=" (3)",lastname="Trabelsi " },new PlayerModel {
 name = "Mounir ",age="30",team="Étoile Sahel",number=" (4)",lastname="Boukadida " },new PlayerModel {
 name = "Hatem ",age="2",team="CS Sfaxien",number=" (5)",lastname="Trabelsi " },new PlayerModel {
 name = "Ferid ",age="26",team="Étoile Sahel",number=" (6)",lastname="Chouchane " },new PlayerModel {
 name = "Tarek ",age="43",team="Espérance",number=" (7)",lastname="Thabet " },new PlayerModel {
 name = "Sabri ",age="20",team="Club Africain",number="(20)",lastname="Jaballah " },new PlayerModel {
 name = "Khaled ",age="26",team="Espérance",number="(21)",lastname="Badra " },new PlayerModel {
 name = "Zoubeir ",age="44",team="SC Freiburg",number=" (8)",lastname="Baya " },new PlayerModel {
 name = "Kaies ",age="46",team="Étoile Sahel",number="(10)",lastname="Ghodhbane " },new PlayerModel {
 name = "Riadh ",age="24",team="Étoile Sahel",number="(13)",lastname="Bouazizi " },new PlayerModel {
 name = "Sirajeddine ",age="47",team="Espérance",number="(14)",lastname="Chihi " },new PlayerModel {
 name = "Skander ",age="31",team="CS Sfaxien",number="(15)",lastname="Souayah " },new PlayerModel {
 name = "José ",age="4",team="Étoile Sahel",number="(17)",lastname="Clayton " },new PlayerModel {
 name = "Faysal ",age="2",team="Espérance",number="(19)",lastname="Ben " },new PlayerModel {
 name = "Imed ",age="9",team="Étoile Sahel",number=" (2)",lastname="Ben " },new PlayerModel {
 name = "Riadh ",age="13",team="Étoile Sahel",number=" (9)",lastname="Jelassi " },new PlayerModel {
 name = "Adel ",age="57",team="Real Jaén",number="(11)",lastname="Sellimi " },new PlayerModel {
 name = "Mourad ",age="2",team="Olympique Béja",number="(12)",lastname="Melki " },new PlayerModel {
 name = "Mehdi ",age="32",team="SC Freiburg",number="(18)",lastname="Ben " }}},{
"yug-yugoslavia",new List<PlayerModel>{
new PlayerModel {
 name = "Ivica ",age="15",team="Partizan",number="(1)",lastname="Kralj " },new PlayerModel {
 name = "Dragoje ",age="13",team="Sporting Gijón",number="(12)",lastname="Leković " },new PlayerModel {
 name = "Zoran ",age="28",team="Atalanta",number=" (2)",lastname="Mirković " },new PlayerModel {
 name = "Goran ",age="26",team="Celta Vigo",number=" (3)",lastname="Đorović " },new PlayerModel {
 name = "Miroslav ",age="23",team="Valencia",number=" (5)",lastname="Đukić " },new PlayerModel {
 name = "Branko ",age="22",team="Espanyol",number=" (6)",lastname="Brnović " },new PlayerModel {
 name = "Siniša ",age="30",team="Sampdoria",number="(11)",lastname="Mihajlović " },new PlayerModel {
 name = "Slobodan ",age="8",team="MSV Duisburg",number="(13)",lastname="Komljenović " },new PlayerModel {
 name = "Niša ",age="20",team="Bordeaux",number="(14)",lastname="Saveljić " },new PlayerModel {
 name = "Slaviša ",age="33",team="Tenerife",number=" (4)",lastname="Jokanović " },new PlayerModel {
 name = "Vladimir ",age="24",team="Lazio",number=" (7)",lastname="Jugović " },new PlayerModel {
 name = "Dragan ",age="64",team="Nagoya Grampus Eight",number="(10)",lastname="Stojković " },new PlayerModel {
 name = "Ljubinko ",age="16",team="Porto",number="(15)",lastname="Drulović " },new PlayerModel {
 name = "Željko ",age="12",team="Urawa Red Diamonds",number="(16)",lastname="Petrović " },new PlayerModel {
 name = "Dejan ",age="20",team="Lecce",number="(18)",lastname="Govedarica " },new PlayerModel {
 name = "Miroslav ",age="5",team="1860 Munich",number="(19)",lastname="Stević " },new PlayerModel {
 name = "Dejan ",age="3",team="Crvena Zvezda",number="(20)",lastname="Stanković " },new PlayerModel {
 name = "Dejan ",age="49",team="Milan",number=" (8)",lastname="Savićević " },new PlayerModel {
 name = "Predrag ",age="28",team="Real Madrid",number=" (9)",lastname="Mijatović " },new PlayerModel {
 name = "Savo ",age="28",team="Aston Villa",number="(17)",lastname="Milošević " },new PlayerModel {
 name = "Perica ",age="5",team="Crvena Zvezda",number="(21)",lastname="Ognjenović " },new PlayerModel {
 name = "Darko ",age="19",team="Real Sociedad",number="(22)",lastname="Kovačević " }}},{
"za-south-africa",new List<PlayerModel>{
new PlayerModel {
 name = "Hans ",age="0",team="Heerenveen",number="(1)",lastname="Vonk " },new PlayerModel {
 name = "Brian ",age="8",team="Kaizer Chiefs",number="(16)",lastname="Baloyi " },new PlayerModel {
 name = "Paul ",age="0",team="Supersport United",number="(22)",lastname="Evans " },new PlayerModel {
 name = "Simon ",age="1",team="Bloemfontein Celtic",number="(23)",lastname="Gopane " },new PlayerModel {
 name = "Themba ",age="3",team="Mamelodi Sundowns",number=" (2)",lastname="Mnguni " },new PlayerModel {
 name = "David ",age="35",team="St. Gallen",number=" (3)",lastname="Nyathi " },new PlayerModel {
 name = "Willem ",age="12",team="Orlando Pirates",number=" (4)",lastname="Jackson " },new PlayerModel {
 name = "Mark ",age="37",team="Bolton Wanderers",number=" (5)",lastname="Fish " },new PlayerModel {
 name = "Lucas ",age="41",team="Leeds United",number="(19)",lastname="Radebe " },new PlayerModel {
 name = "Pierre ",age="1",team="Marseille",number="(21)",lastname="Issa " },new PlayerModel {
 name = "Quinton ",age="6",team="Atlético Madrid",number=" (7)",lastname="Fortune " },new PlayerModel {
 name = "Alfred ",age="2",team="Vanspor",number=" (8)",lastname="Phiri " },new PlayerModel {
 name = "John ",age="44",team="Fenerbahçe",number="(10)",lastname="Moshoeu " },new PlayerModel {
 name = "Helman ",age="35",team="Kayserispor",number="(11)",lastname="Mkhalele " },new PlayerModel {
 name = "Doctor ",age="43",team="Kaizer Chiefs",number="(15)",lastname="Khumalo " },new PlayerModel {
 name = "Lebohang ",age="0",team="Vanspor",number="(18)",lastname="Morula " },new PlayerModel {
 name = "William ",age="0",team="Manning Rangers",number="(20)",lastname="Mokoena " },new PlayerModel {
 name = "Phil ",age="41",team="Bari",number=" (6)",lastname="Masinga " },new PlayerModel {
 name = "Shaun ",age="29",team="Cape Town Spurs",number=" (9)",lastname="Bartlett " },new PlayerModel {
 name = "Brendan ",age="26",team="LASK Linz",number="(12)",lastname="Augustine " },new PlayerModel {
 name = "Delron ",age="0",team="VfL Bochum",number="(13)",lastname="Buckley " },new PlayerModel {
 name = "Jerry ",age="9",team="Orlando Pirates",number="(14)",lastname="Sikhosana " },new PlayerModel {
 name = "Benni ",age="10",team="Ajax",number="(17)",lastname="McCarthy " }}
 } }
 );
        squads.Add("2002",new Dictionary<string, List<PlayerModel>>
{
{
"za-south-africa",new List<PlayerModel>{
new PlayerModel {
 name = "Hans ",age="0",team="Heerenveen",number="(1)",lastname="Vonk " },new PlayerModel {
 name = "Brian ",age="8",team="Kaizer Chiefs",number="(16)",lastname="Baloyi " },new PlayerModel {
 name = "Paul ",age="0",team="Supersport United",number="(22)",lastname="Evans " },new PlayerModel {
 name = "Simon ",age="1",team="Bloemfontein Celtic",number="(23)",lastname="Gopane " },new PlayerModel {
 name = "Themba ",age="3",team="Mamelodi Sundowns",number=" (2)",lastname="Mnguni " },new PlayerModel {
 name = "David ",age="35",team="St. Gallen",number=" (3)",lastname="Nyathi " },new PlayerModel {
 name = "Willem ",age="12",team="Orlando Pirates",number=" (4)",lastname="Jackson " },new PlayerModel {
 name = "Mark ",age="37",team="Bolton Wanderers",number=" (5)",lastname="Fish " },new PlayerModel {
 name = "Lucas ",age="41",team="Leeds United",number="(19)",lastname="Radebe " },new PlayerModel {
 name = "Pierre ",age="1",team="Marseille",number="(21)",lastname="Issa " },new PlayerModel {
 name = "Quinton ",age="6",team="Atlético Madrid",number=" (7)",lastname="Fortune " },new PlayerModel {
 name = "Alfred ",age="2",team="Vanspor",number=" (8)",lastname="Phiri " },new PlayerModel {
 name = "John ",age="44",team="Fenerbahçe",number="(10)",lastname="Moshoeu " },new PlayerModel {
 name = "Helman ",age="35",team="Kayserispor",number="(11)",lastname="Mkhalele " },new PlayerModel {
 name = "Doctor ",age="43",team="Kaizer Chiefs",number="(15)",lastname="Khumalo " },new PlayerModel {
 name = "Lebohang ",age="0",team="Vanspor",number="(18)",lastname="Morula " },new PlayerModel {
 name = "William ",age="0",team="Manning Rangers",number="(20)",lastname="Mokoena " },new PlayerModel {
 name = "Phil ",age="41",team="Bari",number=" (6)",lastname="Masinga " },new PlayerModel {
 name = "Shaun ",age="29",team="Cape Town Spurs",number=" (9)",lastname="Bartlett " },new PlayerModel {
 name = "Brendan ",age="26",team="LASK Linz",number="(12)",lastname="Augustine " },new PlayerModel {
 name = "Delron ",age="0",team="VfL Bochum",number="(13)",lastname="Buckley " },new PlayerModel {
 name = "Jerry ",age="9",team="Orlando Pirates",number="(14)",lastname="Sikhosana " },new PlayerModel {
 name = "Benni ",age="10",team="Ajax",number="(17)",lastname="McCarthy " }}},{
"ar-argentina",new List<PlayerModel>{
new PlayerModel {
 name = "Germán ",age="35",team="Atlético Madrid",number="(1)",lastname="Burgos " },new PlayerModel {
 name = "Pablo ",age="8",team="Celta Vigo",number="(12)",lastname="Cavallero " },new PlayerModel {
 name = "Roberto ",age="13",team="Barcelona",number="(23)",lastname="Bonano " },new PlayerModel {
 name = "Roberto ",age="74",team="Valencia",number=" (2)",lastname="Ayala " },new PlayerModel {
 name = "Juan ",age="35",team="Cruzeiro",number=" (3)",lastname="Pablo " },new PlayerModel {
 name = "Mauricio ",age="16",team="Paris Saint-Germain",number=" (4)",lastname="Pochettino " },new PlayerModel {
 name = "Walter ",age="30",team="Roma",number=" (6)",lastname="Samuel " },new PlayerModel {
 name = "Javier ",age="66",team="Internazionale",number=" (8)",lastname="Zanetti " },new PlayerModel {
 name = "Diego ",age="6",team="Bayer Leverkusen",number="(13)",lastname="Placente " },new PlayerModel {
 name = "José ",age="42",team="Milan",number="(22)",lastname="Chamot " },new PlayerModel {
 name = "Matías ",age="33",team="Parma",number=" (5)",lastname="Almeyda " },new PlayerModel {
 name = "Ariel ",age="81",team="River Plate",number="(10)",lastname="Ortega " },new PlayerModel {
 name = "Juan ",age="47",team="Manchester United",number="(11)",lastname="Sebastián " },new PlayerModel {
 name = "Diego ",age="104",team="Lazio",number="(14)",lastname="Simeone " },new PlayerModel {
 name = "Claudio ",age="14",team="River Plate",number="(15)",lastname="Husaín " },new PlayerModel {
 name = "Pablo ",age="18",team="Valencia",number="(16)",lastname="Aimar " },new PlayerModel {
 name = "Gustavo ",age="31",team="Celta Vigo",number="(17)",lastname="López " },new PlayerModel {
 name = "Kily ",age="30",team="Valencia",number="(18)",lastname="González " },new PlayerModel {
 name = "Marcelo ",age="42",team="AS Monaco",number="(20)",lastname="Gallardo " },new PlayerModel {
 name = "Claudio ",age="49",team="Lazio",number=" (7)",lastname="López " },new PlayerModel {
 name = "Gabriel ",age="75",team="Roma",number=" (9)",lastname="Batistuta " },new PlayerModel {
 name = "Hernán ",age="33",team="Lazio",number="(19)",lastname="Crespo " },new PlayerModel {
 name = "Claudio ",age="50",team="Rangers",number="(21)",lastname="Caniggia " }}},{
"be-belgium",new List<PlayerModel>{
new PlayerModel {
 name = "Geert ",age="25",team="Willem II",number="(1)",lastname="De " },new PlayerModel {
 name = "Franky ",age="0",team="Mouscron",number="(13)",lastname="Vandendriessche " },new PlayerModel {
 name = "Frédéric ",age="7",team="Gent",number="(23)",lastname="Herpoel " },new PlayerModel {
 name = "Eric ",age="41",team="Lyon",number=" (2)",lastname="Deflandre " },new PlayerModel {
 name = "Glen ",age="33",team="Anderlecht",number=" (3)",lastname="De " },new PlayerModel {
 name = "Eric ",age="32",team="Standard Liège",number=" (4)",lastname="Van " },new PlayerModel {
 name = "Nico ",age="40",team="Schalke 04",number=" (5)",lastname="Van " },new PlayerModel {
 name = "Peter ",age="4",team="Club Brugge",number="(12)",lastname="Van " },new PlayerModel {
 name = "Jacky ",age="13",team="Gent",number="(15)",lastname="Peeters " },new PlayerModel {
 name = "Daniel ",age="7",team="Marseille",number="(16)",lastname="Van " },new PlayerModel {
 name = "Timmy ",age="12",team="Club Brugge",number=" (6)",lastname="Simons " },new PlayerModel {
 name = "Bart ",age="38",team="Hertha BSC",number=" (8)",lastname="Goor " },new PlayerModel {
 name = "Johan ",age="33",team="Standard Liège",number="(10)",lastname="Walem " },new PlayerModel {
 name = "Gert ",age="46",team="Club Brugge",number="(11)",lastname="Verheyen " },new PlayerModel {
 name = "Sven ",age="12",team="Schalke 04",number="(14)",lastname="Vermant " },new PlayerModel {
 name = "Gaëtan ",age="4",team="Club Brugge",number="(17)",lastname="Englebert " },new PlayerModel {
 name = "Yves ",age="30",team="Anderlecht",number="(18)",lastname="Vanderhaeghe " },new PlayerModel {
 name = "Bernd ",age="2",team="Racing Genk",number="(19)",lastname="Thijs " },new PlayerModel {
 name = "Danny ",age="52",team="St. Truiden",number="(21)",lastname="Boffin " },new PlayerModel {
 name = "Marc ",age="66",team="Schalke 04",number=" (7)",lastname="Wilmots " },new PlayerModel {
 name = "Wesley ",age="12",team="Racing Genk",number=" (9)",lastname="Sonck " },new PlayerModel {
 name = "Branko ",age="14",team="Derby County",number="(20)",lastname="Strupar " },new PlayerModel {
 name = "Mbo ",age="26",team="Mouscron",number="(22)",lastname="Mpenza " }}},{
"br-brazil",new List<PlayerModel>{
new PlayerModel {
 name = "Marcos ",age="15",team="Palmeiras",number="(1)",lastname="## " },new PlayerModel {
 name = "Dida ",age="49",team="Corinthians",number="(12)",lastname="## " },new PlayerModel {
 name = "Rogério ",age="12",team="São Paulo",number="(22)",lastname="Ceni " },new PlayerModel {
 name = "Cafu ",age="103",team="Roma",number=" (2)",lastname="## " },new PlayerModel {
 name = "Lúcio ",age="15",team="Bayer Leverkusen",number=" (3)",lastname="## " },new PlayerModel {
 name = "Roque ",age="17",team="Milan",number=" (4)",lastname="Júnior " },new PlayerModel {
 name = "Edmílson ",age="12",team="Lyon",number=" (5)",lastname="## " },new PlayerModel {
 name = "Roberto ",age="84",team="Real Madrid",number=" (6)",lastname="Carlos " },new PlayerModel {
 name = "Juliano ",age="10",team="São Paulo",number="(13)",lastname="Belletti " },new PlayerModel {
 name = "Ânderson ",age="5",team="Grêmio",number="(14)",lastname="Polga " },new PlayerModel {
 name = "Júnior ",age="12",team="Parma",number="(16)",lastname="## " },new PlayerModel {
 name = "Ricardinho ",age="3",team="Corinthians",number=" (7)",lastname="## " },new PlayerModel {
 name = "Gilberto ",age="6",team="Atlético Mineiro",number=" (8)",lastname="Silva " },new PlayerModel {
 name = "Rivaldo ",age="58",team="Barcelona",number="(10)",lastname="## " },new PlayerModel {
 name = "Ronaldinho ",age="24",team="Paris Saint-Germain",number="(11)",lastname="## " },new PlayerModel {
 name = "Kléberson ",age="5",team="Atlético Paranaense",number="(15)",lastname="## " },new PlayerModel {
 name = "Vampeta ",age="36",team="Corinthians",number="(18)",lastname="## " },new PlayerModel {
 name = "Juninho ",age="43",team="Middlesbrough",number="(19)",lastname="## " },new PlayerModel {
 name = "Kaká ",age="2",team="São Paulo",number="(23)",lastname="## " },new PlayerModel {
 name = "Ronaldo ",age="56",team="Internazionale",number=" (9)",lastname="## " },new PlayerModel {
 name = "Denílson ",age="53",team="Real Betis",number="(17)",lastname="## " },new PlayerModel {
 name = "Edílson ",age="17",team="Cruzeiro",number="(20)",lastname="## " },new PlayerModel {
 name = "Luizão ",age="8",team="Grêmio",number="(21)",lastname="## " }}},{
"cm-cameroon",new List<PlayerModel>{
new PlayerModel {
 name = "Alioum ",age="46",team="Samsunspor",number="(1)",lastname="Boukar " },new PlayerModel {
 name = "Jacques ",age="66",team="Metz",number="(16)",lastname="Songo'o " },new PlayerModel {
 name = "Idriss ",age="1",team="Le Havre",number="(22)",lastname="Carlos " },new PlayerModel {
 name = "Pierre ",age="46",team="Bologna",number=" (3)",lastname="Womé " },new PlayerModel {
 name = "Rigobert ",age="59",team="1. FC Köln",number=" (4)",lastname="Song " },new PlayerModel {
 name = "Raymond ",age="47",team="Extremadura",number=" (5)",lastname="Kalla " },new PlayerModel {
 name = "Pierre ",age="31",team="Strasbourg",number=" (6)",lastname="Njanka " },new PlayerModel {
 name = "Geremi ",age="38",team="Real Madrid",number=" (8)",lastname="Njitap " },new PlayerModel {
 name = "Lucien ",age="17",team="Manchester City",number="(13)",lastname="Mettomo " },new PlayerModel {
 name = "Bill ",age="12",team="Montpellier",number=" (2)",lastname="Tchato " },new PlayerModel {
 name = "Joseph ",age="16",team="Al-Khaleej",number=" (7)",lastname="N'Do " },new PlayerModel {
 name = "Lauren ",age="15",team="Arsenal",number="(12)",lastname="Etame " },new PlayerModel {
 name = "Joël ",age="22",team="Panathinaikos",number="(14)",lastname="Epalle " },new PlayerModel {
 name = "Nicolas ",age="15",team="Rizespor",number="(15)",lastname="Alnoudji " },new PlayerModel {
 name = "Marc-Vivien ",age="47",team="Lyon",number="(17)",lastname="Foé " },new PlayerModel {
 name = "Eric ",age="0",team="Nantes",number="(19)",lastname="Djemba-Djemba " },new PlayerModel {
 name = "Salomon ",age="39",team="Marseille",number="(20)",lastname="Olembé " },new PlayerModel {
 name = "Daniel ",age="4",team="Numancia",number="(23)",lastname="N'Gom " },new PlayerModel {
 name = "Samuel ",age="27",team="Mallorca",number=" (9)",lastname="Eto'o " },new PlayerModel {
 name = "Patrick ",age="42",team="Sunderland",number="(10)",lastname="M'Boma " },new PlayerModel {
 name = "Pius ",age="13",team="Sedan",number="(11)",lastname="N'Diefi " },new PlayerModel {
 name = "Patrick ",age="18",team="Sheffield United",number="(18)",lastname="Suffo " },new PlayerModel {
 name = "Joseph-Désiré ",age="34",team="Metz",number="(21)",lastname="Job " }}},{
"cn-china",new List<PlayerModel>{
new PlayerModel {
 name = "An ",age="5",team="Dalian Shide",number="(1)",lastname="Qi " },new PlayerModel {
 name = "Jiang ",age="52",team="Tianjin Teda FC",number="(22)",lastname="Jin " },new PlayerModel {
 name = "Ou ",age="74",team="Yunnan Hongta",number="(23)",lastname="Chuliang " },new PlayerModel {
 name = "Zhang ",age="65",team="Dalian Shide",number=" (2)",lastname="Enhua " },new PlayerModel {
 name = "Yang ",age="14",team="Beijing Guoan",number=" (3)",lastname="Pu " },new PlayerModel {
 name = "Wu ",age="53",team="Shanghai Shenhua",number=" (4)",lastname="Chengying " },new PlayerModel {
 name = "Fan ",age="105",team="Dundee",number=" (5)",lastname="Zhiyi " },new PlayerModel {
 name = "Sun ",age="59",team="Manchester City",number=" (7)",lastname="Jihai " },new PlayerModel {
 name = "Li ",age="55",team="Shenzhen Pingan",number="(14)",lastname="Weifeng " },new PlayerModel {
 name = "Du ",age="7",team="Shanghai Shenhua",number="(17)",lastname="Wei " },new PlayerModel {
 name = "Xu ",age="20",team="Beijing Guoan",number="(21)",lastname="Yunlong " },new PlayerModel {
 name = "Shao ",age="18",team="Beijing Guoan",number=" (6)",lastname="Jiayi " },new PlayerModel {
 name = "Li ",age="76",team="Liaoning",number=" (8)",lastname="Tie " },new PlayerModel {
 name = "Ma ",age="91",team="Sichuan Guancheng",number=" (9)",lastname="Mingyu " },new PlayerModel {
 name = "Yu ",age="17",team="Tianjin Teda FC",number="(11)",lastname="Genwei " },new PlayerModel {
 name = "Gao ",age="4",team="Shandong Luneng",number="(13)",lastname="Yao " },new PlayerModel {
 name = "Zhao ",age="13",team="Liaoning",number="(15)",lastname="Junzhe " },new PlayerModel {
 name = "Li ",age="26",team="Shandong Luneng",number="(18)",lastname="Xiaopeng " },new PlayerModel {
 name = "Qi ",age="36",team="Shanghai Zhongyuan",number="(19)",lastname="Hong " },new PlayerModel {
 name = "Hao ",age="95",team="Dalian Shide",number="(10)",lastname="Haidong " },new PlayerModel {
 name = "Su ",age="43",team="Shandong Luneng",number="(12)",lastname="Maozhen " },new PlayerModel {
 name = "Qu ",age="16",team="Qingdao Hainiu",number="(16)",lastname="Bo " },new PlayerModel {
 name = "Yang ",age="26",team="Eintracht Frankfurt",number="(20)",lastname="Chen " }}},{
"cr-costa-rica",new List<PlayerModel>{
new PlayerModel {
 name = "Erick ",age="74",team="Deportivo Saprissa",number="(1)",lastname="Lonnis " },new PlayerModel {
 name = "Álvaro ",age="16",team="Alajuelense",number="(18)",lastname="Mesén " },new PlayerModel {
 name = "Lester ",age="5",team="Herdiano",number="(23)",lastname="Morgan " },new PlayerModel {
 name = "Jervis ",age="38",team="Deportivo Saprissa",number=" (2)",lastname="Drummond " },new PlayerModel {
 name = "Luis ",age="74",team="Alajuelense",number=" (3)",lastname="Marín " },new PlayerModel {
 name = "Mauricio ",age="40",team="Herdiano",number=" (4)",lastname="Wright " },new PlayerModel {
 name = "Gilberto ",age="27",team="Deportivo Saprissa",number=" (5)",lastname="Martínez " },new PlayerModel {
 name = "Juan ",age="2",team="San Carlos",number="(14)",lastname="José " },new PlayerModel {
 name = "Harold ",age="54",team="Alajuelense",number="(15)",lastname="Wallace " },new PlayerModel {
 name = "Pablo ",age="12",team="Alajuelense",number="(21)",lastname="Chinchilla " },new PlayerModel {
 name = "Carlos ",age="22",team="Alajuelense",number="(22)",lastname="Castro " },new PlayerModel {
 name = "Wilmer ",age="68",team="Alajuelense",number=" (6)",lastname="López " },new PlayerModel {
 name = "Mauricio ",age="84",team="Alajuelense",number=" (8)",lastname="Solís " },new PlayerModel {
 name = "Walter ",age="49",team="Deportivo Saprissa",number="(10)",lastname="Centeno " },new PlayerModel {
 name = "Hernán ",age="87",team="Deportivo Saprissa",number="(17)",lastname="Medford " },new PlayerModel {
 name = "Rodrigo ",age="25",team="Herdiano",number="(19)",lastname="Cordero " },new PlayerModel {
 name = "Rolando ",age="79",team="Deportivo Saprissa",number=" (7)",lastname="Fonseca " },new PlayerModel {
 name = "Paulo ",age="48",team="Manchester City",number=" (9)",lastname="Wanchope " },new PlayerModel {
 name = "Rónald ",age="53",team="OFI Crete",number="(11)",lastname="Gómez " },new PlayerModel {
 name = "Winston ",age="3",team="Udinese",number="(12)",lastname="Parks " },new PlayerModel {
 name = "Daniel ",age="2",team="Herdiano",number="(13)",lastname="Vallejos " },new PlayerModel {
 name = "Steven ",age="33",team="Alajuelense",number="(16)",lastname="Bryce " },new PlayerModel {
 name = "William ",age="23",team="Herdiano",number="(20)",lastname="Sunsing " }}},{
"de-deutschland",new List<PlayerModel>{
new PlayerModel {
 name = "Oliver ",age="45",team="Bayern Munich",number="(1)",lastname="Kahn " },new PlayerModel {
 name = "Jens ",age="14",team="Borussia Dortmund",number="(12)",lastname="Lehmann " },new PlayerModel {
 name = "Hans-Jörg ",age="2",team="Bayer Leverkusen",number="(23)",lastname="Butt " },new PlayerModel {
 name = "Thomas ",age="34",team="Bayern Munich",number=" (2)",lastname="Linke " },new PlayerModel {
 name = "Marko ",age="27",team="Hertha BSC",number=" (3)",lastname="Rehmer " },new PlayerModel {
 name = "Frank ",age="11",team="Werder Bremen",number=" (4)",lastname="Baumann " },new PlayerModel {
 name = "Christian ",age="66",team="Tottenham Hotspur",number=" (6)",lastname="Ziege " },new PlayerModel {
 name = "Sebastian ",age="8",team="Borussia Dortmund",number="(15)",lastname="Kehl " },new PlayerModel {
 name = "Christoph ",age="6",team="Borussia Dortmund",number="(21)",lastname="Metzelder " },new PlayerModel {
 name = "Carsten ",age="25",team="Bayer Leverkusen",number=" (5)",lastname="Ramelow " },new PlayerModel {
 name = "Dietmar ",age="40",team="Liverpool",number=" (8)",lastname="Hamann " },new PlayerModel {
 name = "Lars ",age="16",team="Borussia Dortmund",number="(10)",lastname="Ricken " },new PlayerModel {
 name = "Michael ",age="22",team="Bayer Leverkusen",number="(13)",lastname="Ballack " },new PlayerModel {
 name = "Jens ",age="33",team="Bayern Munich",number="(16)",lastname="Jeremies " },new PlayerModel {
 name = "Marco ",age="34",team="Werder Bremen",number="(17)",lastname="Bode " },new PlayerModel {
 name = "Jörg ",age="6",team="Schalke 04",number="(18)",lastname="Böhme " },new PlayerModel {
 name = "Bernd ",age="9",team="Bayer Leverkusen",number="(19)",lastname="Schneider " },new PlayerModel {
 name = "Torsten ",age="8",team="Werder Bremen",number="(22)",lastname="Frings " },new PlayerModel {
 name = "Oliver ",age="30",team="Bayer Leverkusen",number=" (7)",lastname="Neuville " },new PlayerModel {
 name = "Carsten ",age="26",team="Bayern Munich",number=" (9)",lastname="Jancker " },new PlayerModel {
 name = "Miroslav ",age="12",team="1. FC Kaiserslautern",number="(11)",lastname="Klose " },new PlayerModel {
 name = "Gerald ",age="11",team="Schalke 04",number="(14)",lastname="Asamoah " },new PlayerModel {
 name = "Oliver ",age="65",team="AS Monaco",number="(20)",lastname="Bierhoff " }}},{
"dk-denmark",new List<PlayerModel>{
new PlayerModel {
 name = "Thomas ",age="14",team="Sunderland",number="(1)",lastname="Sørensen " },new PlayerModel {
 name = "Peter ",age="4",team="Aberdeen",number="(16)",lastname="Kjær " },new PlayerModel {
 name = "Jesper ",age="0",team="Vejle",number="(22)",lastname="Christiansen " },new PlayerModel {
 name = "René ",age="39",team="Panathinaikos",number=" (3)",lastname="Henriksen " },new PlayerModel {
 name = "Martin ",age="15",team="Milan",number=" (4)",lastname="Laursen " },new PlayerModel {
 name = "Jan ",age="83",team="PSV",number=" (5)",lastname="Heintze " },new PlayerModel {
 name = "Thomas ",age="67",team="Milan",number=" (6)",lastname="Helveg " },new PlayerModel {
 name = "Niclas ",age="8",team="Manchester City",number="(12)",lastname="Jensen " },new PlayerModel {
 name = "Steven ",age="4",team="Lyn",number="(13)",lastname="Lustü " },new PlayerModel {
 name = "Kasper ",age="2",team="PSV",number="(20)",lastname="Bøgelund " },new PlayerModel {
 name = "Stig ",age="36",team="Bolton Wanderers",number=" (2)",lastname="Tøfting " },new PlayerModel {
 name = "Thomas ",age="22",team="Everton",number=" (7)",lastname="Gravesen " },new PlayerModel {
 name = "Jesper ",age="25",team="Chelsea",number=" (8)",lastname="Grønkjær " },new PlayerModel {
 name = "Martin ",age="32",team="Udinese",number="(10)",lastname="Jørgensen " },new PlayerModel {
 name = "Claus ",age="13",team="Charlton Athletic",number="(14)",lastname="Jensen " },new PlayerModel {
 name = "Jan ",age="11",team="Panathinaikos",number="(15)",lastname="Michaelsen " },new PlayerModel {
 name = "Christian ",age="3",team="Copenhagen",number="(17)",lastname="Poulsen " },new PlayerModel {
 name = "Dennis ",age="19",team="PSV",number="(19)",lastname="Rommedahl " },new PlayerModel {
 name = "Brian ",age="65",team="Malmö",number="(23)",lastname="Steen " },new PlayerModel {
 name = "Jon ",age="38",team="Feyenoord",number=" (9)",lastname="Dahl " },new PlayerModel {
 name = "Ebbe ",age="44",team="Schalke 04",number="(11)",lastname="Sand " },new PlayerModel {
 name = "Peter ",age="4",team="Rangers",number="(18)",lastname="Løvenkrands " },new PlayerModel {
 name = "Peter ",age="4",team="Brøndby",number="(21)",lastname="Madsen " }}},{
"ec-ecuador",new List<PlayerModel>{
new PlayerModel {
 name = "José ",age="62",team="Barcelona",number="(1)",lastname="Francisco " },new PlayerModel {
 name = "Oswaldo ",age="21",team="El Nacional",number="(12)",lastname="Ibarra " },new PlayerModel {
 name = "Daniel ",age="0",team="Emelec",number="(22)",lastname="Viteri " },new PlayerModel {
 name = "Augusto ",age="26",team="Emelec",number=" (2)",lastname="Porozo " },new PlayerModel {
 name = "Iván ",age="90",team="Barcelona",number=" (3)",lastname="Hurtado " },new PlayerModel {
 name = "Ulises ",age="52",team="Hibernian",number=" (4)",lastname="de " },new PlayerModel {
 name = "Raúl ",age="23",team="Deportivo Quito",number=" (6)",lastname="Guerrón " },new PlayerModel {
 name = "Marlon ",age="26",team="Deportivo Quito",number="(15)",lastname="Ayoví " },new PlayerModel {
 name = "Giovanny ",age="19",team="Aucas",number="(17)",lastname="Espinoza " },new PlayerModel {
 name = "Walter ",age="2",team="Emelec",number="(23)",lastname="Ayoví " },new PlayerModel {
 name = "Alfonso ",age="40",team="LDU Quito",number=" (5)",lastname="Obregón " },new PlayerModel {
 name = "Luis ",age="8",team="Barcelona",number=" (8)",lastname="Gómez " },new PlayerModel {
 name = "Álex ",age="92",team="Necaxa",number="(10)",lastname="Aguinaga " },new PlayerModel {
 name = "Juan ",age="18",team="El Nacional",number="(14)",lastname="Carlos " },new PlayerModel {
 name = "Cléber ",age="64",team="El Nacional",number="(16)",lastname="Chalá " },new PlayerModel {
 name = "Edwin ",age="33",team="Barcelona",number="(20)",lastname="Tenorio " },new PlayerModel {
 name = "Wellington ",age="35",team="Emelec",number="(21)",lastname="Sánchez " },new PlayerModel {
 name = "Nicolás ",age="4",team="Barcelona",number=" (7)",lastname="Asencio " },new PlayerModel {
 name = "Iván ",age="26",team="Barcelona",number=" (9)",lastname="Kaviedes " },new PlayerModel {
 name = "Agustín ",age="46",team="Southampton",number="(11)",lastname="Delgado " },new PlayerModel {
 name = "Ángel ",age="68",team="El Nacional",number="(13)",lastname="Fernández " },new PlayerModel {
 name = "Carlos ",age="9",team="LDU Quito",number="(18)",lastname="Tenorio " },new PlayerModel {
 name = "Edison ",age="24",team="Deportivo Quito",number="(19)",lastname="Méndez " }}},{
"en-england",new List<PlayerModel>{
new PlayerModel {
 name = "David ",age="68",team="Arsenal",number="(1)",lastname="Seaman " },new PlayerModel {
 name = "Nigel ",age="22",team="Leeds United",number="(13)",lastname="Martyn " },new PlayerModel {
 name = "David ",age="9",team="West Ham United",number="(22)",lastname="James " },new PlayerModel {
 name = "Danny ",age="7",team="Leeds United",number=" (2)",lastname="Mills " },new PlayerModel {
 name = "Ashley ",age="8",team="Arsenal",number=" (3)",lastname="Cole " },new PlayerModel {
 name = "Rio ",age="21",team="Leeds United",number=" (5)",lastname="Ferdinand " },new PlayerModel {
 name = "Sol ",age="45",team="Arsenal",number=" (6)",lastname="Campbell " },new PlayerModel {
 name = "Wes ",age="6",team="Manchester United",number="(12)",lastname="Brown " },new PlayerModel {
 name = "Wayne ",age="5",team="Southampton",number="(14)",lastname="Bridge " },new PlayerModel {
 name = "Martin ",age="42",team="Arsenal",number="(15)",lastname="Keown " },new PlayerModel {
 name = "Gareth ",age="48",team="Middlesbrough",number="(16)",lastname="Southgate " },new PlayerModel {
 name = "Trevor ",age="5",team="West Ham United",number=" (4)",lastname="Sinclair " },new PlayerModel {
 name = "David ",age="49",team="Manchester United",number=" (7)",lastname="Beckham " },new PlayerModel {
 name = "Paul ",age="43",team="Manchester United",number=" (8)",lastname="Scholes " },new PlayerModel {
 name = "Owen ",age="6",team="Bayern Munich",number="(18)",lastname="Hargreaves " },new PlayerModel {
 name = "Joe ",age="6",team="West Ham United",number="(19)",lastname="Cole " },new PlayerModel {
 name = "Nicky ",age="18",team="Manchester United",number="(21)",lastname="Butt " },new PlayerModel {
 name = "Kieron ",age="9",team="Newcastle United",number="(23)",lastname="Dyer " },new PlayerModel {
 name = "Robbie ",age="24",team="Leeds United",number=" (9)",lastname="Fowler " },new PlayerModel {
 name = "Michael ",age="35",team="Liverpool",number="(10)",lastname="Owen " },new PlayerModel {
 name = "Emile ",age="23",team="Liverpool",number="(11)",lastname="Heskey " },new PlayerModel {
 name = "Teddy ",age="46",team="Tottenham Hotspur",number="(17)",lastname="Sheringham " },new PlayerModel {
 name = "Darius ",age="5",team="Aston Villa",number="(20)",lastname="Vassell " }}},{
"es-espana",new List<PlayerModel>{
new PlayerModel {
 name = "Iker ",age="13",team="Real Madrid",number="(1)",lastname="Casillas " },new PlayerModel {
 name = "Ricardo ",age="1",team="Real Valladolid",number="(13)",lastname="## " },new PlayerModel {
 name = "Pedro ",age="0",team="Málaga",number="(23)",lastname="Contreras " },new PlayerModel {
 name = "Curro ",age="4",team="Valencia",number=" (2)",lastname="Torres " },new PlayerModel {
 name = "Juanfran ",age="7",team="Celta Vigo",number=" (3)",lastname="## " },new PlayerModel {
 name = "Carles ",age="8",team="Barcelona",number=" (5)",lastname="Puyol " },new PlayerModel {
 name = "Fernando ",age="85",team="Real Madrid",number=" (6)",lastname="Hierro " },new PlayerModel {
 name = "Enrique ",age="3",team="Deportivo La Coruña",number="(15)",lastname="Romero " },new PlayerModel {
 name = "Miguel ",age="59",team="Mallorca",number="(20)",lastname="Ángel " },new PlayerModel {
 name = "Iván ",age="22",team="Real Madrid",number=" (4)",lastname="Helguera " },new PlayerModel {
 name = "Rubén ",age="9",team="Valencia",number=" (8)",lastname="Baraja " },new PlayerModel {
 name = "David ",age="2",team="Valencia",number="(14)",lastname="Albelda " },new PlayerModel {
 name = "Gaizka ",age="32",team="Lazio",number="(16)",lastname="Mendieta " },new PlayerModel {
 name = "Juan ",age="20",team="Deportivo La Coruña",number="(17)",lastname="Carlos " },new PlayerModel {
 name = "Sergio ",age="5",team="Deportivo La Coruña",number="(18)",lastname="## " },new PlayerModel {
 name = "Xavi ",age="3",team="Barcelona",number="(19)",lastname="## " },new PlayerModel {
 name = "Luis ",age="57",team="Barcelona",number="(21)",lastname="Enrique " },new PlayerModel {
 name = "Joaquín ",age="3",team="Real Betis",number="(22)",lastname="## " },new PlayerModel {
 name = "Raúl ",age="51",team="Real Madrid",number=" (7)",lastname="## " },new PlayerModel {
 name = "Fernando ",age="19",team="Real Madrid",number=" (9)",lastname="Morientes " },new PlayerModel {
 name = "Diego ",age="7",team="Deportivo La Coruña",number="(10)",lastname="Tristán " },new PlayerModel {
 name = "Javier ",age="5",team="Real Sociedad",number="(11)",lastname="de " },new PlayerModel {
 name = "Albert ",age="0",team="Mallorca",number="(12)",lastname="Luque " }}},{
"fr-france",new List<PlayerModel>{
new PlayerModel {
 name = "Ulrich ",age="11",team="Bordeaux",number="(1)",lastname="Ramé " },new PlayerModel {
 name = "Fabien ",age="47",team="Manchester United",number="(16)",lastname="Barthez " },new PlayerModel {
 name = "Grégory ",age="1",team="Lyon",number="(23)",lastname="Coupet " },new PlayerModel {
 name = "Vincent ",age="36",team="Roma",number=" (2)",lastname="Candela " },new PlayerModel {
 name = "Bixente ",age="74",team="Bayern Munich",number=" (3)",lastname="Lizarazu " },new PlayerModel {
 name = "Philippe ",age="4",team="Barcelona",number=" (5)",lastname="Christanval " },new PlayerModel {
 name = "Marcel ",age="93",team="Chelsea",number=" (8)",lastname="Desailly " },new PlayerModel {
 name = "Mikaël ",age="10",team="Manchester United",number="(13)",lastname="Silvestre " },new PlayerModel {
 name = "Lilian ",age="73",team="Juventus",number="(15)",lastname="Thuram " },new PlayerModel {
 name = "Frank ",age="47",team="Marseille",number="(18)",lastname="Leboeuf " },new PlayerModel {
 name = "Willy ",age="9",team="Bayern Munich",number="(19)",lastname="Sagnol " },new PlayerModel {
 name = "Patrick ",age="52",team="Arsenal",number=" (4)",lastname="Vieira " },new PlayerModel {
 name = "Youri ",age="79",team="Bolton Wanderers",number=" (6)",lastname="Djorkaeff " },new PlayerModel {
 name = "Claude ",age="14",team="Real Madrid",number=" (7)",lastname="Makélélé " },new PlayerModel {
 name = "Zinedine ",age="73",team="Real Madrid",number="(10)",lastname="Zidane " },new PlayerModel {
 name = "Alain ",age="26",team="Parma",number="(14)",lastname="Boghossian " },new PlayerModel {
 name = "Emmanuel ",age="57",team="Chelsea",number="(17)",lastname="Petit " },new PlayerModel {
 name = "Johan ",age="14",team="Parma",number="(22)",lastname="Micoud " },new PlayerModel {
 name = "Djibril ",age="1",team="Auxerre",number=" (9)",lastname="Cissé " },new PlayerModel {
 name = "Sylvain ",age="38",team="Arsenal",number="(11)",lastname="Wiltord " },new PlayerModel {
 name = "Thierry ",age="35",team="Arsenal",number="(12)",lastname="Henry " },new PlayerModel {
 name = "David ",age="36",team="Juventus",number="(20)",lastname="Trezeguet " },new PlayerModel {
 name = "Christophe ",age="51",team="Bordeaux",number="(21)",lastname="Dugarry " }}},{
"hr-croatia",new List<PlayerModel>{
new PlayerModel {
 name = "Stipe ",age="17",team="Hajduk Split",number="(1)",lastname="Pletikosa " },new PlayerModel {
 name = "Tomislav ",age="7",team="Dinamo Zagreb",number="(12)",lastname="Butina " },new PlayerModel {
 name = "Vladimir ",age="2",team="Zagreb",number="(23)",lastname="Vasilj " },new PlayerModel {
 name = "Anthony ",age="8",team="Hellas Verona",number=" (2)",lastname="Šerić " },new PlayerModel {
 name = "Josip ",age="6",team="Hertha BSC",number=" (3)",lastname="Šimunić " },new PlayerModel {
 name = "Stjepan ",age="17",team="Vicenza",number=" (4)",lastname="Tomas " },new PlayerModel {
 name = "Boris ",age="15",team="Bayer Leverkusen",number=" (6)",lastname="Živković " },new PlayerModel {
 name = "Daniel ",age="25",team="Panathinaikos",number="(15)",lastname="Šarić " },new PlayerModel {
 name = "Robert ",age="78",team="Panathinaikos",number="(17)",lastname="Jarni " },new PlayerModel {
 name = "Dario ",age="48",team="Internazionale",number="(20)",lastname="Šimić " },new PlayerModel {
 name = "Robert ",age="19",team="Bayern Munich",number="(21)",lastname="Kovač " },new PlayerModel {
 name = "Milan ",age="23",team="Fenerbahçe",number=" (5)",lastname="Rapaić " },new PlayerModel {
 name = "Robert ",age="48",team="Portsmouth",number=" (8)",lastname="Prosinečki " },new PlayerModel {
 name = "Niko ",age="20",team="Bayern Munich",number="(10)",lastname="Kovač " },new PlayerModel {
 name = "Mario ",age="43",team="Chelsea",number="(13)",lastname="Stanić " },new PlayerModel {
 name = "Zvonimir ",age="59",team="VfB Stuttgart",number="(14)",lastname="Soldo " },new PlayerModel {
 name = "Jurica ",age="7",team="Bayer Leverkusen",number="(16)",lastname="Vranješ " },new PlayerModel {
 name = "Davor ",age="21",team="Lecce",number=" (7)",lastname="Vugrinec " },new PlayerModel {
 name = "Davor ",age="68",team="1860 Munich",number=" (9)",lastname="Šuker " },new PlayerModel {
 name = "Alen ",age="36",team="Middlesbrough",number="(11)",lastname="Bokšić " },new PlayerModel {
 name = "Ivica ",age="4",team="Zagreb",number="(18)",lastname="Olić " },new PlayerModel {
 name = "Goran ",age="50",team="Panathinaikos",number="(19)",lastname="Vlaović " },new PlayerModel {
 name = "Boško ",age="13",team="Aston Villa",number="(22)",lastname="Balaban " }}},{
"ie-ireland",new List<PlayerModel>{
new PlayerModel {
 name = "Shay ",age="39",team="Newcastle United",number="(1)",lastname="Given " },new PlayerModel {
 name = "Dean ",age="6",team="Charlton Athletic",number="(16)",lastname="Kiely " },new PlayerModel {
 name = "Alan ",age="34",team="Blackburn Rovers",number="(23)",lastname="Kelly " },new PlayerModel {
 name = "Steve ",age="13",team="Fulham",number=" (2)",lastname="Finnan " },new PlayerModel {
 name = "Ian ",age="40",team="Leeds United",number=" (3)",lastname="Harte " },new PlayerModel {
 name = "Kenny ",age="38",team="Wimbledon",number=" (4)",lastname="Cunningham " },new PlayerModel {
 name = "Steve ",age="98",team="Aston Villa",number=" (5)",lastname="Staunton " },new PlayerModel {
 name = "Gary ",age="43",team="Coventry City",number="(14)",lastname="Breen " },new PlayerModel {
 name = "Richard ",age="14",team="Manchester City",number="(15)",lastname="Dunne " },new PlayerModel {
 name = "Gary ",age="46",team="Leeds United",number="(18)",lastname="Kelly " },new PlayerModel {
 name = "Andrew ",age="5",team="Newcastle United",number="(20)",lastname="O'Brien " },new PlayerModel {
 name = "Roy ",age="58",team="Manchester United",number=" (6)",lastname="Keane " },new PlayerModel {
 name = "Jason ",age="47",team="Sunderland",number=" (7)",lastname="McAteer " },new PlayerModel {
 name = "Matt ",age="19",team="Ipswich Town",number=" (8)",lastname="Holland " },new PlayerModel {
 name = "Damien ",age="26",team="Blackburn Rovers",number=" (9)",lastname="Duff " },new PlayerModel {
 name = "Kevin ",age="31",team="Sunderland",number="(11)",lastname="Kilbane " },new PlayerModel {
 name = "Mark ",age="28",team="Charlton Athletic",number="(12)",lastname="Kinsella " },new PlayerModel {
 name = "Steven ",age="5",team="Millwall",number="(21)",lastname="Reid " },new PlayerModel {
 name = "Lee ",age="19",team="Everton",number="(22)",lastname="Carsley " },new PlayerModel {
 name = "Robbie ",age="33",team="Leeds United",number="(10)",lastname="Keane " },new PlayerModel {
 name = "David ",age="33",team="Wimbledon",number="(13)",lastname="Connolly " },new PlayerModel {
 name = "Niall ",age="88",team="Sunderland",number="(17)",lastname="Quinn " },new PlayerModel {
 name = "Clinton ",age="7",team="Crystal Palace",number="(19)",lastname="Morrison " }}},{
"it-italy",new List<PlayerModel>{
new PlayerModel {
 name = "Gianluigi ",age="26",team="Juventus",number="(1)",lastname="Buffon " },new PlayerModel {
 name = "Christian ",age="0",team="Milan",number="(12)",lastname="Abbiati " },new PlayerModel {
 name = "Francesco ",age="22",team="Internazionale",number="(22)",lastname="Toldo " },new PlayerModel {
 name = "Christian ",age="24",team="Roma",number=" (2)",lastname="Panucci " },new PlayerModel {
 name = "Paolo ",age="122",team="Milan",number=" (3)",lastname="Maldini " },new PlayerModel {
 name = "Francesco ",age="13",team="Barcelona",number=" (4)",lastname="Coco " },new PlayerModel {
 name = "Fabio ",age="58",team="Parma",number=" (5)",lastname="Cannavaro " },new PlayerModel {
 name = "Alessandro ",age="43",team="Lazio",number="(13)",lastname="Nesta " },new PlayerModel {
 name = "Mark ",age="16",team="Juventus",number="(15)",lastname="Iuliano " },new PlayerModel {
 name = "Marco ",age="7",team="Internazionale",number="(23)",lastname="Materazzi " },new PlayerModel {
 name = "Cristiano ",age="4",team="Internazionale",number=" (6)",lastname="Zanetti " },new PlayerModel {
 name = "Gennaro ",age="13",team="Milan",number=" (8)",lastname="Gattuso " },new PlayerModel {
 name = "Cristiano ",age="3",team="Atalanta",number="(11)",lastname="Doni " },new PlayerModel {
 name = "Luigi ",age="28",team="Internazionale",number="(14)",lastname="Di " },new PlayerModel {
 name = "Angelo ",age="38",team="Fiorentina",number="(16)",lastname="Di " },new PlayerModel {
 name = "Damiano ",age="14",team="Roma",number="(17)",lastname="Tommasi " },new PlayerModel {
 name = "Gianluca ",age="23",team="Juventus",number="(19)",lastname="Zambrotta " },new PlayerModel {
 name = "Alessandro ",age="49",team="Juventus",number=" (7)",lastname="Del " },new PlayerModel {
 name = "Filippo ",age="38",team="Milan",number=" (9)",lastname="Inzaghi " },new PlayerModel {
 name = "Francesco ",age="29",team="Roma",number="(10)",lastname="Totti " },new PlayerModel {
 name = "Marco ",age="16",team="Roma",number="(18)",lastname="Delvecchio " },new PlayerModel {
 name = "Vincenzo ",age="14",team="Roma",number="(20)",lastname="Montella " },new PlayerModel {
 name = "Christian ",age="24",team="Internazionale",number="(21)",lastname="Vieri " }}},{
"jp-japan",new List<PlayerModel>{
new PlayerModel {
 name = "Yoshikatsu ",age="43",team="Portsmouth",number="(1)",lastname="Kawaguchi " },new PlayerModel {
 name = "Seigo ",age="15",team="Nagoya Grampus Eight",number="(12)",lastname="Narazaki " },new PlayerModel {
 name = "Hitoshi ",age="1",team="Kashima Antlers",number="(23)",lastname="Sogahata " },new PlayerModel {
 name = "Yutaka ",age="38",team="Kashima Antlers",number=" (2)",lastname="Akita " },new PlayerModel {
 name = "Naoki ",age="24",team="Yokohama F. Marinos",number=" (3)",lastname="Matsuda " },new PlayerModel {
 name = "Ryuzo ",age="32",team="Shimizu S-Pulse",number=" (4)",lastname="Morioka " },new PlayerModel {
 name = "Toshihiro ",age="35",team="Jubilo Iwata",number=" (6)",lastname="Hattori " },new PlayerModel {
 name = "Kōji ",age="20",team="Kashima Antlers",number="(16)",lastname="Nakata " },new PlayerModel {
 name = "Tsuneyasu ",age="5",team="Gamba Osaka",number="(17)",lastname="Miyamoto " },new PlayerModel {
 name = "Junichi ",age="22",team="Arsenal",number=" (5)",lastname="Inamoto " },new PlayerModel {
 name = "Hidetoshi ",age="39",team="Parma",number=" (7)",lastname="Nakata " },new PlayerModel {
 name = "Hiroaki ",age="57",team="Cerezo Osaka",number=" (8)",lastname="Morishima " },new PlayerModel {
 name = "Alessandro ",age="0",team="Shimizu S-Pulse",number="(14)",lastname="dos " },new PlayerModel {
 name = "Takashi ",age="5",team="Jubilo Iwata",number="(15)",lastname="Fukunishi " },new PlayerModel {
 name = "Shinji ",age="21",team="Feyenoord",number="(18)",lastname="Ono " },new PlayerModel {
 name = "Mitsuo ",age="0",team="Kashima Antlers",number="(19)",lastname="Ogasawara " },new PlayerModel {
 name = "Tomokazu ",age="16",team="Kashiwa Reysol",number="(20)",lastname="Myojin " },new PlayerModel {
 name = "Kazuyuki ",age="10",team="Shimizu S-Pulse",number="(21)",lastname="Toda " },new PlayerModel {
 name = "Daisuke ",age="1",team="Shimizu S-Pulse",number="(22)",lastname="Ichikawa " },new PlayerModel {
 name = "Akinori ",age="24",team="Cerezo Osaka",number=" (9)",lastname="Nishizawa " },new PlayerModel {
 name = "Masashi ",age="47",team="Jubilo Iwata",number="(10)",lastname="Nakayama " },new PlayerModel {
 name = "Takayuki ",age="10",team="Kashima Antlers",number="(11)",lastname="Suzuki " },new PlayerModel {
 name = "Atsushi ",age="22",team="Kashima Antlers",number="(13)",lastname="Yanagisawa " }}},{
"kr-south-korea",new List<PlayerModel>{
new PlayerModel {
 name = "Lee ",age="32",team="Suwon Samsung Bluewings",number="(1)",lastname="Woon-Jae " },new PlayerModel {
 name = "Kim ",age="58",team="Pohang Steelers",number="(12)",lastname="Byung-Ji " },new PlayerModel {
 name = "Choi ",age="1",team="Daejeon Citizen",number="(23)",lastname="Eun-Sung " },new PlayerModel {
 name = "Hyun ",age="8",team="Ulsan Hyundai Horangi",number=" (2)",lastname="Young-Min " },new PlayerModel {
 name = "Choi ",age="15",team="Jeonbuk Hyundai Motors",number=" (4)",lastname="Jin-Cheul " },new PlayerModel {
 name = "Yoo ",age="92",team="Kashiwa Reysol",number=" (6)",lastname="Sang-Chul " },new PlayerModel {
 name = "Kim ",age="74",team="Jeonnam Dragons",number=" (7)",lastname="Tae-Young " },new PlayerModel {
 name = "Lee ",age="48",team="Anyang LG Cheetahs",number="(10)",lastname="Young-Pyo " },new PlayerModel {
 name = "Lee ",age="52",team="Busan I'Cons",number="(15)",lastname="Min-Sung " },new PlayerModel {
 name = "Hong ",age="124",team="Pohang Steelers",number="(20)",lastname="Myung-Bo " },new PlayerModel {
 name = "Choi ",age="60",team="Suwon Samsung Bluewings",number=" (3)",lastname="Sung-Yong " },new PlayerModel {
 name = "Kim ",age="21",team="Jeonnam Dragons",number=" (5)",lastname="Nam-Il " },new PlayerModel {
 name = "Choi ",age="16",team="Anyang LG Cheetahs",number=" (8)",lastname="Tae-Uk " },new PlayerModel {
 name = "Lee ",age="19",team="Bucheon SK",number="(13)",lastname="Eul-Yong " },new PlayerModel {
 name = "Yoon ",age="36",team="Cerezo Osaka",number="(17)",lastname="Jung-Hwan " },new PlayerModel {
 name = "Ahn ",age="19",team="Perugia",number="(19)",lastname="Jung-Hwan " },new PlayerModel {
 name = "Park ",age="30",team="Kyoto Purple Sanga",number="(21)",lastname="Ji-Sung " },new PlayerModel {
 name = "Song ",age="27",team="Busan I'Cons",number="(22)",lastname="Chong-Gug " },new PlayerModel {
 name = "Seol ",age="31",team="Anderlecht",number=" (9)",lastname="Ki-Hyeon " },new PlayerModel {
 name = "Choi ",age="58",team="JEF United Ichihara",number="(11)",lastname="Yong-Soo " },new PlayerModel {
 name = "Lee ",age="22",team="Ulsan Hyundai Horangi",number="(14)",lastname="Chun-Soo " },new PlayerModel {
 name = "Cha ",age="12",team="Korea University",number="(16)",lastname="Du-Ri " },new PlayerModel {
 name = "Hwang ",age="95",team="Kashiwa Reysol",number="(18)",lastname="Sun-Hong " }}},{
"mx-mexico",new List<PlayerModel>{
new PlayerModel {
 name = "Óscar ",age="37",team="Cruz Azul",number="(1)",lastname="Pérez " },new PlayerModel {
 name = "Oswaldo ",age="22",team="Guadalajara",number="(12)",lastname="Sánchez " },new PlayerModel {
 name = "Jorge ",age="123",team="U.N.A.M.",number="(23)",lastname="Campos " },new PlayerModel {
 name = "Francisco ",age="15",team="Pachuca",number=" (2)",lastname="Gabriel " },new PlayerModel {
 name = "Manuel ",age="27",team="Pachuca",number=" (5)",lastname="Vidrio " },new PlayerModel {
 name = "Salvador ",age="56",team="Toluca",number="(16)",lastname="Carmona " },new PlayerModel {
 name = "Melvin ",age="8",team="Cruz Azul",number="(20)",lastname="Brown " },new PlayerModel {
 name = "Alberto ",age="13",team="Pachuca",number="(22)",lastname="Rodríguez " },new PlayerModel {
 name = "Rafael ",age="21",team="Toluca",number=" (3)",lastname="García " },new PlayerModel {
 name = "Rafael ",age="36",team="AS Monaco",number=" (4)",lastname="Márquez " },new PlayerModel {
 name = "Gerardo ",age="28",team="Poli Ejido",number=" (6)",lastname="Torrado " },new PlayerModel {
 name = "Ramón ",age="17",team="Guadalajara",number=" (7)",lastname="Morales " },new PlayerModel {
 name = "Alberto ",age="108",team="Puebla",number=" (8)",lastname="García " },new PlayerModel {
 name = "Braulio ",age="15",team="Necaxa",number="(11)",lastname="Luna " },new PlayerModel {
 name = "Sigifredo ",age="18",team="Atlas",number="(13)",lastname="Mercado " },new PlayerModel {
 name = "Germán ",age="46",team="América",number="(14)",lastname="Villa " },new PlayerModel {
 name = "Johan ",age="14",team="Santos",number="(18)",lastname="Rodríguez " },new PlayerModel {
 name = "Gabriel ",age="5",team="Pachuca",number="(19)",lastname="Caballero " },new PlayerModel {
 name = "Jared ",age="29",team="Santos",number=" (9)",lastname="Borgetti " },new PlayerModel {
 name = "Cuauhtémoc ",age="75",team="Real Valladolid",number="(10)",lastname="Blanco " },new PlayerModel {
 name = "Luis ",age="85",team="América",number="(15)",lastname="Hernández " },new PlayerModel {
 name = "Francisco ",age="67",team="Espanyol",number="(17)",lastname="Palencia " },new PlayerModel {
 name = "Jesús ",age="49",team="Monterrey",number="(21)",lastname="Arellano " }}},{
"ng-nigeria",new List<PlayerModel>{
new PlayerModel {
 name = "Ike ",age="34",team="Lucerne",number="(1)",lastname="Shorunmu " },new PlayerModel {
 name = "Austin ",age="3",team="Gabros International",number="(12)",lastname="Ejide " },new PlayerModel {
 name = "Vincent ",age="2",team="Enyimba",number="(22)",lastname="Enyeama " },new PlayerModel {
 name = "Joseph ",age="14",team="Marseille",number=" (2)",lastname="Yobo " },new PlayerModel {
 name = "Celestine ",age="24",team="Chelsea",number=" (3)",lastname="Babayaro " },new PlayerModel {
 name = "Isaac ",age="12",team="Shakhtar Donetsk",number=" (5)",lastname="Okoronkwo " },new PlayerModel {
 name = "Taribo ",age="38",team="1. FC Kaiserslautern",number=" (6)",lastname="West " },new PlayerModel {
 name = "Rabiu ",age="5",team="Standard Liège",number="(13)",lastname="Afolabi " },new PlayerModel {
 name = "Ifeanyi ",age="15",team="PAOK",number="(14)",lastname="Udeze " },new PlayerModel {
 name = "Efe ",age="7",team="Crewe Alexandra",number="(16)",lastname="Sodje " },new PlayerModel {
 name = "Eric ",age="12",team="Maccabi Haifa",number="(19)",lastname="Ejiofor " },new PlayerModel {
 name = "Pius ",age="9",team="Ajax",number=" (7)",lastname="Ikedia " },new PlayerModel {
 name = "Mutiu ",age="49",team="Salamanca",number=" (8)",lastname="Adepoju " },new PlayerModel {
 name = "Jay-Jay ",age="56",team="Paris Saint-Germain",number="(10)",lastname="Okocha " },new PlayerModel {
 name = "Garba ",age="34",team="Roda JC",number="(11)",lastname="Lawal " },new PlayerModel {
 name = "Justice ",age="7",team="Royal Antwerp",number="(15)",lastname="Christopher " },new PlayerModel {
 name = "James ",age="2",team="Lokomotiv Moscow",number="(20)",lastname="Obiorah " },new PlayerModel {
 name = "Nwankwo ",age="33",team="Arsenal",number=" (4)",lastname="Kanu " },new PlayerModel {
 name = "Bartholomew ",age="4",team="Paris Saint-Germain",number=" (9)",lastname="Ogbeche " },new PlayerModel {
 name = "Julius ",age="17",team="Shakhtar Donetsk",number="(17)",lastname="Aghahowa " },new PlayerModel {
 name = "Benedict ",age="16",team="Shenyang Haishi",number="(18)",lastname="Akwuegbu " },new PlayerModel {
 name = "John ",age="4",team="Al-Sadd",number="(21)",lastname="Utaka " },new PlayerModel {
 name = "Femi ",age="2",team="Ibadan",number="(23)",lastname="Opabunmi " }}},{
"pl-poland",new List<PlayerModel>{
new PlayerModel {
 name = "Jerzy ",age="21",team="Liverpool",number="(1)",lastname="Dudek " },new PlayerModel {
 name = "Radosław ",age="5",team="Göztepe",number="(12)",lastname="Majdan " },new PlayerModel {
 name = "Adam ",age="34",team="RKS Radomsko",number="(22)",lastname="Matysek " },new PlayerModel {
 name = "Tomasz ",age="37",team="1. FC Kaiserslautern",number=" (2)",lastname="Kłos " },new PlayerModel {
 name = "Jacek ",age="52",team="Legia Warszawa",number=" (3)",lastname="Zieliński " },new PlayerModel {
 name = "Tomasz ",age="44",team="Schalke 04",number=" (6)",lastname="Hajto " },new PlayerModel {
 name = "Arkadiusz ",age="2",team="Wisła Kraków",number="(13)",lastname="Głowacki " },new PlayerModel {
 name = "Tomasz ",age="71",team="Schalke 04",number="(15)",lastname="Wałdoch " },new PlayerModel {
 name = "Maciej ",age="4",team="Legia Warszawa",number="(16)",lastname="Murawski " },new PlayerModel {
 name = "Jacek ",age="36",team="Lens",number="(20)",lastname="Bąk " },new PlayerModel {
 name = "Michał ",age="25",team="Mouscron",number=" (4)",lastname="Żewłakow " },new PlayerModel {
 name = "Tomasz ",age="9",team="Feyenoord",number=" (5)",lastname="Rząsa " },new PlayerModel {
 name = "Piotr ",age="65",team="Marseille",number=" (7)",lastname="Świerczewski " },new PlayerModel {
 name = "Radosław ",age="30",team="Energie Cottbus",number="(10)",lastname="Kałużny " },new PlayerModel {
 name = "Arkadiusz ",age="12",team="Widzew Łódź",number="(17)",lastname="Bąk " },new PlayerModel {
 name = "Jacek ",age="23",team="1. FC Nürnberg",number="(18)",lastname="Krzynówek " },new PlayerModel {
 name = "Marek ",age="42",team="Ancona",number="(21)",lastname="Koźmiński " },new PlayerModel {
 name = "Paweł ",age="2",team="Odra Wodzisław",number="(23)",lastname="Sibik " },new PlayerModel {
 name = "Cezary ",age="15",team="Legia Warszawa",number=" (8)",lastname="Kucharski " },new PlayerModel {
 name = "Paweł ",age="23",team="Eintracht Frankfurt",number=" (9)",lastname="Kryszałowicz " },new PlayerModel {
 name = "Emmanuel ",age="16",team="Panathinaikos",number="(11)",lastname="Olisadebe " },new PlayerModel {
 name = "Marcin ",age="17",team="Mouscron",number="(14)",lastname="Żewłakow " },new PlayerModel {
 name = "Maciej ",age="9",team="Wisła Kraków",number="(19)",lastname="Żurawski " }}},{
"pt-portugal",new List<PlayerModel>{
new PlayerModel {
 name = "Vítor ",age="75",team="Porto",number="(1)",lastname="Baía " },new PlayerModel {
 name = "Nélson ",age="1",team="Sporting CP",number="(15)",lastname="## " },new PlayerModel {
 name = "Ricardo ",age="10",team="Boavista",number="(16)",lastname="## " },new PlayerModel {
 name = "Jorge ",age="46",team="Porto",number=" (2)",lastname="Costa " },new PlayerModel {
 name = "Abel ",age="18",team="Liverpool",number=" (3)",lastname="Xavier " },new PlayerModel {
 name = "Marco ",age="1",team="Benfica",number=" (4)",lastname="Caneira " },new PlayerModel {
 name = "Fernando ",age="82",team="Lazio",number=" (5)",lastname="Couto " },new PlayerModel {
 name = "Jorge ",age="5",team="Porto",number="(13)",lastname="Andrade " },new PlayerModel {
 name = "Nuno ",age="9",team="Boavista",number="(18)",lastname="Frechaut " },new PlayerModel {
 name = "Beto ",age="16",team="Sporting CP",number="(22)",lastname="## " },new PlayerModel {
 name = "Rui ",age="20",team="Sporting CP",number="(23)",lastname="Jorge " },new PlayerModel {
 name = "Paulo ",age="50",team="Espanyol",number=" (6)",lastname="Sousa " },new PlayerModel {
 name = "Luís ",age="81",team="Real Madrid",number=" (7)",lastname="Figo " },new PlayerModel {
 name = "Rui ",age="67",team="Milan",number="(10)",lastname="Costa " },new PlayerModel {
 name = "Sérgio ",age="41",team="Internazionale",number="(11)",lastname="Conceição " },new PlayerModel {
 name = "Hugo ",age="4",team="Sporting CP",number="(12)",lastname="Viana " },new PlayerModel {
 name = "Pedro ",age="21",team="Sporting CP",number="(14)",lastname="Barbosa " },new PlayerModel {
 name = "Paulo ",age="31",team="Sporting CP",number="(17)",lastname="Bento " },new PlayerModel {
 name = "Capucho ",age="29",team="Porto",number="(19)",lastname="## " },new PlayerModel {
 name = "Petit ",age="9",team="Boavista",number="(20)",lastname="## " },new PlayerModel {
 name = "João ",age="77",team="Sporting CP",number=" (8)",lastname="Pinto " },new PlayerModel {
 name = "Pauleta ",age="33",team="Bordeaux",number=" (9)",lastname="## " },new PlayerModel {
 name = "Nuno ",age="28",team="Fiorentina",number="(21)",lastname="Gomes " }}},{
"py-paraguay",new List<PlayerModel>{
new PlayerModel {
 name = "José ",age="69",team="Strasbourg",number="(1)",lastname="Luis " },new PlayerModel {
 name = "Justo ",age="8",team="Libertad",number="(12)",lastname="Villar " },new PlayerModel {
 name = "Ricardo ",age="20",team="Olimpia",number="(22)",lastname="Tavarelli " },new PlayerModel {
 name = "Francisco ",age="51",team="Palmeiras",number=" (2)",lastname="Arce " },new PlayerModel {
 name = "Pedro ",age="40",team="River Plate",number=" (3)",lastname="Sarabia " },new PlayerModel {
 name = "Carlos ",age="76",team="AEK Athens",number=" (4)",lastname="Gamarra " },new PlayerModel {
 name = "Celso ",age="76",team="River Plate",number=" (5)",lastname="Ayala " },new PlayerModel {
 name = "Juan ",age="3",team="Olimpia",number="(17)",lastname="Carlos " },new PlayerModel {
 name = "Julio ",age="1",team="Olimpia",number="(18)",lastname="César " },new PlayerModel {
 name = "Daniel ",age="6",team="Libertad",number="(19)",lastname="Sanabria " },new PlayerModel {
 name = "Denis ",age="49",team="Santos Laguna",number="(21)",lastname="Caniza " },new PlayerModel {
 name = "Estanislao ",age="69",team="Libertad",number=" (6)",lastname="Struway " },new PlayerModel {
 name = "Guido ",age="18",team="Léon",number=" (8)",lastname="Alvarenga " },new PlayerModel {
 name = "Roberto ",age="77",team="Real Zaragoza",number="(10)",lastname="Acuña " },new PlayerModel {
 name = "Carlos ",age="41",team="Porto",number="(13)",lastname="Paredes " },new PlayerModel {
 name = "Diego ",age="21",team="Tecos",number="(14)",lastname="Gavilán " },new PlayerModel {
 name = "Carlos ",age="3",team="Libertad",number="(15)",lastname="Bonet " },new PlayerModel {
 name = "Gustavo ",age="11",team="Libertad",number="(16)",lastname="Morínigo " },new PlayerModel {
 name = "Richard ",age="25",team="Olimpia",number=" (7)",lastname="Báez " },new PlayerModel {
 name = "Roque ",age="24",team="Bayern Munich",number=" (9)",lastname="Santa " },new PlayerModel {
 name = "Jorge ",age="31",team="Universidad Católica",number="(11)",lastname="Campos " },new PlayerModel {
 name = "José ",age="57",team="Toluca",number="(20)",lastname="Cardozo " },new PlayerModel {
 name = "Nelson ",age="11",team="River Plate",number="(23)",lastname="Cuevas " }}},{
"ru-russia",new List<PlayerModel>{
new PlayerModel {
 name = "Ruslan ",age="20",team="Hellas Verona",number="(1)",lastname="Nigmatullin " },new PlayerModel {
 name = "Stanislav ",age="49",team="Tirol Innsbruck",number="(12)",lastname="Cherchesov " },new PlayerModel {
 name = "Aleksandr ",age="16",team="Uralan Elista",number="(23)",lastname="Filimonov " },new PlayerModel {
 name = "Yuri ",age="44",team="Spartak Moscow",number=" (2)",lastname="Kovtun " },new PlayerModel {
 name = "Yuri ",age="56",team="PSV",number=" (3)",lastname="Nikiforov " },new PlayerModel {
 name = "Andrei ",age="5",team="CSKA Moscow",number=" (5)",lastname="Solomatin " },new PlayerModel {
 name = "Viktor ",age="97",team="Real Oviedo",number=" (7)",lastname="Onopko " },new PlayerModel {
 name = "Vyacheslav ",age="7",team="CSKA Moscow",number="(13)",lastname="Dayev " },new PlayerModel {
 name = "Igor ",age="30",team="Uralan Elista",number="(14)",lastname="Chugainov " },new PlayerModel {
 name = "Dmitri ",age="4",team="Lokomotiv Moscow",number="(18)",lastname="Sennikov " },new PlayerModel {
 name = "Alexey ",age="25",team="Bordeaux",number=" (4)",lastname="Smertin " },new PlayerModel {
 name = "Igor ",age="2",team="Torpedo Moscow",number=" (6)",lastname="Semshov " },new PlayerModel {
 name = "Valery ",age="69",team="Celta Vigo",number=" (8)",lastname="Karpin " },new PlayerModel {
 name = "Yegor ",age="30",team="Spartak Moscow",number=" (9)",lastname="Titov " },new PlayerModel {
 name = "Aleksandr ",age="59",team="Celta Vigo",number="(10)",lastname="Mostovoi " },new PlayerModel {
 name = "Dmitri ",age="43",team="Porto",number="(15)",lastname="Alenichev " },new PlayerModel {
 name = "Sergei ",age="31",team="CSKA Moscow",number="(17)",lastname="Semak " },new PlayerModel {
 name = "Marat ",age="8",team="Lokomotiv Moscow",number="(20)",lastname="Izmailov " },new PlayerModel {
 name = "Dmitri ",age="39",team="Real Sociedad",number="(21)",lastname="Khokhlov " },new PlayerModel {
 name = "Vladimir ",age="64",team="Spartak Moscow",number="(11)",lastname="Beschastnykh " },new PlayerModel {
 name = "Aleksandr ",age="3",team="Zenit St. Petersburg",number="(16)",lastname="Kerzhakov " },new PlayerModel {
 name = "Ruslan ",age="1",team="Lokomotiv Moscow",number="(19)",lastname="Pimenov " },new PlayerModel {
 name = "Dmitri ",age="3",team="Spartak Moscow",number="(22)",lastname="Sychev " }}},{
"sa-saudi-arabia",new List<PlayerModel>{
new PlayerModel {
 name = "Mohamed ",age="168",team="Al-Hilal",number="(1)",lastname="Al-Deayea " },new PlayerModel {
 name = "Mabrouk ",age="1",team="Al-Ittihad",number="(21)",lastname="Zaid " },new PlayerModel {
 name = "Mohammed ",age="12",team="Al-Nassr",number="(22)",lastname="Al-Khojali " },new PlayerModel {
 name = "Mohammed ",age="73",team="Al-Ahli",number=" (2)",lastname="Al-Jahani " },new PlayerModel {
 name = "Redha ",age="5",team="Al-Shabab",number=" (3)",lastname="Tukar " },new PlayerModel {
 name = "Abdullah ",age="115",team="Al-Ahli",number=" (4)",lastname="Zubromawi " },new PlayerModel {
 name = "Mohsin ",age="20",team="Al-Nassr",number=" (5)",lastname="Al-Harthi " },new PlayerModel {
 name = "Fouzi ",age="2",team="Al-Ahli",number=" (6)",lastname="Al-Shehri " },new PlayerModel {
 name = "Ahmed ",age="47",team="Al-Hilal",number="(12)",lastname="Dokhi " },new PlayerModel {
 name = "Hussein ",age="80",team="Al-Ahli",number="(13)",lastname="Sulaimani " },new PlayerModel {
 name = "Mansour ",age="0",team="Al-Nassr",number="(23)",lastname="Al-Thagafi " },new PlayerModel {
 name = "Ibrahim ",age="59",team="Al-Ahli",number=" (7)",lastname="Al-Shahrani " },new PlayerModel {
 name = "Mohammed ",age="29",team="Al-Ittihad",number=" (8)",lastname="Noor " },new PlayerModel {
 name = "Mohammad ",age="17",team="Al-Hilal",number="(10)",lastname="Al-Shalhoub " },new PlayerModel {
 name = "Abdulaziz ",age="0",team="Al-Shabab",number="(14)",lastname="Khathran " },new PlayerModel {
 name = "Khamis ",age="76",team="Al-Ittihad",number="(16)",lastname="Al-Owairan " },new PlayerModel {
 name = "Abdullah ",age="45",team="Al-Shabab",number="(17)",lastname="Al-Waked " },new PlayerModel {
 name = "Nawaf ",age="48",team="Al-Hilal",number="(18)",lastname="Al-Temyat " },new PlayerModel {
 name = "Omar ",age="28",team="Al-Hilal",number="(19)",lastname="Al-Ghamdi " },new PlayerModel {
 name = "Sami ",age="148",team="Al-Hilal",number=" (9)",lastname="Al-Jaber " },new PlayerModel {
 name = "Obeid ",age="97",team="Al-Ahli",number="(11)",lastname="Al-Dosari " },new PlayerModel {
 name = "Abdullah ",age="20",team="Al-Hilal",number="(15)",lastname="Jumaan " },new PlayerModel {
 name = "Al ",age="18",team="Al-Ittihad",number="(20)",lastname="Hasan " }}},{
"se-sweden",new List<PlayerModel>{
new PlayerModel {
 name = "Magnus ",age="44",team="Coventry City",number="(1)",lastname="Hedman " },new PlayerModel {
 name = "Magnus ",age="12",team="Copenhagen",number="(12)",lastname="Kihlstedt " },new PlayerModel {
 name = "Andreas ",age="1",team="Djurgården",number="(23)",lastname="Isaksson " },new PlayerModel {
 name = "Olof ",age="21",team="Aston Villa",number=" (2)",lastname="Mellberg " },new PlayerModel {
 name = "Patrik ",age="95",team="Barcelona",number=" (3)",lastname="Andersson " },new PlayerModel {
 name = "Johan ",age="35",team="Celtic",number=" (4)",lastname="Mjällby " },new PlayerModel {
 name = "Michael ",age="11",team="Troyes",number=" (5)",lastname="Svensson " },new PlayerModel {
 name = "Tomas ",age="6",team="Copenhagen",number="(13)",lastname="Antonelius " },new PlayerModel {
 name = "Erik ",age="5",team="Heerenveen",number="(14)",lastname="Edman " },new PlayerModel {
 name = "Andreas ",age="12",team="Hansa Rostock",number="(15)",lastname="Jakobsson " },new PlayerModel {
 name = "Teddy ",age="41",team="AIK",number="(16)",lastname="Lucic " },new PlayerModel {
 name = "Tobias ",age="19",team="Everton",number=" (6)",lastname="Linderoth " },new PlayerModel {
 name = "Niclas ",age="58",team="Everton",number=" (7)",lastname="Alexandersson " },new PlayerModel {
 name = "Anders ",age="24",team="Southampton",number=" (8)",lastname="Svensson " },new PlayerModel {
 name = "Fredrik ",age="31",team="Arsenal",number=" (9)",lastname="Ljungberg " },new PlayerModel {
 name = "Magnus ",age="24",team="Brøndby",number="(17)",lastname="Svensson " },new PlayerModel {
 name = "Mattias ",age="23",team="Brøndby",number="(18)",lastname="Jonson " },new PlayerModel {
 name = "Pontus ",age="2",team="AS Monaco",number="(19)",lastname="Farnerud " },new PlayerModel {
 name = "Daniel ",age="38",team="Venezia",number="(20)",lastname="Andersson " },new PlayerModel {
 name = "Marcus ",age="18",team="Heerenveen",number="(10)",lastname="Allbäck " },new PlayerModel {
 name = "Henrik ",age="67",team="Celtic",number="(11)",lastname="Larsson " },new PlayerModel {
 name = "Zlatan ",age="9",team="Ajax",number="(21)",lastname="Ibrahimović " },new PlayerModel {
 name = "Andreas ",age="32",team="AIK",number="(22)",lastname="Andersson " }}},{
"si-slovenia",new List<PlayerModel>{
new PlayerModel {
 name = "Marko ",age="43",team="Maribor",number="(1)",lastname="Simeunovič " },new PlayerModel {
 name = "Mladen ",age="20",team="Lokeren Oost-Vlaanderen",number="(12)",lastname="Dabanovič " },new PlayerModel {
 name = "Dejan ",age="1",team="Club Brugge",number="(23)",lastname="Nemec " },new PlayerModel {
 name = "Goran ",age="5",team="Slavia Prague",number=" (2)",lastname="Sankovič " },new PlayerModel {
 name = "Željko ",age="35",team="JEF United Ichihara",number=" (3)",lastname="Milinovič " },new PlayerModel {
 name = "Muamer ",age="13",team="Maribor",number=" (4)",lastname="Vugdalič " },new PlayerModel {
 name = "Marinko ",age="65",team="Koper",number=" (5)",lastname="Galič " },new PlayerModel {
 name = "Aleksander ",age="38",team="1. FC Kaiserslautern",number=" (6)",lastname="Knavs " },new PlayerModel {
 name = "Saša ",age="20",team="Gent",number="(14)",lastname="Gajser " },new PlayerModel {
 name = "Amir ",age="43",team="Maribor",number="(19)",lastname="Karić " },new PlayerModel {
 name = "Spasoje ",age="15",team="1. FC Köln",number="(22)",lastname="Bulajič " },new PlayerModel {
 name = "Džoni ",age="68",team="SpVgg Unterhaching",number=" (7)",lastname="Novak " },new PlayerModel {
 name = "Aleš ",age="71",team="Grazer",number=" (8)",lastname="Čeh " },new PlayerModel {
 name = "Zlatko ",age="64",team="Benfica",number="(10)",lastname="Zahovič " },new PlayerModel {
 name = "Miran ",age="45",team="Porto",number="(11)",lastname="Pavlin " },new PlayerModel {
 name = "Rajko ",age="6",team="1. FC Nürnberg",number="(15)",lastname="Tavčar " },new PlayerModel {
 name = "Zoran ",age="21",team="Austria Wien",number="(17)",lastname="Pavlović " },new PlayerModel {
 name = "Nastja ",age="6",team="Club Brugge",number="(20)",lastname="Čeh " },new PlayerModel {
 name = "Milan ",age="41",team="Hapoel Tel Aviv",number=" (9)",lastname="Osterc " },new PlayerModel {
 name = "Mladen ",age="58",team="Portsmouth",number="(13)",lastname="Rudonja " },new PlayerModel {
 name = "Senad ",age="3",team="Olimpija Ljubljana",number="(16)",lastname="Tiganj " },new PlayerModel {
 name = "Milenko ",age="39",team="Tottenham Hotspur",number="(18)",lastname="Ačimovič " },new PlayerModel {
 name = "Sebastjan ",age="12",team="Lecce",number="(21)",lastname="Cimirotič " }}},{
"sn-senegal",new List<PlayerModel>{
new PlayerModel {
 name = "Tony ",age="15",team="AS Monaco",number="(1)",lastname="Sylva " },new PlayerModel {
 name = "Omar ",age="42",team="Olympique Khouribga",number="(16)",lastname="Diallo " },new PlayerModel {
 name = "Kalidou ",age="0",team="ASC Jeanne d'Arc",number="(22)",lastname="Cissokho " },new PlayerModel {
 name = "Omar ",age="31",team="Sochaux",number=" (2)",lastname="Daf " },new PlayerModel {
 name = "Papa ",age="25",team="Lorient",number=" (4)",lastname="Malick " },new PlayerModel {
 name = "Alassane ",age="7",team="Saint-Étienne",number=" (5)",lastname="N'Dour " },new PlayerModel {
 name = "Aliou ",age="20",team="Montpellier",number=" (6)",lastname="Cissé " },new PlayerModel {
 name = "Lamine ",age="19",team="Rennes",number="(13)",lastname="Diatta " },new PlayerModel {
 name = "Ferdinand ",age="16",team="Lens",number="(17)",lastname="Coly " },new PlayerModel {
 name = "Habib ",age="6",team="Strasbourg",number="(21)",lastname="Beye " },new PlayerModel {
 name = "Pape ",age="22",team="Lens",number=" (3)",lastname="Sarr " },new PlayerModel {
 name = "Khalilou ",age="25",team="Auxerre",number="(10)",lastname="Fadiga " },new PlayerModel {
 name = "Amdy ",age="6",team="Auxerre",number="(12)",lastname="Faye " },new PlayerModel {
 name = "Moussa ",age="38",team="Sedan",number="(14)",lastname="N'Diaye " },new PlayerModel {
 name = "Salif ",age="20",team="Sedan",number="(15)",lastname="Diao " },new PlayerModel {
 name = "Papa ",age="12",team="Lens",number="(19)",lastname="Bouba " },new PlayerModel {
 name = "Sylvain ",age="6",team="Lille",number="(20)",lastname="N'Diaye " },new PlayerModel {
 name = "Makhtar ",age="11",team="Rennes",number="(23)",lastname="N'Diaye " },new PlayerModel {
 name = "Henri ",age="34",team="Sedan",number=" (7)",lastname="Camara " },new PlayerModel {
 name = "Amara ",age="12",team="Gueugnon",number=" (8)",lastname="Traoré " },new PlayerModel {
 name = "Souleymane ",age="9",team="AS Monaco",number=" (9)",lastname="Camara " },new PlayerModel {
 name = "El ",age="21",team="Lens",number="(11)",lastname="Hadji " },new PlayerModel {
 name = "Pape ",age="13",team="Strasbourg",number="(18)",lastname="Thiaw " }}},{
"tn-tunisia",new List<PlayerModel>{
new PlayerModel {
 name = "Ali ",age="14",team="Bastia",number="(1)",lastname="Boumnijel " },new PlayerModel {
 name = "Hassen ",age="2",team="Bizertin",number="(16)",lastname="Bejaoui " },new PlayerModel {
 name = "Ahmed ",age="0",team="Monastir",number="(22)",lastname="Jaouachi " },new PlayerModel {
 name = "Khaled ",age="72",team="Espérance",number=" (2)",lastname="Badra " },new PlayerModel {
 name = "Mohamed ",age="15",team="ES Sahel",number=" (4)",lastname="Mkacher " },new PlayerModel {
 name = "Hatem ",age="27",team="Ajax",number=" (6)",lastname="Trabelsi " },new PlayerModel {
 name = "Raouf ",age="39",team="Genoa",number="(12)",lastname="Bouzaiene " },new PlayerModel {
 name = "Hamdi ",age="7",team="Club Africain",number="(14)",lastname="Marzouki " },new PlayerModel {
 name = "Radhi ",age="40",team="Espérance",number="(15)",lastname="Jaïdi " },new PlayerModel {
 name = "Tarek ",age="70",team="Espérance",number="(17)",lastname="Thabet " },new PlayerModel {
 name = "Emir ",age="9",team="ES Sahel",number="(19)",lastname="Mkademi " },new PlayerModel {
 name = "José ",age="12",team="Espérance",number="(23)",lastname="Clayton " },new PlayerModel {
 name = "Zoubeir ",age="77",team="Beşiktaş",number=" (3)",lastname="Baya " },new PlayerModel {
 name = "Imed ",age="30",team="Genoa",number=" (7)",lastname="Mhedhebi " },new PlayerModel {
 name = "Hassen ",age="48",team="Genoa",number=" (8)",lastname="Gabsi " },new PlayerModel {
 name = "Kaies ",age="62",team="ES Sahel",number="(10)",lastname="Ghodhbane " },new PlayerModel {
 name = "Riadh ",age="47",team="Bursaspor",number="(13)",lastname="Bouazizi " },new PlayerModel {
 name = "Selim ",age="3",team="Martigues",number="(18)",lastname="Ben " },new PlayerModel {
 name = "Mourad ",age="11",team="Espérance",number="(21)",lastname="Melki " },new PlayerModel {
 name = "Ziad ",age="26",team="ES Sahel",number=" (5)",lastname="Jaziri " },new PlayerModel {
 name = "Riadh ",age="20",team="Club Africain",number=" (9)",lastname="Jelassi " },new PlayerModel {
 name = "Adel ",age="64",team="SC Freiburg",number="(11)",lastname="Sellimi " },new PlayerModel {
 name = "Ali ",age="23",team="Espérance",number="(20)",lastname="Zitouni " }}},{
"tr-turkey",new List<PlayerModel>{
new PlayerModel {
 name = "Rüştü ",age="64",team="Fenerbahçe",number="(1)",lastname="Reçber " },new PlayerModel {
 name = "Ömer ",age="6",team="Gaziantepspor",number="(12)",lastname="Çatkıç " },new PlayerModel {
 name = "Zafer ",age="1",team="Ankaragücü",number="(23)",lastname="Özgültekin " },new PlayerModel {
 name = "Emre ",age="16",team="Galatasaray",number=" (2)",lastname="Aşık " },new PlayerModel {
 name = "Bülent ",age="68",team="Galatasaray",number=" (3)",lastname="Korkmaz " },new PlayerModel {
 name = "Fatih ",age="36",team="Fenerbahçe",number=" (4)",lastname="Akyel " },new PlayerModel {
 name = "Alpay ",age="62",team="Aston Villa",number=" (5)",lastname="Özalan " },new PlayerModel {
 name = "Ümit ",age="14",team="Fenerbahçe",number="(16)",lastname="Özat " },new PlayerModel {
 name = "Hakan ",age="25",team="Galatasaray",number="(20)",lastname="Ünsal " },new PlayerModel {
 name = "Okan ",age="26",team="Internazionale",number=" (7)",lastname="Buruk " },new PlayerModel {
 name = "Tugay ",age="69",team="Blackburn Rovers",number=" (8)",lastname="Kerimoğlu " },new PlayerModel {
 name = "Yıldıray ",age="13",team="Bayer Leverkusen",number="(10)",lastname="Baştürk " },new PlayerModel {
 name = "Mustafa ",age="7",team="Leicester City",number="(13)",lastname="İzzet " },new PlayerModel {
 name = "Tayfur ",age="39",team="Beşiktaş",number="(14)",lastname="Havutçu " },new PlayerModel {
 name = "Ergün ",age="21",team="Galatasaray",number="(18)",lastname="Penbe " },new PlayerModel {
 name = "Abdullah ",age="70",team="Fenerbahçe",number="(19)",lastname="Ercan " },new PlayerModel {
 name = "Emre ",age="11",team="Internazionale",number="(21)",lastname="Belözoğlu " },new PlayerModel {
 name = "Arif ",age="50",team="Galatasaray",number=" (6)",lastname="Erdem " },new PlayerModel {
 name = "Hakan ",age="73",team="Parma",number=" (9)",lastname="Şükür " },new PlayerModel {
 name = "Hasan ",age="14",team="Galatasaray",number="(11)",lastname="Şaş " },new PlayerModel {
 name = "Nihat ",age="11",team="Real Sociedad",number="(15)",lastname="Kahveci " },new PlayerModel {
 name = "İlhan ",age="6",team="Beşiktaş",number="(17)",lastname="Mansız " }}},{
"us-united-states",new List<PlayerModel>{
new PlayerModel {
 name = "Brad ",age="74",team="Blackburn Rovers",number="(1)",lastname="Friedel " },new PlayerModel {
 name = "Kasey ",age="58",team="Tottenham Hotspur",number="(18)",lastname="Keller " },new PlayerModel {
 name = "Tony ",age="98",team="Kansas City Wizards (USA)",number="(19)",lastname="Meola " },new PlayerModel {
 name = "Gregg ",age="25",team="Crystal Palace",number=" (3)",lastname="Berhalter " },new PlayerModel {
 name = "Pablo ",age="8",team="Miami Fusion (USA)",number=" (4)",lastname="Mastroeni " },new PlayerModel {
 name = "David ",age="28",team="Metz",number=" (6)",lastname="Regis " },new PlayerModel {
 name = "Jeff ",age="127",team="San Jose Earthquakes (USA)",number="(12)",lastname="Agoos " },new PlayerModel {
 name = "Steve ",age="10",team="Hannover 96",number="(14)",lastname="Cherundolo " },new PlayerModel {
 name = "Carlos ",age="26",team="New England Revolution (USA)",number="(16)",lastname="Llamosa " },new PlayerModel {
 name = "Tony ",age="29",team="1. FC Nürnberg",number="(22)",lastname="Sanneh " },new PlayerModel {
 name = "Eddie ",age="48",team="D.C. United (USA)",number="(23)",lastname="Pope " },new PlayerModel {
 name = "Frankie ",age="38",team="Bayer Leverkusen",number=" (2)",lastname="Hejduk " },new PlayerModel {
 name = "John ",age="13",team="Ajax",number=" (5)",lastname="O'Brien " },new PlayerModel {
 name = "Eddie ",age="38",team="Fulham",number=" (7)",lastname="Lewis " },new PlayerModel {
 name = "Earnie ",age="77",team="NAC Breda",number=" (8)",lastname="Stewart " },new PlayerModel {
 name = "Claudio ",age="86",team="Sunderland",number="(10)",lastname="Reyna " },new PlayerModel {
 name = "Cobi ",age="153",team="LA Galaxy (USA)",number="(13)",lastname="Jones " },new PlayerModel {
 name = "DaMarcus ",age="9",team="Chicago Fire (USA)",number="(17)",lastname="Beasley " },new PlayerModel {
 name = "Joe-Max ",age="95",team="Everton",number=" (9)",lastname="Moore " },new PlayerModel {
 name = "Clint ",age="19",team="MetroStars (USA)",number="(11)",lastname="Mathis " },new PlayerModel {
 name = "Josh ",age="16",team="Chicago Fire (USA)",number="(15)",lastname="Wolff " },new PlayerModel {
 name = "Brian ",age="58",team="Columbus Crew (USA)",number="(20)",lastname="McBride " },new PlayerModel {
 name = "Landon ",age="20",team="San Jose Earthquakes (USA)",number="(21)",lastname="Donovan " }}},{
"uy-uruguay",new List<PlayerModel>{
new PlayerModel {
 name = "Fabián ",age="35",team="Juventus",number="(1)",lastname="Carini " },new PlayerModel {
 name = "Gustavo ",age="9",team="Nacional",number="(12)",lastname="Munúa " },new PlayerModel {
 name = "Federico ",age="1",team="Peñarol",number="(23)",lastname="Elduayen " },new PlayerModel {
 name = "Gustavo ",age="45",team="Nacional",number=" (2)",lastname="Méndez " },new PlayerModel {
 name = "Alejandro ",age="31",team="Nacional",number=" (3)",lastname="Lembo " },new PlayerModel {
 name = "Paolo ",age="45",team="Juventus",number=" (4)",lastname="Montero " },new PlayerModel {
 name = "Darío ",age="21",team="Peñarol",number=" (6)",lastname="Rodríguez " },new PlayerModel {
 name = "Gonzalo ",age="18",team="Internazionale",number="(14)",lastname="Sorondo " },new PlayerModel {
 name = "Joe ",age="9",team="Peñarol",number="(19)",lastname="Bizera " },new PlayerModel {
 name = "Pablo ",age="36",team="Venezia",number=" (5)",lastname="García " },new PlayerModel {
 name = "Gianni ",age="36",team="Roma",number=" (7)",lastname="Guigou " },new PlayerModel {
 name = "Fabián ",age="19",team="Perugia",number="(10)",lastname="O'Neill " },new PlayerModel {
 name = "Marcelo ",age="22",team="Málaga",number="(16)",lastname="Romero " },new PlayerModel {
 name = "Mario ",age="14",team="Racing de Santander",number="(17)",lastname="Regueiro " },new PlayerModel {
 name = "Gonzalo ",age="28",team="Valencia",number="(22)",lastname="de " },new PlayerModel {
 name = "Gustavo ",age="7",team="Nacional",number=" (8)",lastname="Varela " },new PlayerModel {
 name = "Darío ",age="36",team="Málaga",number=" (9)",lastname="Silva " },new PlayerModel {
 name = "Federico ",age="24",team="Venezia",number="(11)",lastname="Magallanes " },new PlayerModel {
 name = "Sebastián ",age="13",team="Cruz Azul",number="(13)",lastname="Abreu " },new PlayerModel {
 name = "Nicolás ",age="26",team="Sevilla",number="(15)",lastname="Olivera " },new PlayerModel {
 name = "Richard ",age="12",team="Nacional",number="(18)",lastname="Morales " },new PlayerModel {
 name = "Álvaro ",age="43",team="Internazionale",number="(20)",lastname="Recoba " },new PlayerModel {
 name = "Diego ",age="4",team="Manchester United",number="(21)",lastname="Forlán " }
 }
 }
 });
            squads.Add("2006",new Dictionary<string, List<PlayerModel>>{
           {
           "za-south-africa",new List<PlayerModel>{
           new PlayerModel {
            name = "Hans ",age="29",team="Heerenveen",number="(1)",lastname="Vonk " },new PlayerModel {
            name = "André ",age="49",team="Santos Cape Town",number="(16)",lastname="Arendse " },new PlayerModel {
            name = "Calvin ",age="2",team="Ajax Cape Town",number="(20)",lastname="Marlin " },new PlayerModel {
            name = "Cyril ",age="19",team="Kaizer Chiefs",number=" (2)",lastname="Nzama " },new PlayerModel {
            name = "Bradley ",age="21",team="VfB Stuttgart",number=" (3)",lastname="Carnell " },new PlayerModel {
            name = "Aaron ",age="22",team="Germinal Beerschot",number=" (4)",lastname="Mokoena " },new PlayerModel {
            name = "Jacob ",age="15",team="Lokomotiv Moscow",number=" (5)",lastname="Lekgetho " },new PlayerModel {
            name = "Pierre ",age="41",team="Watford",number="(13)",lastname="Issa " },new PlayerModel {
            name = "Lucas ",age="65",team="Leeds United",number="(19)",lastname="Radebe " },new PlayerModel {
            name = "Thabang ",age="5",team="Jomo Cosmos",number="(22)",lastname="Molefe " },new PlayerModel {
            name = "MacBeth ",age="9",team="Jomo Cosmos",number=" (6)",lastname="Sibaya " },new PlayerModel {
            name = "Quinton ",age="39",team="Manchester United",number=" (7)",lastname="Fortune " },new PlayerModel {
            name = "Thabo ",age="37",team="Orlando Pirates",number=" (8)",lastname="Mngomeni " },new PlayerModel {
            name = "MacDonald ",age="7",team="Lokomotiv Sofia",number=" (9)",lastname="Mukansi " },new PlayerModel {
            name = "Bennett ",age="9",team="Lokomotiv Moscow",number="(10)",lastname="Mnguni " },new PlayerModel {
            name = "Jabu ",age="9",team="Kaizer Chiefs",number="(11)",lastname="Pule " },new PlayerModel {
            name = "Teboho ",age="10",team="St. Gallen",number="(12)",lastname="Mokoena " },new PlayerModel {
            name = "Sibusiso ",age="22",team="Copenhagen",number="(15)",lastname="Zuma " },new PlayerModel {
            name = "Delron ",age="32",team="VfL Bochum",number="(18)",lastname="Buckley " },new PlayerModel {
            name = "Steven ",age="0",team="Ajax",number="(21)",lastname="Pienaar " },new PlayerModel {
            name = "Siyabonga ",age="30",team="Udinese",number="(14)",lastname="Nomvethe " },new PlayerModel {
            name = "Benni ",age="43",team="Porto",number="(17)",lastname="McCarthy " },new PlayerModel {
            name = "George ",age="6",team="Basel",number="(23)",lastname="Koumantarakis " }}} ,
            {
           "ao-angola",new List<PlayerModel>{
           new PlayerModel {
            name = "João ",age="26",team="Moreirense",number="(1)",lastname="Ricardo " },new PlayerModel {
            name = "Lamá ",age="9",team="Petro Atletico (ANG)",number="(12)",lastname="## " },new PlayerModel {
            name = "Mário ",age="1",team="InterClube (ANG)",number="(22)",lastname="## " },new PlayerModel {
            name = "Marco ",age="2",team="Barreirense (POR)",number=" (2)",lastname="Airosa " },new PlayerModel {
            name = "Jamba ",age="35",team="Aviação (ANG)",number=" (3)",lastname="## " },new PlayerModel {
            name = "Lebo ",age="15",team="Petro Atletico (ANG)",number=" (4)",lastname="## " },new PlayerModel {
            name = "Kali ",age="21",team="Barreirense (POR)",number=" (5)",lastname="## " },new PlayerModel {
            name = "Rui ",age="1",team="Leeds United (ENG)",number="(15)",lastname="Marques " },new PlayerModel {
            name = "Locó ",age="11",team="Primeiro Agosto (ANG)",number="(20)",lastname="## " },new PlayerModel {
            name = "Delgado ",age="17",team="Petro Atletico (ANG)",number="(21)",lastname="## " },new PlayerModel {
            name = "Marco ",age="3",team="Portimonense (POR)",number="(23)",lastname="Abreu " },new PlayerModel {
            name = "Miloy ",age="11",team="InterClube (ANG)",number=" (6)",lastname="## " },new PlayerModel {
            name = "Figueiredo ",age="22",team="Varzim (POR)",number=" (7)",lastname="## " },new PlayerModel {
            name = "André ",age="33",team="Al-Salmiya (KUW)",number=" (8)",lastname="## " },new PlayerModel {
            name = "Édson ",age="7",team="Paços de Ferreira (POR)",number="(13)",lastname="## " },new PlayerModel {
            name = "Mendonça ",age="34",team="Varzim (POR)",number="(14)",lastname="## " },new PlayerModel {
            name = "Zé ",age="23",team="Petro Atletico (ANG)",number="(17)",lastname="Kalanga " },new PlayerModel {
            name = "Mantorras ",age="11",team="Benfica (POR)",number=" (9)",lastname="## " },new PlayerModel {
            name = "Akwá ",age="77",team="Al-Wakra (QAT)",number="(10)",lastname="## " },new PlayerModel {
            name = "Mateus ",age="4",team="Gil Vicente (POR)",number="(11)",lastname="## " },new PlayerModel {
            name = "Flávio ",age="46",team="Al-Ahly (EGY)",number="(16)",lastname="## " },new PlayerModel {
            name = "Love ",age="35",team="Aviação (ANG)",number="(18)",lastname="## " },new PlayerModel {
            name = "Titi ",age="2",team="Clermont Foot (FRA)",number="(19)",lastname="Buengo " }}},
            {
           "ar-argentina",new List<PlayerModel>{
           new PlayerModel {
            name = "Roberto ",age="22",team="Boca Juniors (ARG)",number="(1)",lastname="Abbondanzieri " },new PlayerModel {
            name = "Leo ",age="3",team="Atlético Madrid (ESP)",number="(12)",lastname="Franco " },new PlayerModel {
            name = "Óscar ",age="0",team="Independiente (ARG)",number="(23)",lastname="Ustari " },new PlayerModel {
            name = "Roberto ",age="100",team="Valencia (ESP)",number=" (2)",lastname="Ayala " },new PlayerModel {
            name = "Juan ",age="71",team="Villarreal (ESP)",number=" (3)",lastname="Pablo " },new PlayerModel {
            name = "Fabricio ",age="23",team="Deportivo La Coruña (ESP)",number=" (4)",lastname="Coloccini " },new PlayerModel {
            name = "Gabriel ",age="29",team="Manchester United (ENG)",number=" (6)",lastname="Heinze " },new PlayerModel {
            name = "Lionel ",age="6",team="Deportivo La Coruña (ESP)",number="(13)",lastname="Scaloni " },new PlayerModel {
            name = "Gabriel ",age="15",team="Real Zaragoza (ESP)",number="(15)",lastname="Milito " },new PlayerModel {
            name = "Leandro ",age="2",team="Roma (ITA)",number="(17)",lastname="Cufré " },new PlayerModel {
            name = "Nicolás ",age="8",team="Internazionale (ITA)",number="(21)",lastname="Burdisso " },new PlayerModel {
            name = "Esteban ",age="22",team="Internazionale (ITA)",number=" (5)",lastname="Cambiasso " },new PlayerModel {
            name = "Javier ",age="15",team="Corinthians (BRA)",number=" (8)",lastname="Mascherano " },new PlayerModel {
            name = "Juan ",age="31",team="Villarreal (ESP)",number="(10)",lastname="Román " },new PlayerModel {
            name = "Pablo ",age="40",team="Valencia (ESP)",number="(16)",lastname="Aimar " },new PlayerModel {
            name = "Maxi ",age="13",team="Atlético Madrid (ESP)",number="(18)",lastname="Rodríguez " },new PlayerModel {
            name = "Lucho ",age="27",team="Porto (POR)",number="(22)",lastname="González " },new PlayerModel {
            name = "Javier ",age="31",team="Barcelona (ESP)",number=" (7)",lastname="Saviola " },new PlayerModel {
            name = "Hernán ",age="55",team="Chelsea (ENG)",number=" (9)",lastname="Crespo " },new PlayerModel {
            name = "Carlos ",age="21",team="Corinthians (BRA)",number="(11)",lastname="Tevez " },new PlayerModel {
            name = "Rodrigo ",age="2",team="Boca Juniors (ARG)",number="(14)",lastname="Palacio " },new PlayerModel {
            name = "Lionel ",age="7",team="Barcelona (ESP)",number="(19)",lastname="Messi " },new PlayerModel {
            name = "Julio ",age="15",team="Internazionale (ITA)",number="(20)",lastname="Cruz " }}},
            {
           "au-australia",new List<PlayerModel>{
           new PlayerModel {
            name = "Mark ",age="37",team="Middlesbrough (ENG)",number="(1)",lastname="Schwarzer " },new PlayerModel {
            name = "Ante ",age="1",team="Hammarby (SWE)",number="(12)",lastname="Čović " },new PlayerModel {
            name = "Željko ",age="52",team="Milan (ITA)",number="(18)",lastname="Kalac " },new PlayerModel {
            name = "Lucas ",age="25",team="Blackburn Rovers (ENG)",number=" (2)",lastname="Neill " },new PlayerModel {
            name = "Craig ",age="33",team="Newcastle United (ENG)",number=" (3)",lastname="Moore " },new PlayerModel {
            name = "Tony ",age="56",team="Crystal Palace (ENG)",number=" (6)",lastname="Popovic " },new PlayerModel {
            name = "Brett ",age="48",team="Blackburn Rovers (ENG)",number=" (7)",lastname="Emerton " },new PlayerModel {
            name = "Stan ",age="59",team="Birmingham City (ENG)",number="(11)",lastname="Lazaridis " },new PlayerModel {
            name = "Michael ",age="2",team="Central Coast Mariners (AUS)",number="(16)",lastname="Beauchamp " },new PlayerModel {
            name = "Luke ",age="8",team="Bristol City (ENG)",number="(20)",lastname="Wilkshire " },new PlayerModel {
            name = "Mark ",age="1",team="Sydney FC (AUS)",number="(22)",lastname="Milligan " },new PlayerModel {
            name = "Tim ",age="16",team="Everton (ENG)",number=" (4)",lastname="Cahill " },new PlayerModel {
            name = "Jason ",age="13",team="PSV Eindhoven (NED)",number=" (5)",lastname="Čulina " },new PlayerModel {
            name = "Josip ",age="46",team="Wigan Athletic (ENG)",number=" (8)",lastname="Skoko " },new PlayerModel {
            name = "Vincenzo ",age="17",team="Parma (ITA)",number="(13)",lastname="Grella " },new PlayerModel {
            name = "Scott ",age="46",team="Basel (SUI)",number="(14)",lastname="Chipperfield " },new PlayerModel {
            name = "Mile ",age="22",team="Basel (SUI)",number="(21)",lastname="Sterjovski " },new PlayerModel {
            name = "Mark ",age="24",team="Parma (ITA)",number="(23)",lastname="Bresciano " },new PlayerModel {
            name = "Mark ",age="33",team="Middlesbrough (ENG)",number=" (9)",lastname="Viduka " },new PlayerModel {
            name = "Harry ",age="20",team="Liverpool (ENG)",number="(10)",lastname="Kewell " },new PlayerModel {
            name = "John ",age="41",team="Alavés (ESP)",number="(15)",lastname="Aloisi " },new PlayerModel {
            name = "Archie ",age="20",team="Melbourne Victory (AUS)",number="(17)",lastname="Thompson " },new PlayerModel {
            name = "Joshua ",age="1",team="Dynamo Dresden (GER)",number="(19)",lastname="Kennedy " }}},
            {
           "br-brazil",new List<PlayerModel>{
           new PlayerModel {
            name = "Dida ",age="86",team="Milan (ITA)",number="(1)",lastname="## " },new PlayerModel {
            name = "Rogério ",age="15",team="São Paulo (BRA)",number="(12)",lastname="Ceni " },new PlayerModel {
            name = "Júlio ",age="11",team="Internazionale (ITA)",number="(22)",lastname="César " },new PlayerModel {
            name = "Cafu ",age="138",team="Milan (ITA)",number=" (2)",lastname="## " },new PlayerModel {
            name = "Lúcio ",age="50",team="Bayern Munich (GER)",number=" (3)",lastname="## " },new PlayerModel {
            name = "Juan ",age="38",team="Bayer Leverkusen (GER)",number=" (4)",lastname="## " },new PlayerModel {
            name = "Roberto ",age="121",team="Real Madrid (ESP)",number=" (6)",lastname="Carlos " },new PlayerModel {
            name = "Cicinho ",age="10",team="Real Madrid (ESP)",number="(13)",lastname="## " },new PlayerModel {
            name = "Luisão ",age="19",team="Benfica (POR)",number="(14)",lastname="## " },new PlayerModel {
            name = "Cris ",age="16",team="Lyon (FRA)",number="(15)",lastname="## " },new PlayerModel {
            name = "Gilberto ",age="9",team="Hertha BSC (GER)",number="(16)",lastname="## " },new PlayerModel {
            name = "Emerson ",age="70",team="Juventus (ITA)",number=" (5)",lastname="## " },new PlayerModel {
            name = "Kaká ",age="38",team="Milan (ITA)",number=" (8)",lastname="## " },new PlayerModel {
            name = "Ronaldinho ",age="63",team="Barcelona (ESP)",number="(10)",lastname="## " },new PlayerModel {
            name = "Zé ",age="79",team="Bayern Munich (GER)",number="(11)",lastname="Roberto " },new PlayerModel {
            name = "Gilberto ",age="36",team="Arsenal (ENG)",number="(17)",lastname="Silva " },new PlayerModel {
            name = "Mineiro ",age="2",team="São Paulo (BRA)",number="(18)",lastname="## " },new PlayerModel {
            name = "Juninho ",age="37",team="Lyon (FRA)",number="(19)",lastname="## " },new PlayerModel {
            name = "Ricardinho ",age="19",team="Corinthians (BRA)",number="(20)",lastname="## " },new PlayerModel {
            name = "Adriano ",age="32",team="Internazionale (ITA)",number=" (7)",lastname="## " },new PlayerModel {
            name = "Ronaldo ",age="92",team="Real Madrid (ESP)",number=" (9)",lastname="## " },new PlayerModel {
            name = "Fred ",age="3",team="Lyon (FRA)",number="(21)",lastname="## " },new PlayerModel {
            name = "Robinho ",age="23",team="Real Madrid (ESP)",number="(23)",lastname="## " }}},
            {
           "ch-switzerland",new List<PlayerModel>{
           new PlayerModel {
            name = "Pascal ",age="40",team="Basel (SUI)",number="(1)",lastname="Zuberbühler " },new PlayerModel {
            name = "Diego ",age="1",team="Nacional (POR)",number="(12)",lastname="Benaglio " },new PlayerModel {
            name = "Fabio ",age="2",team="Grasshopper (SUI)",number="(21)",lastname="Coltorti " },new PlayerModel {
            name = "Ludovic ",age="30",team="Stuttgart (GER)",number=" (3)",lastname="Magnin " },new PlayerModel {
            name = "Philippe ",age="12",team="Arsenal (ENG)",number=" (4)",lastname="Senderos " },new PlayerModel {
            name = "Raphaël ",age="67",team="Hamburg (GER)",number=" (8)",lastname="Wicky " },new PlayerModel {
            name = "Stéphane ",age="6",team="Auxerre (FRA)",number="(13)",lastname="Grichting " },new PlayerModel {
            name = "Christoph ",age="21",team="Eintracht Frankfurt (GER)",number="(17)",lastname="Spycher " },new PlayerModel {
            name = "Patrick ",age="64",team="Lyon (FRA)",number="(20)",lastname="Müller " },new PlayerModel {
            name = "Philipp ",age="15",team="Borussia Dortmund (GER)",number="(23)",lastname="Degen " },new PlayerModel {
            name = "Johan ",age="2",team="Arsenal (ENG)",number=" (2)",lastname="Djourou " },new PlayerModel {
            name = "Xavier ",age="3",team="Zürich (SUI)",number=" (5)",lastname="Margairaz " },new PlayerModel {
            name = "Johann ",age="85",team="Milan (ITA)",number=" (6)",lastname="Vogel " },new PlayerModel {
            name = "Ricardo ",age="37",team="Köln (GER)",number=" (7)",lastname="Cabanas " },new PlayerModel {
            name = "David ",age="3",team="Basel (SUI)",number="(14)",lastname="Degen " },new PlayerModel {
            name = "Blerim ",age="3",team="Zürich (SUI)",number="(15)",lastname="Džemaili " },new PlayerModel {
            name = "Tranquillo ",age="13",team="Bayer Leverkusen (GER)",number="(16)",lastname="Barnetta " },new PlayerModel {
            name = "Valon ",age="6",team="Lazio (ITA)",number="(19)",lastname="Behrami " },new PlayerModel {
            name = "Alexander ",age="45",team="Rennes (FRA)",number=" (9)",lastname="Frei " },new PlayerModel {
            name = "Daniel ",age="22",team="Lille (FRA)",number="(10)",lastname="Gygax " },new PlayerModel {
            name = "Marco ",age="10",team="Köln (GER)",number="(11)",lastname="Streller " },new PlayerModel {
            name = "Mauro ",age="5",team="Sparta Prague (CZE)",number="(18)",lastname="Lustrinelli " },new PlayerModel {
            name = "Hakan ",age="46",team="Young Boys (SUI)",number="(22)",lastname="Yakın " }}},
            {
           "ci-cote-d-ivoire",new List<PlayerModel>{
           new PlayerModel {
            name = "Jean-Jacques ",age="24",team="Espérance (TUN)",number="(1)",lastname="Tizié " },new PlayerModel {
            name = "Gérard ",age="6",team="Montpellier (FRA)",number="(16)",lastname="Gnanhouan " },new PlayerModel {
            name = "Boubacar ",age="6",team="Beveren (BEL)",number="(23)",lastname="Barry " },new PlayerModel {
            name = "Arthur ",age="23",team="Strasbourg (FRA)",number=" (3)",lastname="Boka " },new PlayerModel {
            name = "Kolo ",age="42",team="Arsenal (ENG)",number=" (4)",lastname="Touré " },new PlayerModel {
            name = "Blaise ",age="36",team="Troyes (FRA)",number=" (6)",lastname="Kouassi " },new PlayerModel {
            name = "Abdoulaye ",age="18",team="Marseille (FRA)",number="(12)",lastname="Méïté " },new PlayerModel {
            name = "Marco ",age="13",team="Messina (ITA)",number="(13)",lastname="Zoro " },new PlayerModel {
            name = "Cyril ",age="50",team="Créteil (FRA)",number="(17)",lastname="Domoraud " },new PlayerModel {
            name = "Guy ",age="7",team="Hamburg (GER)",number="(20)",lastname="Demel " },new PlayerModel {
            name = "Emmanuel ",age="11",team="Arsenal (ENG)",number="(21)",lastname="Eboué " },new PlayerModel {
            name = "Kanga ",age="22",team="Auxerre (FRA)",number=" (2)",lastname="Akalé " },new PlayerModel {
            name = "Didier ",age="38",team="Saint-Étienne (FRA)",number=" (5)",lastname="Zokora " },new PlayerModel {
            name = "Emerse ",age="14",team="Nantes (FRA)",number=" (7)",lastname="Faé " },new PlayerModel {
            name = "Gilles ",age="26",team="Young Boys (SUI)",number="(10)",lastname="Yapi " },new PlayerModel {
            name = "Abdul ",age="26",team="Lille (FRA)",number="(18)",lastname="Kader " },new PlayerModel {
            name = "Yaya ",age="14",team="Olympiacos (GRE)",number="(19)",lastname="Touré " },new PlayerModel {
            name = "Romaric ",age="8",team="Le Mans (FRA)",number="(22)",lastname="## " },new PlayerModel {
            name = "Bonaventure ",age="49",team="Paris Saint-Germain (FRA)",number=" (8)",lastname="Kalou " },new PlayerModel {
            name = "Arouna ",age="17",team="PSV Eindhoven (NED)",number=" (9)",lastname="Koné " },new PlayerModel {
            name = "Didier ",age="32",team="Chelsea (ENG)",number="(11)",lastname="Drogba " },new PlayerModel {
            name = "Bakari ",age="16",team="Nice (FRA)",number="(14)",lastname="Koné " },new PlayerModel {
            name = "Aruna ",age="34",team="Lens (FRA)",number="(15)",lastname="Dindane " }}},
            {
           "cr-costa-rica",new List<PlayerModel>{
           new PlayerModel {
            name = "Álvaro ",age="38",team="Herediano (CRC)",number=" (1)",lastname="Mesén " },new PlayerModel {
            name = "José ",age="16",team="Deportivo Saprissa (CRC)",number="(18)",lastname="Porras " },new PlayerModel {
            name = "Wardy ",age="2",team="Alajuelense (CRC)",number="(23)",lastname="Alfaro " },new PlayerModel {
            name = "Jervis ",age="56",team="Deportivo Saprissa (CRC)",number=" (2)",lastname="Drummond " },new PlayerModel {
            name = "Luis ",age="120",team="Alajuelense (CRC)",number=" (3)",lastname="Marín " },new PlayerModel {
            name = "Michael ",age="18",team="Brujas (CRC)",number=" (4)",lastname="Umaña " },new PlayerModel {
            name = "Gilberto ",age="57",team="Brescia (ITA)",number=" (5)",lastname="Martínez " },new PlayerModel {
            name = "Leonardo ",age="36",team="Herediano (CRC)",number="(12)",lastname="González " },new PlayerModel {
            name = "Harold ",age="78",team="Alajuelense (CRC)",number="(15)",lastname="Wallace " },new PlayerModel {
            name = "Gabriel ",age="7",team="Deportivo Saprissa (CRC)",number="(17)",lastname="Badilla " },new PlayerModel {
            name = "Michael ",age="3",team="Alajuelense (CRC)",number="(22)",lastname="Rodríguez " },new PlayerModel {
            name = "Danny ",age="22",team="Cartaginés (CRC)",number=" (6)",lastname="Fonseca " },new PlayerModel {
            name = "Christian ",age="16",team="Deportivo Saprissa (CRC)",number=" (7)",lastname="Bolaños " },new PlayerModel {
            name = "Mauricio ",age="107",team="CSD Comunicaciones (GUA)",number=" (8)",lastname="Solís " },new PlayerModel {
            name = "Walter ",age="93",team="Deportivo Saprissa (CRC)",number="(10)",lastname="Centeno " },new PlayerModel {
            name = "Randall ",age="5",team="Deportivo Saprissa (CRC)",number="(14)",lastname="Azofeifa " },new PlayerModel {
            name = "Carlos ",age="17",team="Alajuelense (CRC)",number="(16)",lastname="Hernández " },new PlayerModel {
            name = "Douglas ",age="29",team="Real Salt Lake (USA)",number="(20)",lastname="Sequeira " },new PlayerModel {
            name = "Paulo ",age="69",team="Herediano (CRC)",number=" (9)",lastname="Wanchope " },new PlayerModel {
            name = "Rónald ",age="80",team="Deportivo Saprissa (CRC)",number="(11)",lastname="Gómez " },new PlayerModel {
            name = "Kurt ",age="3",team="Puntarenas (CRC)",number="(13)",lastname="Bernard " },new PlayerModel {
            name = "Álvaro ",age="23",team="Deportivo Saprissa (CRC)",number="(19)",lastname="Saborío " },new PlayerModel {
            name = "Victor ",age="3",team="Cartaginés (CRC)",number="(21)",lastname="Núñez " }}},
            {
           "cz-czech-republic",new List<PlayerModel>{
           new PlayerModel {
            name = "Petr ",age="41",team="Chelsea (ENG)",number="(1)",lastname="Čech " },new PlayerModel {
            name = "Jaromír ",age="11",team="Sparta Prague (CZE)",number="(16)",lastname="Blažek " },new PlayerModel {
            name = "Antonín ",age="5",team="Saturn Ramenskoye (RUS)",number="(23)",lastname="Kinský " },new PlayerModel {
            name = "Zdeněk ",age="41",team="Ajax (NED)",number=" (2)",lastname="Grygera " },new PlayerModel {
            name = "Pavel ",age="10",team="Zenit St. Petersburg (RUS)",number=" (3)",lastname="Mareš " },new PlayerModel {
            name = "Radoslav ",age="6",team="Spartak Moscow (RUS)",number=" (5)",lastname="Kováč " },new PlayerModel {
            name = "Marek ",age="48",team="Milan (ITA)",number=" (6)",lastname="Jankulovski " },new PlayerModel {
            name = "Martin ",age="24",team="Spartak Moscow (RUS)",number="(13)",lastname="Jiránek " },new PlayerModel {
            name = "Tomáš ",age="48",team="Fiorentina (ITA)",number="(21)",lastname="Ujfaluši " },new PlayerModel {
            name = "David ",age="22",team="Paris Saint-Germain (FRA)",number="(22)",lastname="Rozehnal " },new PlayerModel {
            name = "Tomáš ",age="49",team="Ajax (NED)",number=" (4)",lastname="Galásek " },new PlayerModel {
            name = "Libor ",age="17",team="Austria Wien (AUT)",number=" (7)",lastname="Sionko " },new PlayerModel {
            name = "Karel ",age="115",team="Dynamo České Budějovice (CZE)",number=" (8)",lastname="Poborský " },new PlayerModel {
            name = "Tomáš ",age="54",team="Borussia Dortmund (GER)",number="(10)",lastname="Rosický " },new PlayerModel {
            name = "Pavel ",age="87",team="Juventus (ITA)",number="(11)",lastname="Nedvěd " },new PlayerModel {
            name = "David ",age="3",team="Hamburg (GER)",number="(14)",lastname="Jarolím " },new PlayerModel {
            name = "Jan ",age="18",team="Nuremberg (GER)",number="(19)",lastname="Polák " },new PlayerModel {
            name = "Jaroslav ",age="14",team="AS Monaco (FRA)",number="(20)",lastname="Plašil " },new PlayerModel {
            name = "Jan ",age="68",team="Borussia Dortmund (GER)",number=" (9)",lastname="Koller " },new PlayerModel {
            name = "Vratislav ",age="72",team="Red Bull Salzburg (AUT)",number="(12)",lastname="Lokvenc " },new PlayerModel {
            name = "Milan ",age="49",team="Aston Villa (ENG)",number="(15)",lastname="Baroš " },new PlayerModel {
            name = "Jiří ",age="21",team="Hannover 96 (GER)",number="(17)",lastname="Štajner " },new PlayerModel {
            name = "Marek ",age="28",team="Galatasaray (TUR)",number="(18)",lastname="Heinz " }}},
            {
           "de-deutschland",new List<PlayerModel>{
           new PlayerModel {
            name = "Jens ",age="32",team="Arsenal (ENG)",number="(1)",lastname="Lehmann " },new PlayerModel {
            name = "Oliver ",age="85",team="Bayern Munich (GER)",number="(12)",lastname="Kahn " },new PlayerModel {
            name = "Timo ",age="3",team="Stuttgart (GER)",number="(23)",lastname="Hildebrand " },new PlayerModel {
            name = "Marcell ",age="7",team="Borussia Mönchengladbach (GER)",number=" (2)",lastname="Jansen " },new PlayerModel {
            name = "Arne ",age="36",team="Hertha BSC (GER)",number=" (3)",lastname="Friedrich " },new PlayerModel {
            name = "Robert ",age="16",team="Chelsea (ENG)",number=" (4)",lastname="Huth " },new PlayerModel {
            name = "Jens ",age="46",team="Bayer Leverkusen (GER)",number=" (6)",lastname="Nowotny " },new PlayerModel {
            name = "Philipp ",age="18",team="Bayern Munich (GER)",number="(16)",lastname="Lahm " },new PlayerModel {
            name = "Per ",age="23",team="Hannover 96 (GER)",number="(17)",lastname="Mertesacker " },new PlayerModel {
            name = "Christoph ",age="22",team="Borussia Dortmund (GER)",number="(21)",lastname="Metzelder " },new PlayerModel {
            name = "Sebastian ",age="27",team="Borussia Dortmund (GER)",number=" (5)",lastname="Kehl " },new PlayerModel {
            name = "Bastian ",age="28",team="Bayern Munich (GER)",number=" (7)",lastname="Schweinsteiger " },new PlayerModel {
            name = "Torsten ",age="52",team="Werder Bremen (GER)",number=" (8)",lastname="Frings " },new PlayerModel {
            name = "Michael ",age="65",team="Bayern Munich (GER)",number="(13)",lastname="Ballack " },new PlayerModel {
            name = "Thomas ",age="15",team="Stuttgart (GER)",number="(15)",lastname="Hitzlsperger " },new PlayerModel {
            name = "Tim ",age="20",team="Werder Bremen (GER)",number="(18)",lastname="Borowski " },new PlayerModel {
            name = "Bernd ",age="64",team="Bayer Leverkusen (GER)",number="(19)",lastname="Schneider " },new PlayerModel {
            name = "David ",age="1",team="Borussia Dortmund (GER)",number="(22)",lastname="Odonkor " },new PlayerModel {
            name = "Mike ",age="6",team="Wolfsburg (GER)",number=" (9)",lastname="Hanke " },new PlayerModel {
            name = "Oliver ",age="55",team="Borussia Mönchengladbach (GER)",number="(10)",lastname="Neuville " },new PlayerModel {
            name = "Miroslav ",age="55",team="Werder Bremen (GER)",number="(11)",lastname="Klose " },new PlayerModel {
            name = "Gerald ",age="40",team="Schalke 04 (GER)",number="(14)",lastname="Asamoah " },new PlayerModel {
            name = "Lukas ",age="25",team="Köln (GER)",number="(20)",lastname="Podolski " }}},
            {
           "ec-ecuador",new List<PlayerModel>{
           new PlayerModel {
            name = "Edwin ",age="15",team="Deportivo Quito (ECU)",number="(1)",lastname="Villafuerte " },new PlayerModel {
            name = "Cristian ",age="8",team="LDU Quito (ECU)",number="(12)",lastname="Mora " },new PlayerModel {
            name = "Damián ",age="5",team="Aucas (ECU)",number="(22)",lastname="Lanza " },new PlayerModel {
            name = "Jorge ",age="18",team="El Nacional (ECU)",number=" (2)",lastname="Guagua " },new PlayerModel {
            name = "Iván ",age="130",team="Al-Arabi (QAT)",number=" (3)",lastname="Hurtado " },new PlayerModel {
            name = "Ulises ",age="84",team="Aston Villa (ENG)",number=" (4)",lastname="de " },new PlayerModel {
            name = "José ",age="3",team="Olmedo (ECU)",number=" (5)",lastname="Luis " },new PlayerModel {
            name = "Paul ",age="24",team="LDU Quito (ECU)",number="(13)",lastname="Ambrosi " },new PlayerModel {
            name = "Giovanny ",age="56",team="LDU Quito (ECU)",number="(17)",lastname="Espinoza " },new PlayerModel {
            name = "Néicer ",age="31",team="LDU Quito (ECU)",number="(18)",lastname="Reasco " },new PlayerModel {
            name = "Patricio ",age="6",team="LDU Quito (ECU)",number=" (6)",lastname="Urrutia " },new PlayerModel {
            name = "Christian ",age="19",team="El Nacional (ECU)",number=" (7)",lastname="Lara " },new PlayerModel {
            name = "Edison ",age="64",team="LDU Quito (ECU)",number=" (8)",lastname="Méndez " },new PlayerModel {
            name = "Segundo ",age="11",team="El Nacional (ECU)",number="(14)",lastname="Castillo " },new PlayerModel {
            name = "Marlon ",age="74",team="Deportivo Quito (ECU)",number="(15)",lastname="Ayoví " },new PlayerModel {
            name = "Antonio ",age="17",team="Recreativo (ESP)",number="(16)",lastname="Valencia " },new PlayerModel {
            name = "Luis ",age="15",team="Deportivo Quito (ECU)",number="(19)",lastname="Saritama " },new PlayerModel {
            name = "Edwin ",age="68",team="Barcelona (ECU)",number="(20)",lastname="Tenorio " },new PlayerModel {
            name = "Félix ",age="6",team="El Nacional (ECU)",number=" (9)",lastname="Borja " },new PlayerModel {
            name = "Iván ",age="44",team="Argentinos Juniors (ARG)",number="(10)",lastname="Kaviedes " },new PlayerModel {
            name = "Agustín ",age="68",team="LDU Quito (ECU)",number="(11)",lastname="Delgado " },new PlayerModel {
            name = "Carlos ",age="29",team="Al-Sadd (QAT)",number="(21)",lastname="Tenorio " },new PlayerModel {
            name = "Christian ",age="5",team="El Nacional (ECU)",number="(23)",lastname="Benítez " }}},
            {
           "en-england",new List<PlayerModel>{
           new PlayerModel {
            name = "Paul ",age="21",team="Tottenham Hotspur (ENG)",number="(1)",lastname="Robinson " },new PlayerModel {
            name = "David ",age="34",team="Manchester City (ENG)",number="(13)",lastname="James " },new PlayerModel {
            name = "Scott ",age="0",team="Liverpool (ENG)",number="(22)",lastname="Carson " },new PlayerModel {
            name = "Gary ",age="79",team="Manchester United (ENG)",number=" (2)",lastname="Neville " },new PlayerModel {
            name = "Ashley ",age="46",team="Arsenal (ENG)",number=" (3)",lastname="Cole " },new PlayerModel {
            name = "Rio ",age="47",team="Manchester United (ENG)",number=" (5)",lastname="Ferdinand " },new PlayerModel {
            name = "John ",age="24",team="Chelsea (ENG)",number=" (6)",lastname="Terry " },new PlayerModel {
            name = "Sol ",age="68",team="Arsenal (ENG)",number="(12)",lastname="Campbell " },new PlayerModel {
            name = "Wayne ",age="23",team="Chelsea (ENG)",number="(14)",lastname="Bridge " },new PlayerModel {
            name = "Jamie ",age="25",team="Liverpool (ENG)",number="(15)",lastname="Carragher " },new PlayerModel {
            name = "Steven ",age="42",team="Liverpool (ENG)",number=" (4)",lastname="Gerrard " },new PlayerModel {
            name = "David ",age="89",team="Real Madrid (ESP)",number=" (7)",lastname="Beckham " },new PlayerModel {
            name = "Frank ",age="40",team="Chelsea (ENG)",number=" (8)",lastname="Lampard " },new PlayerModel {
            name = "Joe ",age="32",team="Chelsea (ENG)",number="(11)",lastname="Cole " },new PlayerModel {
            name = "Owen ",age="30",team="Bayern Munich (GER)",number="(16)",lastname="Hargreaves " },new PlayerModel {
            name = "Jermaine ",age="15",team="Tottenham Hotspur (ENG)",number="(17)",lastname="Jenas " },new PlayerModel {
            name = "Michael ",age="6",team="Tottenham Hotspur (ENG)",number="(18)",lastname="Carrick " },new PlayerModel {
            name = "Aaron ",age="1",team="Tottenham Hotspur (ENG)",number="(19)",lastname="Lennon " },new PlayerModel {
            name = "Stewart ",age="2",team="Middlesbrough (ENG)",number="(20)",lastname="Downing " },new PlayerModel {
            name = "Wayne ",age="29",team="Manchester United (ENG)",number=" (9)",lastname="Rooney " },new PlayerModel {
            name = "Michael ",age="77",team="Newcastle United (ENG)",number="(10)",lastname="Owen " },new PlayerModel {
            name = "Peter ",age="7",team="Liverpool (ENG)",number="(21)",lastname="Crouch " },new PlayerModel {
            name = "Theo ",age="1",team="Arsenal (ENG)",number="(23)",lastname="Walcott " }}},
            {
           "es-espana",new List<PlayerModel>{
           new PlayerModel {
            name = "Iker ",age="58",team="Real Madrid (ESP)",number="(1)",lastname="Casillas " },new PlayerModel {
            name = "Santiago ",age="45",team="Valencia (ESP)",number="(19)",lastname="Cañizares " },new PlayerModel {
            name = "Pepe ",age="3",team="Liverpool (ENG)",number="(23)",lastname="Reina " },new PlayerModel {
            name = "Míchel ",age="50",team="Real Madrid (ESP)",number=" (2)",lastname="Salgado " },new PlayerModel {
            name = "Mariano ",age="1",team="Getafe (ESP)",number=" (3)",lastname="Pernía " },new PlayerModel {
            name = "Carlos ",age="27",team="Valencia (ESP)",number=" (4)",lastname="Marchena " },new PlayerModel {
            name = "Carles ",age="47",team="Barcelona (ESP)",number=" (5)",lastname="Puyol " },new PlayerModel {
            name = "Antonio ",age="8",team="Atlético Madrid (ESP)",number="(12)",lastname="López " },new PlayerModel {
            name = "Sergio ",age="11",team="Real Madrid (ESP)",number="(15)",lastname="Ramos " },new PlayerModel {
            name = "Juanito ",age="15",team="Real Betis (ESP)",number="(20)",lastname="## " },new PlayerModel {
            name = "Pablo ",age="11",team="Atlético Madrid (ESP)",number="(22)",lastname="## " },new PlayerModel {
            name = "David ",age="33",team="Valencia (ESP)",number=" (6)",lastname="Albelda " },new PlayerModel {
            name = "Xavi ",age="36",team="Barcelona (ESP)",number=" (8)",lastname="## " },new PlayerModel {
            name = "José ",age="19",team="Arsenal (ENG)",number="(10)",lastname="Antonio " },new PlayerModel {
            name = "Luis ",age="10",team="Liverpool (ENG)",number="(11)",lastname="García " },new PlayerModel {
            name = "Andrés ",age="3",team="Barcelona (ESP)",number="(13)",lastname="Iniesta " },new PlayerModel {
            name = "Xabi ",age="26",team="Liverpool (ENG)",number="(14)",lastname="Alonso " },new PlayerModel {
            name = "Marcos ",age="3",team="Villarreal (ESP)",number="(16)",lastname="Senna " },new PlayerModel {
            name = "Joaquín ",age="38",team="Real Betis (ESP)",number="(17)",lastname="## " },new PlayerModel {
            name = "Cesc ",age="4",team="Arsenal (ENG)",number="(18)",lastname="Fàbregas " },new PlayerModel {
            name = "Raúl ",age="95",team="Real Madrid (ESP)",number=" (7)",lastname="## " },new PlayerModel {
            name = "Fernando ",age="30",team="Atlético Madrid (ESP)",number=" (9)",lastname="Torres " },new PlayerModel {
            name = "David ",age="8",team="Valencia (ESP)",number="(21)",lastname="Villa " }}},
            {
           "fr-france",new List<PlayerModel>{
           new PlayerModel {
            name = "Mickaël ",age="3",team="Nantes (FRA)",number="(1)",lastname="Landreau " },new PlayerModel {
            name = "Fabien ",age="80",team="Marseille (FRA)",number="(16)",lastname="Barthez " },new PlayerModel {
            name = "Grégory ",age="18",team="Lyon (FRA)",number="(23)",lastname="Coupet " },new PlayerModel {
            name = "Jean-Alain ",age="19",team="Newcastle United (ENG)",number=" (2)",lastname="Boumsong " },new PlayerModel {
            name = "Éric ",age="8",team="Lyon (FRA)",number=" (3)",lastname="Abidal " },new PlayerModel {
            name = "William ",age="40",team="Chelsea (ENG)",number=" (5)",lastname="Gallas " },new PlayerModel {
            name = "Mikaël ",age="39",team="Manchester United (ENG)",number="(13)",lastname="Silvestre " },new PlayerModel {
            name = "Lilian ",age="114",team="Juventus (ITA)",number="(15)",lastname="Thuram " },new PlayerModel {
            name = "Gaël ",age="11",team="AS Monaco (FRA)",number="(17)",lastname="Givet " },new PlayerModel {
            name = "Willy ",age="38",team="Bayern Munich (GER)",number="(19)",lastname="Sagnol " },new PlayerModel {
            name = "Pascal ",age="1",team="Wigan Athletic (ENG)",number="(21)",lastname="Chimbonda " },new PlayerModel {
            name = "Patrick ",age="87",team="Juventus (ITA)",number=" (4)",lastname="Vieira " },new PlayerModel {
            name = "Claude ",age="43",team="Chelsea (ENG)",number=" (6)",lastname="Makélélé " },new PlayerModel {
            name = "Florent ",age="13",team="Lyon (FRA)",number=" (7)",lastname="Malouda " },new PlayerModel {
            name = "Vikash ",age="16",team="Paris Saint-Germain (FRA)",number=" (8)",lastname="Dhorasoo " },new PlayerModel {
            name = "Zinedine ",age="102",team="Real Madrid (ESP)",number="(10)",lastname="Zidane " },new PlayerModel {
            name = "Alou ",age="9",team="Lens (FRA)",number="(18)",lastname="Diarra " },new PlayerModel {
            name = "Franck ",age="3",team="Marseille (FRA)",number="(22)",lastname="Ribéry " },new PlayerModel {
            name = "Sidney ",age="19",team="Lyon (FRA)",number=" (9)",lastname="Govou " },new PlayerModel {
            name = "Sylvain ",age="80",team="Lyon (FRA)",number="(11)",lastname="Wiltord " },new PlayerModel {
            name = "Thierry ",age="78",team="Arsenal (ENG)",number="(12)",lastname="Henry " },new PlayerModel {
            name = "Louis ",age="9",team="Manchester United (ENG)",number="(14)",lastname="Saha " },new PlayerModel {
            name = "David ",age="63",team="Juventus (ITA)",number="(20)",lastname="Trézéguet " }}},
            {
           "gh-ghana",new List<PlayerModel>{
           new PlayerModel {
            name = "Sammy ",age="31",team="Ashdod (ISR)",number="(1)",lastname="Adjei " },new PlayerModel {
            name = "George ",age="6",team="Ashanti Gold (GHA)",number="(16)",lastname="Owu " },new PlayerModel {
            name = "Richard ",age="33",team="Ankaraspor (TUR)",number="(22)",lastname="Kingson " },new PlayerModel {
            name = "Samuel ",age="58",team="Roma (ITA)",number=" (4)",lastname="Kuffour " },new PlayerModel {
            name = "John ",age="33",team="Rennes (FRA)",number=" (5)",lastname="Mensah " },new PlayerModel {
            name = "Emmanuel ",age="27",team="Hapoel Kfar Saba (ISR)",number=" (6)",lastname="Pappoe " },new PlayerModel {
            name = "Illiasu ",age="2",team="Asante Kotoko (GHA)",number=" (7)",lastname="Shilla " },new PlayerModel {
            name = "Habib ",age="1",team="King Faisal Babes (GHA)",number="(13)",lastname="Mohamed " },new PlayerModel {
            name = "Daniel ",age="7",team="Hearts of Oak (GHA)",number="(17)",lastname="Quaye " },new PlayerModel {
            name = "Eric ",age="6",team="PSV Eindhoven (NED)",number="(18)",lastname="Addo " },new PlayerModel {
            name = "Issah ",age="10",team="Randers (DEN)",number="(21)",lastname="Ahmed " },new PlayerModel {
            name = "Hans ",age="7",team="Wolfsburg (GER)",number=" (2)",lastname="Sarpei " },new PlayerModel {
            name = "Michael ",age="17",team="Chelsea (ENG)",number=" (8)",lastname="Essien " },new PlayerModel {
            name = "Derek ",age="11",team="AIK (SWE)",number=" (9)",lastname="Boateng " },new PlayerModel {
            name = "Stephen ",age="42",team="Fenerbahçe (TUR)",number="(10)",lastname="Appiah " },new PlayerModel {
            name = "Sulley ",age="16",team="Udinese (ITA)",number="(11)",lastname="Muntari " },new PlayerModel {
            name = "John ",age="21",team="Hapoel Tel Aviv (ISR)",number="(15)",lastname="Paintsil " },new PlayerModel {
            name = "Haminu ",age="7",team="Red Star Belgrade (SRB)",number="(23)",lastname="Dramani " },new PlayerModel {
            name = "Asamoah ",age="13",team="Udinese (ITA)",number=" (3)",lastname="Gyan " },new PlayerModel {
            name = "Alex ",age="5",team="St. Gallen (SUI)",number="(12)",lastname="Tachie-Mensah " },new PlayerModel {
            name = "Matthew ",age="16",team="Borussia Dortmund (GER)",number="(14)",lastname="Amoah " },new PlayerModel {
            name = "Razak ",age="4",team="Copenhagen (DEN)",number="(19)",lastname="Pimpong " },new PlayerModel {
            name = "Otto ",age="13",team="Mainz 05 (GER)",number="(20)",lastname="Addo " }}},
            {
           "hr-croatia",new List<PlayerModel>{
           new PlayerModel {
            name = "Stipe ",age="50",team="Shakhtar Donetsk (UKR)",number="(1)",lastname="Pletikosa " },new PlayerModel {
            name = "Joey ",age="4",team="Austria Wien (AUT)",number="(12)",lastname="Didulica " },new PlayerModel {
            name = "Tomislav ",age="28",team="Club Brugge (BEL)",number="(23)",lastname="Butina " },new PlayerModel {
            name = "Josip ",age="42",team="Hertha BSC (GER)",number=" (3)",lastname="Šimunić " },new PlayerModel {
            name = "Robert ",age="56",team="Juventus (ITA)",number=" (4)",lastname="Kovač " },new PlayerModel {
            name = "Igor ",age="52",team="Juventus (ITA)",number=" (5)",lastname="Tudor " },new PlayerModel {
            name = "Dario ",age="80",team="Milan (ITA)",number=" (7)",lastname="Šimić " },new PlayerModel {
            name = "Mario ",age="28",team="Austria Wien (AUT)",number="(11)",lastname="Tokić " },new PlayerModel {
            name = "Stjepan ",age="48",team="Galatasaray (TUR)",number="(13)",lastname="Tomas " },new PlayerModel {
            name = "Darijo ",age="36",team="Shakhtar Donetsk (UKR)",number=" (2)",lastname="Srna " },new PlayerModel {
            name = "Jurica ",age="24",team="Werder Bremen (GER)",number=" (6)",lastname="Vranješ " },new PlayerModel {
            name = "Marko ",age="33",team="Bayer Leverkusen (GER)",number=" (8)",lastname="Babić " },new PlayerModel {
            name = "Niko ",age="58",team="Hertha BSC (GER)",number="(10)",lastname="Kovač " },new PlayerModel {
            name = "Luka ",age="5",team="Dinamo Zagreb (CRO)",number="(14)",lastname="Modrić " },new PlayerModel {
            name = "Ivan ",age="13",team="Club Brugge (BEL)",number="(15)",lastname="Leko " },new PlayerModel {
            name = "Jerko ",age="36",team="Dynamo Kyiv (UKR)",number="(16)",lastname="Leko " },new PlayerModel {
            name = "Niko ",age="21",team="Hajduk Split (CRO)",number="(19)",lastname="Kranjčar " },new PlayerModel {
            name = "Anthony ",age="14",team="Panathinaikos (GRE)",number="(20)",lastname="Šerić " },new PlayerModel {
            name = "Dado ",age="29",team="Rangers (SCO)",number=" (9)",lastname="Pršo " },new PlayerModel {
            name = "Ivan ",age="20",team="Werder Bremen (GER)",number="(17)",lastname="Klasnić " },new PlayerModel {
            name = "Ivica ",age="36",team="CSKA Moscow (RUS)",number="(18)",lastname="Olić " },new PlayerModel {
            name = "Boško ",age="27",team="Club Brugge (BEL)",number="(21)",lastname="Balaban " },new PlayerModel {
            name = "Ivan ",age="13",team="Dinamo Zagreb (CRO)",number="(22)",lastname="Bošnjak " }}},
            {
           "ir-iran",new List<PlayerModel>{
           new PlayerModel {
            name = "Ebrahim ",age="64",team="Foolad (IRN)",number="(1)",lastname="Mirzapour " },new PlayerModel {
            name = "Hassan ",age="3",team="Pas (IRN)",number="(12)",lastname="Roudbarian " },new PlayerModel {
            name = "Vahid ",age="1",team="Esteghlal (IRN)",number="(22)",lastname="Talebloo " },new PlayerModel {
            name = "Sohrab ",age="31",team="Saba Battery (IRN)",number=" (3)",lastname="Bakhtiarizadeh " },new PlayerModel {
            name = "Yahya ",age="69",team="Saba Battery (IRN)",number=" (4)",lastname="Golmohammadi " },new PlayerModel {
            name = "Rahman ",age="43",team="Messina (ITA)",number=" (5)",lastname="Rezaei " },new PlayerModel {
            name = "Hossein ",age="44",team="Foolad (IRN)",number="(13)",lastname="Kaebi " },new PlayerModel {
            name = "Amir ",age="1",team="Esteghlal (IRN)",number="(19)",lastname="Hossein " },new PlayerModel {
            name = "Mohammad ",age="44",team="Pas (IRN)",number="(20)",lastname="Nosrati " },new PlayerModel {
            name = "Mehdi ",age="89",team="Hamburg (GER)",number=" (2)",lastname="Mahdavikia " },new PlayerModel {
            name = "Javad ",age="71",team="Al-Sharjah (UAE)",number=" (6)",lastname="Nekounam " },new PlayerModel {
            name = "Ferydoon ",age="10",team="Kaiserslautern (GER)",number=" (7)",lastname="Zandi " },new PlayerModel {
            name = "Ali ",age="90",team="Bayern Munich (GER)",number=" (8)",lastname="Karimi " },new PlayerModel {
            name = "Andranik ",age="7",team="Abu Moslem (IRN)",number="(14)",lastname="Teymourian " },new PlayerModel {
            name = "Moharram ",age="24",team="Bochum (GER)",number="(18)",lastname="Navidkia " },new PlayerModel {
            name = "Mehrzad ",age="6",team="Persepolis (IRN)",number="(21)",lastname="Madanchi " },new PlayerModel {
            name = "Masoud ",age="3",team="Saipa (IRN)",number="(23)",lastname="Shojaei " },new PlayerModel {
            name = "Vahid ",age="28",team="Hannover 96 (GER)",number=" (9)",lastname="Hashemian " },new PlayerModel {
            name = "Ali ",age="147",team="Saba Battery (IRN)",number="(10)",lastname="Daei " },new PlayerModel {
            name = "Rasoul ",age="12",team="Sepahan (IRN)",number="(11)",lastname="Khatibi " },new PlayerModel {
            name = "Arash ",age="20",team="Pas (IRN)",number="(15)",lastname="Borhani " },new PlayerModel {
            name = "Reza ",age="15",team="Esteghlal (IRN)",number="(16)",lastname="Enayati " },new PlayerModel {
            name = "Javad ",age="25",team="Persepolis (IRN)",number="(17)",lastname="Kazemian " }}},
            {
           "it-italy",new List<PlayerModel>{
           new PlayerModel {
            name = "Gianluigi ",age="60",team="Juventus (ITA)",number="(1)",lastname="Buffon " },new PlayerModel {
            name = "Angelo ",age="31",team="Lazio (ITA)",number="(12)",lastname="Peruzzi " },new PlayerModel {
            name = "Marco ",age="1",team="Livorno (ITA)",number="(14)",lastname="Amelia " },new PlayerModel {
            name = "Cristian ",age="12",team="Palermo (ITA)",number=" (2)",lastname="Zaccardo " },new PlayerModel {
            name = "Fabio ",age="17",team="Palermo (ITA)",number=" (3)",lastname="Grosso " },new PlayerModel {
            name = "Fabio ",age="93",team="Juventus (ITA)",number=" (5)",lastname="Cannavaro " },new PlayerModel {
            name = "Andrea ",age="8",team="Palermo (ITA)",number=" (6)",lastname="Barzagli " },new PlayerModel {
            name = "Alessandro ",age="74",team="Milan (ITA)",number="(13)",lastname="Nesta " },new PlayerModel {
            name = "Gianluca ",age="52",team="Juventus (ITA)",number="(19)",lastname="Zambrotta " },new PlayerModel {
            name = "Massimo ",age="20",team="Lazio (ITA)",number="(22)",lastname="Oddo " },new PlayerModel {
            name = "Marco ",age="28",team="Internazionale (ITA)",number="(23)",lastname="Materazzi " },new PlayerModel {
            name = "Daniele ",age="17",team="Roma (ITA)",number=" (4)",lastname="De " },new PlayerModel {
            name = "Gennaro ",age="43",team="Milan (ITA)",number=" (8)",lastname="Gattuso " },new PlayerModel {
            name = "Mauro ",age="21",team="Juventus (ITA)",number="(16)",lastname="Camoranesi " },new PlayerModel {
            name = "Simone ",age="13",team="Palermo (ITA)",number="(17)",lastname="Barone " },new PlayerModel {
            name = "Simone ",age="24",team="Roma (ITA)",number="(20)",lastname="Perrotta " },new PlayerModel {
            name = "Andrea ",age="24",team="Milan (ITA)",number="(21)",lastname="Pirlo " },new PlayerModel {
            name = "Alessandro ",age="74",team="Juventus (ITA)",number=" (7)",lastname="Del " },new PlayerModel {
            name = "Luca ",age="18",team="Fiorentina (ITA)",number=" (9)",lastname="Toni " },new PlayerModel {
            name = "Francesco ",age="51",team="Roma (ITA)",number="(10)",lastname="Totti " },new PlayerModel {
            name = "Alberto ",age="15",team="Milan (ITA)",number="(11)",lastname="Gilardino " },new PlayerModel {
            name = "Vincenzo ",age="12",team="Udinese (ITA)",number="(15)",lastname="Iaquinta " },new PlayerModel {
            name = "Filippo ",age="49",team="Milan (ITA)",number="(18)",lastname="Inzaghi " }}},
            {
           "jp-japan",new List<PlayerModel>{
           new PlayerModel {
            name = "Seigo ",age="50",team="Nagoya Grampus Eight (JPN)",number="(1)",lastname="Narazaki " },new PlayerModel {
            name = "Yoichi ",age="4",team="FC Tokyo (JPN)",number="(12)",lastname="Doi " },new PlayerModel {
            name = "Yoshikatsu ",age="89",team="Júbilo Iwata (JPN)",number="(23)",lastname="Kawaguchi " },new PlayerModel {
            name = "Teruyuki ",age="8",team="FC Tokyo (JPN)",number=" (2)",lastname="Moniwa " },new PlayerModel {
            name = "Yūichi ",age="8",team="Sanfrecce Hiroshima (JPN)",number=" (3)",lastname="Komano " },new PlayerModel {
            name = "Tsuneyasu ",age="69",team="Gamba Osaka (JPN)",number=" (5)",lastname="Miyamoto " },new PlayerModel {
            name = "Kōji ",age="55",team="Basel (SUI)",number=" (6)",lastname="Nakata " },new PlayerModel {
            name = "Alex ",age="72",team="Urawa Red Diamonds (JPN)",number="(14)",lastname="## " },new PlayerModel {
            name = "Keisuke ",age="33",team="Urawa Red Diamonds (JPN)",number="(19)",lastname="Tsuboi " },new PlayerModel {
            name = "Akira ",age="43",team="Gamba Osaka (JPN)",number="(21)",lastname="Kaji " },new PlayerModel {
            name = "Yuji ",age="50",team="Yokohama F. Marinos (JPN)",number="(22)",lastname="Nakazawa " },new PlayerModel {
            name = "Yasuhito ",age="40",team="Gamba Osaka (JPN)",number=" (4)",lastname="Endo " },new PlayerModel {
            name = "Hidetoshi ",age="74",team="Fiorentina (ITA)",number=" (7)",lastname="Nakata " },new PlayerModel {
            name = "Mitsuo ",age="51",team="Kashima Antlers (JPN)",number=" (8)",lastname="Ogasawara " },new PlayerModel {
            name = "Shunsuke ",age="60",team="Celtic (SCO)",number="(10)",lastname="Nakamura " },new PlayerModel {
            name = "Takashi ",age="62",team="Júbilo Iwata (JPN)",number="(15)",lastname="Fukunishi " },new PlayerModel {
            name = "Junichi ",age="63",team="West Bromwich Albion (ENG)",number="(17)",lastname="Inamoto " },new PlayerModel {
            name = "Shinji ",age="54",team="Urawa Red Diamonds (JPN)",number="(18)",lastname="Ono " },new PlayerModel {
            name = "Naohiro ",age="41",team="Hamburg (GER)",number=" (9)",lastname="Takahara " },new PlayerModel {
            name = "Seiichiro ",age="10",team="JEF United (JPN)",number="(11)",lastname="Maki " },new PlayerModel {
            name = "Atsushi ",age="56",team="Kashima Antlers (JPN)",number="(13)",lastname="Yanagisawa " },new PlayerModel {
            name = "Masashi ",age="18",team="Grenoble (FRA)",number="(16)",lastname="Oguro " },new PlayerModel {
            name = "Keiji ",age="39",team="Nagoya Grampus Eight (JPN)",number="(20)",lastname="Tamada " }}},
            {
           "kr-south-korea",new List<PlayerModel>{
           new PlayerModel {
            name = "Lee ",age="97",team="Suwon Samsung Bluewings (KOR)",number="(1)",lastname="Woon-Jae " },new PlayerModel {
            name = "Kim ",age="15",team="Seongnam Ilhwa Chunma (KOR)",number="(20)",lastname="Yong-Dae " },new PlayerModel {
            name = "Kim ",age="6",team="Chunnam Dragons (KOR)",number="(21)",lastname="Young-Kwang " },new PlayerModel {
            name = "Kim ",age="12",team="Seongnam Ilhwa Chunma (KOR)",number=" (2)",lastname="Young-Chul " },new PlayerModel {
            name = "Kim ",age="34",team="FC Seoul (KOR)",number=" (3)",lastname="Dong-Jin " },new PlayerModel {
            name = "Choi ",age="62",team="Jeonbuk Hyundai Motors (KOR)",number=" (4)",lastname="Jin-Cheul " },new PlayerModel {
            name = "Kim ",age="23",team="Júbilo Iwata (JPN)",number=" (6)",lastname="Jin-Kyu " },new PlayerModel {
            name = "Lee ",age="85",team="Tottenham Hotspur (ENG)",number="(12)",lastname="Young-Pyo " },new PlayerModel {
            name = "Kim ",age="42",team="Seongnam Ilhwa Chunma (KOR)",number="(18)",lastname="Sang-Sik " },new PlayerModel {
            name = "Song ",age="51",team="Suwon Samsung Bluewings (KOR)",number="(22)",lastname="Chong-Gug " },new PlayerModel {
            name = "Cho ",age="13",team="Suwon Samsung Bluewings (KOR)",number="(23)",lastname="Won-Hee " },new PlayerModel {
            name = "Kim ",age="66",team="Suwon Samsung Bluewings (KOR)",number=" (5)",lastname="Nam-Il " },new PlayerModel {
            name = "Park ",age="60",team="Manchester United (ENG)",number=" (7)",lastname="Ji-Sung " },new PlayerModel {
            name = "Kim ",age="75",team="Seongnam Ilhwa Chunma (KOR)",number=" (8)",lastname="Do-Heon " },new PlayerModel {
            name = "Lee ",age="47",team="Trabzonspor (TUR)",number="(13)",lastname="Eul-Yong " },new PlayerModel {
            name = "Baek ",age="12",team="FC Seoul (KOR)",number="(15)",lastname="Ji-Hoon " },new PlayerModel {
            name = "Lee ",age="11",team="Ulsan Hyundai Horangi (KOR)",number="(17)",lastname="Ho " },new PlayerModel {
            name = "Ahn ",age="61",team="MSV Duisburg (GER)",number=" (9)",lastname="Jung-Hwan " },new PlayerModel {
            name = "Park ",age="18",team="FC Seoul (KOR)",number="(10)",lastname="Chu-Young " },new PlayerModel {
            name = "Seol ",age="67",team="Wolverhampton Wanderers (ENG)",number="(11)",lastname="Ki-Hyeon " },new PlayerModel {
            name = "Lee ",age="62",team="Ulsan Hyundai Horangi (KOR)",number="(14)",lastname="Chun-Soo " },new PlayerModel {
            name = "Chung ",age="40",team="Gwangju Sangmu Phoenix (KOR)",number="(16)",lastname="Kyung-Ho " },new PlayerModel {
            name = "Cho ",age="21",team="Shimizu S-Pulse (JPN)",number="(19)",lastname="Jae-Jin " }}},
            {
           "mx-mexico",new List<PlayerModel>{
           new PlayerModel {
            name = "Oswaldo ",age="70",team="Guadalajara (MEX)",number="(1)",lastname="Sánchez " },new PlayerModel {
            name = "José ",age="6",team="UAG (MEX)",number="(12)",lastname="de " },new PlayerModel {
            name = "Guillermo ",age="1",team="América (MEX)",number="(13)",lastname="Ochoa " },new PlayerModel {
            name = "Claudio ",age="178",team="Chivas USA (USA)",number=" (2)",lastname="Suárez " },new PlayerModel {
            name = "Carlos ",age="32",team="Guadalajara (MEX)",number=" (3)",lastname="Salcido " },new PlayerModel {
            name = "Rafael ",age="65",team="Barcelona (ESP)",number=" (4)",lastname="Márquez " },new PlayerModel {
            name = "Ricardo ",age="39",team="Cruz Azul (MEX)",number=" (5)",lastname="Osorio " },new PlayerModel {
            name = "Gonzalo ",age="30",team="Guadalajara (MEX)",number="(14)",lastname="Pineda " },new PlayerModel {
            name = "José ",age="12",team="América (MEX)",number="(15)",lastname="Antonio " },new PlayerModel {
            name = "Mario ",age="32",team="Monterrey (MEX)",number="(16)",lastname="Méndez " },new PlayerModel {
            name = "Francisco ",age="32",team="Guadalajara (MEX)",number="(22)",lastname="Javier " },new PlayerModel {
            name = "Gerardo ",age="56",team="Cruz Azul (MEX)",number=" (6)",lastname="Torrado " },new PlayerModel {
            name = "Sinha ",age="32",team="Toluca (MEX)",number=" (7)",lastname="## " },new PlayerModel {
            name = "Pável ",age="125",team="América (MEX)",number=" (8)",lastname="Pardo " },new PlayerModel {
            name = "Ramón ",age="46",team="Guadalajara (MEX)",number="(11)",lastname="Morales " },new PlayerModel {
            name = "Andrés ",age="7",team="Atlas (MEX)",number="(18)",lastname="Guardado " },new PlayerModel {
            name = "Rafael ",age="52",team="Atlas (MEX)",number="(20)",lastname="García " },new PlayerModel {
            name = "Jesús ",age="69",team="Monterrey (MEX)",number="(21)",lastname="Arellano " },new PlayerModel {
            name = "Luis ",age="52",team="Monterrey (MEX)",number="(23)",lastname="Ernesto " },new PlayerModel {
            name = "Jared ",age="75",team="Bolton Wanderers (ENG)",number=" (9)",lastname="Borgetti " },new PlayerModel {
            name = "Guillermo ",age="7",team="Villarreal (ESP)",number="(10)",lastname="Franco " },new PlayerModel {
            name = "Francisco ",age="29",team="Cruz Azul (MEX)",number="(17)",lastname="Fonseca " },new PlayerModel {
            name = "Omar ",age="33",team="Guadalajara (MEX)",number="(19)",lastname="Bravo " }}},
            {
           "nl-netherlands",new List<PlayerModel>{
           new PlayerModel {
            name = "Edwin ",age="109",team="Manchester United (ENG)",number="(1)",lastname="van " },new PlayerModel {
            name = "Henk ",age="2",team="AZ (NED)",number="(22)",lastname="Timmer " },new PlayerModel {
            name = "Maarten ",age="2",team="Ajax (NED)",number="(23)",lastname="Stekelenburg " },new PlayerModel {
            name = "Kew ",age="1",team="AZ (NED)",number=" (2)",lastname="Jaliens " },new PlayerModel {
            name = "Khalid ",age="11",team="Hamburg (GER)",number=" (3)",lastname="Boulahrouz " },new PlayerModel {
            name = "Joris ",age="8",team="AZ (NED)",number=" (4)",lastname="Mathijsen " },new PlayerModel {
            name = "Giovanni ",age="57",team="Barcelona (ESP)",number=" (5)",lastname="van " },new PlayerModel {
            name = "Jan ",age="11",team="Liverpool (ENG)",number="(12)",lastname="Kromkamp " },new PlayerModel {
            name = "André ",age="19",team="PSV Eindhoven (NED)",number="(13)",lastname="Ooijer " },new PlayerModel {
            name = "John ",age="18",team="Ajax (NED)",number="(14)",lastname="Heitinga " },new PlayerModel {
            name = "Tim ",age="3",team="AZ (NED)",number="(15)",lastname="de " },new PlayerModel {
            name = "Denny ",age="23",team="AZ (NED)",number=" (6)",lastname="Landzaat " },new PlayerModel {
            name = "Phillip ",age="97",team="PSV Eindhoven (NED)",number=" (8)",lastname="Cocu " },new PlayerModel {
            name = "Rafael ",age="35",team="Hamburg (GER)",number="(10)",lastname="van " },new PlayerModel {
            name = "Arjen ",age="20",team="Chelsea (ENG)",number="(11)",lastname="Robben " },new PlayerModel {
            name = "Hedwiges ",age="11",team="Ajax (NED)",number="(16)",lastname="Maduro " },new PlayerModel {
            name = "Mark ",age="37",team="Barcelona (ESP)",number="(18)",lastname="van " },new PlayerModel {
            name = "Wesley ",age="23",team="Ajax (NED)",number="(20)",lastname="Sneijder " },new PlayerModel {
            name = "Dirk ",age="19",team="Feyenoord (NED)",number=" (7)",lastname="Kuyt " },new PlayerModel {
            name = "Ruud ",age="51",team="Manchester United (ENG)",number=" (9)",lastname="van " },new PlayerModel {
            name = "Robin ",age="10",team="Arsenal (ENG)",number="(17)",lastname="van " },new PlayerModel {
            name = "Jan ",age="7",team="PSV Eindhoven (NED)",number="(19)",lastname="Vennegoor " },new PlayerModel {
            name = "Ryan ",age="6",team="Ajax (NED)",number="(21)",lastname="Babel " }}},
            {
           "pl-poland",new List<PlayerModel>{
           new PlayerModel {
            name = "Artur ",age="17",team="Celtic (SCO)",number="(1)",lastname="Boruc " },new PlayerModel {
            name = "Tomasz ",age="4",team="West Bromwich Albion (ENG)",number="(12)",lastname="Kuszczak " },new PlayerModel {
            name = "Łukasz ",age="2",team="Legia Warszawa (POL)",number="(22)",lastname="Fabiański " },new PlayerModel {
            name = "Mariusz ",age="12",team="FC Moscow (RUS)",number=" (2)",lastname="Jop " },new PlayerModel {
            name = "Seweryn ",age="2",team="Metalist Kharkiv (UKR)",number=" (3)",lastname="Gancarczyk " },new PlayerModel {
            name = "Marcin ",age="32",team="Wisła Kraków (POL)",number=" (4)",lastname="Baszczyński " },new PlayerModel {
            name = "Jacek ",age="72",team="Al-Rayyan (QAT)",number=" (6)",lastname="Bąk " },new PlayerModel {
            name = "Michał ",age="56",team="Anderlecht (BEL)",number="(14)",lastname="Żewłakow " },new PlayerModel {
            name = "Mariusz ",age="25",team="Shakhtar Donetsk (UKR)",number="(18)",lastname="Lewandowski " },new PlayerModel {
            name = "Bartosz ",age="11",team="Lech Poznań (POL)",number="(19)",lastname="Bosacki " },new PlayerModel {
            name = "Radosław ",age="19",team="Wisła Kraków (POL)",number=" (7)",lastname="Sobolewski " },new PlayerModel {
            name = "Jacek ",age="58",team="Bayer Leverkusen (GER)",number=" (8)",lastname="Krzynówek " },new PlayerModel {
            name = "Mirosław ",age="29",team="Trabzonspor (TUR)",number="(10)",lastname="Szymkowiak " },new PlayerModel {
            name = "Sebastian ",age="27",team="Austria Wien (AUT)",number="(13)",lastname="Mila " },new PlayerModel {
            name = "Arkadiusz ",age="20",team="Austria Vienna (AUT)",number="(16)",lastname="Radomski " },new PlayerModel {
            name = "Dariusz ",age="7",team="Wisła Kraków (POL)",number="(17)",lastname="Dudka " },new PlayerModel {
            name = "Piotr ",age="4",team="Cracovia (POL)",number="(20)",lastname="Giza " },new PlayerModel {
            name = "Kamil ",age="45",team="Kaiserslautern (GER)",number=" (5)",lastname="Kosowski " },new PlayerModel {
            name = "Maciej ",age="50",team="Celtic (SCO)",number=" (9)",lastname="Żurawski " },new PlayerModel {
            name = "Grzegorz ",age="30",team="Tottenham Hotspur (ENG)",number="(11)",lastname="Rasiak " },new PlayerModel {
            name = "Euzebiusz ",age="13",team="Borussia Dortmund (GER)",number="(15)",lastname="Smolarek " },new PlayerModel {
            name = "Ireneusz ",age="9",team="Wisła Płock (POL)",number="(21)",lastname="Jeleń " },new PlayerModel {
            name = "Paweł ",age="4",team="Wisła Kraków (POL)",number="(23)",lastname="Brożek " }}},
            {
           "pt-portugal",new List<PlayerModel>{
           new PlayerModel {
            name = "Ricardo ",age="49",team="Sporting CP (POR)",number="(1)",lastname="## " },new PlayerModel {
            name = "Quim ",age="24",team="Benfica (POR)",number="(12)",lastname="## " },new PlayerModel {
            name = "Paulo ",age="1",team="Braga (POR)",number="(22)",lastname="Santos " },new PlayerModel {
            name = "Paulo ",age="30",team="Chelsea (ENG)",number=" (2)",lastname="Ferreira " },new PlayerModel {
            name = "Marco ",age="14",team="Valencia (ESP)",number=" (3)",lastname="Caneira " },new PlayerModel {
            name = "Ricardo ",age="3",team="Porto (POR)",number=" (4)",lastname="Costa " },new PlayerModel {
            name = "Fernando ",age="30",team="Stuttgart (GER)",number=" (5)",lastname="Meira " },new PlayerModel {
            name = "Miguel ",age="28",team="Valencia (ESP)",number="(13)",lastname="## " },new PlayerModel {
            name = "Nuno ",age="23",team="Everton (ENG)",number="(14)",lastname="Valente " },new PlayerModel {
            name = "Ricardo ",age="24",team="Chelsea (ENG)",number="(16)",lastname="Carvalho " },new PlayerModel {
            name = "Costinha ",age="44",team="Dynamo Moscow (RUS)",number=" (6)",lastname="## " },new PlayerModel {
            name = "Luís ",age="120",team="Internazionale (ITA)",number=" (7)",lastname="Figo " },new PlayerModel {
            name = "Petit ",age="36",team="Benfica (POR)",number=" (8)",lastname="## " },new PlayerModel {
            name = "Hugo ",age="21",team="Valencia (ESP)",number="(10)",lastname="Viana " },new PlayerModel {
            name = "Maniche ",age="31",team="Dynamo Moscow (RUS)",number="(18)",lastname="## " },new PlayerModel {
            name = "Tiago ",age="22",team="Lyon (FRA)",number="(19)",lastname="## " },new PlayerModel {
            name = "Deco ",age="35",team="Barcelona (ESP)",number="(20)",lastname="## " },new PlayerModel {
            name = "Pauleta ",age="82",team="Paris Saint-Germain (FRA)",number=" (9)",lastname="## " },new PlayerModel {
            name = "Simão ",age="43",team="Benfica (POR)",number="(11)",lastname="## " },new PlayerModel {
            name = "Luís ",age="24",team="Fulham (ENG)",number="(15)",lastname="Boa " },new PlayerModel {
            name = "Cristiano ",age="32",team="Manchester United (ENG)",number="(17)",lastname="Ronaldo " },new PlayerModel {
            name = "Nuno ",age="53",team="Benfica (POR)",number="(21)",lastname="Gomes " },new PlayerModel {
            name = "Hélder ",age="24",team="Porto (POR)",number="(23)",lastname="Postiga " }}},
            {
           "py-paraguay",new List<PlayerModel>{
           new PlayerModel {
            name = "Justo ",age="39",team="Newell's Old Boys (ARG)",number="(1)",lastname="Villar " },new PlayerModel {
            name = "Derlis ",age="5",team="Sportivo Luqueño (PAR)",number="(12)",lastname="Gómez " },new PlayerModel {
            name = "Aldo ",age="5",team="Libertad (PAR)",number="(22)",lastname="Bobadilla " },new PlayerModel {
            name = "Jorge ",age="15",team="Estudiantes de La Plata (ARG)",number=" (2)",lastname="Núñez " },new PlayerModel {
            name = "Delio ",age="30",team="Real Zaragoza (ESP)",number=" (3)",lastname="Toledo " },new PlayerModel {
            name = "Carlos ",age="106",team="Palmeiras (BRA)",number=" (4)",lastname="Gamarra " },new PlayerModel {
            name = "Julio ",age="32",team="River Plate (ARG)",number=" (5)",lastname="César " },new PlayerModel {
            name = "Paulo ",age="33",team="Toluca (MEX)",number="(14)",lastname="da " },new PlayerModel {
            name = "Julio ",age="13",team="Santos (BRA)",number="(15)",lastname="César " },new PlayerModel {
            name = "Denis ",age="74",team="Cruz Azul (MEX)",number="(21)",lastname="Caniza " },new PlayerModel {
            name = "Carlos ",age="29",team="Libertad (PRY)",number=" (6)",lastname="Bonet " },new PlayerModel {
            name = "Edgar ",age="15",team="NEC (NED)",number=" (8)",lastname="Barreto " },new PlayerModel {
            name = "Roberto ",age="93",team="Deportivo La Coruña (ESP)",number="(10)",lastname="Acuña " },new PlayerModel {
            name = "Diego ",age="39",team="Newell's Old Boys (ARG)",number="(11)",lastname="Gavilán " },new PlayerModel {
            name = "Carlos ",age="68",team="Reggina (ITA)",number="(13)",lastname="Paredes " },new PlayerModel {
            name = "Cristian ",age="9",team="Libertad (PAR)",number="(16)",lastname="Riveros " },new PlayerModel {
            name = "José ",age="6",team="Olimpia (PAR)",number="(17)",lastname="Montiel " },new PlayerModel {
            name = "Julio ",age="17",team="Bayern Munich (GER)",number="(19)",lastname="dos " },new PlayerModel {
            name = "Salvador ",age="15",team="Jaguares (MEX)",number=" (7)",lastname="Cabañas " },new PlayerModel {
            name = "Roque ",age="42",team="Bayern Munich (GER)",number=" (9)",lastname="Santa " },new PlayerModel {
            name = "Nelson ",age="11",team="Werder Bremen (GER)",number="(18)",lastname="Valdez " },new PlayerModel {
            name = "Dante ",age="7",team="Genoa (ITA)",number="(20)",lastname="López " },new PlayerModel {
            name = "Nelson ",age="35",team="Pachuca (MEX)",number="(23)",lastname="Cuevas " }}},
            {
           "rs-serbia",new List<PlayerModel>{
           new PlayerModel {
            name = "Dragoslav ",age="40",team="Ankaraspor (TUR)",number="(1)",lastname="Jevrić " },new PlayerModel {
            name = "Oliver ",age="3",team="CSKA Sofia (BUL)",number="(12)",lastname="Kovačević " },new PlayerModel {
            name = "Vladimir ",age="0",team="Red Star Belgrade (SRB)",number="(23)",lastname="Stojković " },new PlayerModel {
            name = "Ivica ",age="26",team="Sevilla (ESP)",number=" (3)",lastname="Dragutinović " },new PlayerModel {
            name = "Nemanja ",age="20",team="Manchester United (ENG)",number=" (5)",lastname="Vidić " },new PlayerModel {
            name = "Goran ",age="25",team="Dynamo Kyiv (UKR)",number=" (6)",lastname="Gavrančić " },new PlayerModel {
            name = "Dušan ",age="2",team="Red Star Belgrade (SRB)",number="(13)",lastname="Basta " },new PlayerModel {
            name = "Nenad ",age="15",team="Partizan (SRB)",number="(14)",lastname="Đorđević " },new PlayerModel {
            name = "Milan ",age="11",team="Red Star Belgrade (SRB)",number="(15)",lastname="Dudić " },new PlayerModel {
            name = "Dušan ",age="12",team="OFK Beograd (SRB)",number="(16)",lastname="Petković " },new PlayerModel {
            name = "Mladen ",age="45",team="Schalke 04 (GER)",number="(20)",lastname="Krstajić " },new PlayerModel {
            name = "Ivan ",age="1",team="Basel (SUI)",number=" (2)",lastname="Ergić " },new PlayerModel {
            name = "Igor ",age="37",team="Shakhtar Donetsk (UKR)",number=" (4)",lastname="Duljaj " },new PlayerModel {
            name = "Ognjen ",age="25",team="Portsmouth (ENG)",number=" (7)",lastname="Koroman " },new PlayerModel {
            name = "Dejan ",age="58",team="Internazionale (ITA)",number="(10)",lastname="Stanković " },new PlayerModel {
            name = "Predrag ",age="34",team="Olympiacos (GRE)",number="(11)",lastname="Đorđević " },new PlayerModel {
            name = "Albert ",age="42",team="Partizan (SRB)",number="(17)",lastname="Nađ " },new PlayerModel {
            name = "Zvonimir ",age="25",team="Shakhtar Donetsk (UKR)",number="(18)",lastname="Vukić " },new PlayerModel {
            name = "Saša ",age="32",team="Galatasaray (TUR)",number="(22)",lastname="Ilić " },new PlayerModel {
            name = "Mateja ",age="47",team="Atlético Madrid (ESP)",number=" (8)",lastname="Kežman " },new PlayerModel {
            name = "Savo ",age="98",team="Osasuna (ESP)",number=" (9)",lastname="Milošević " },new PlayerModel {
            name = "Nikola ",age="11",team="Red Star Belgrade (SRB)",number="(19)",lastname="Žigić " },new PlayerModel {
            name = "Danijel ",age="15",team="Paris Saint-Germain (FRA)",number="(21)",lastname="Ljuboja " }}},
            {
           "sa-saudi-arabia",new List<PlayerModel>{
           new PlayerModel {
            name = "Mohamed ",age="175",team="Al-Hilal (KSA)",number="(1)",lastname="Al-Deayea " },new PlayerModel {
            name = "Mabrouk ",age="33",team="Al-Ittihad (KSA)",number="(21)",lastname="Zaid " },new PlayerModel {
            name = "Mohammad ",age="8",team="Al-Shabab (KSA)",number="(22)",lastname="Khouja " },new PlayerModel {
            name = "Ahmed ",age="68",team="Al-Ittihad (KSA)",number=" (2)",lastname="Dokhi " },new PlayerModel {
            name = "Redha ",age="37",team="Al-Ittihad (KSA)",number=" (3)",lastname="Tukar " },new PlayerModel {
            name = "Hamad ",age="32",team="Al-Ittihad (KSA)",number=" (4)",lastname="Al-Montashari " },new PlayerModel {
            name = "Naif ",age="28",team="Al-Ahli (KSA)",number=" (5)",lastname="Al-Qadi " },new PlayerModel {
            name = "Abdulaziz ",age="19",team="Al-Hilal (KSA)",number="(12)",lastname="Khathran " },new PlayerModel {
            name = "Hussein ",age="97",team="Al-Ahli (KSA)",number="(13)",lastname="Sulaimani " },new PlayerModel {
            name = "Ahmed ",age="11",team="Al-Ettifaq (KSA)",number="(15)",lastname="Al-Bahri " },new PlayerModel {
            name = "Mohammad ",age="0",team="Al-Ahli (KSA)",number="(17)",lastname="Al-Bishi " },new PlayerModel {
            name = "Mohammad ",age="5",team="Al-Ahli (KSA)",number="(19)",lastname="Massad " },new PlayerModel {
            name = "Omar ",age="38",team="Al-Hilal (KSA)",number=" (6)",lastname="Al-Ghamdi " },new PlayerModel {
            name = "Mohammed ",age="16",team="Al-Ittihad (KSA)",number=" (7)",lastname="Ameen " },new PlayerModel {
            name = "Mohammed ",age="63",team="Al-Ittihad (KSA)",number=" (8)",lastname="Noor " },new PlayerModel {
            name = "Mohammad ",age="48",team="Al-Hilal (KSA)",number="(10)",lastname="Al-Shalhoub " },new PlayerModel {
            name = "Saud ",age="34",team="Al-Ittihad (KSA)",number="(14)",lastname="Khariri " },new PlayerModel {
            name = "Khaled ",age="14",team="Al-Hilal (KSA)",number="(16)",lastname="Aziz " },new PlayerModel {
            name = "Nawaf ",age="56",team="Al-Hilal (KSA)",number="(18)",lastname="Al-Temyat " },new PlayerModel {
            name = "Sami ",age="160",team="Al-Hilal (KSA)",number=" (9)",lastname="Al-Jaber " },new PlayerModel {
            name = "Saad ",age="15",team="Al-Nasr (KSA)",number="(11)",lastname="Al-Harthi " },new PlayerModel {
            name = "Yasser ",age="45",team="Al-Hilal (KSA)",number="(20)",lastname="Al-Qahtani " },new PlayerModel {
            name = "Malek ",age="5",team="Al-Ahli (KSA)",number="(23)",lastname="Mouath " }}},
            {
           "se-sweden",new List<PlayerModel>{
           new PlayerModel {
            name = "Andreas ",age="39",team="Rennes (FRA)",number="(1)",lastname="Isaksson " },new PlayerModel {
            name = "John ",age="2",team="Viborg (DEN)",number="(12)",lastname="Alvbåge " },new PlayerModel {
            name = "Rami ",age="1",team="Fredrikstad (NOR)",number="(23)",lastname="Shaaban " },new PlayerModel {
            name = "Mikael ",age="27",team="Panathinaikos (GRE)",number=" (2)",lastname="Nilsson " },new PlayerModel {
            name = "Olof ",age="64",team="Aston Villa (ENG)",number=" (3)",lastname="Mellberg " },new PlayerModel {
            name = "Teddy ",age="81",team="Häcken (SWE)",number=" (4)",lastname="Lucic " },new PlayerModel {
            name = "Erik ",age="37",team="Rennes (FRA)",number=" (5)",lastname="Edman " },new PlayerModel {
            name = "Petter ",age="13",team="Heerenveen (NED)",number="(13)",lastname="Hansson " },new PlayerModel {
            name = "Fredrik ",age="1",team="Bayer Leverkusen (GER)",number="(14)",lastname="Stenman " },new PlayerModel {
            name = "Karl ",age="1",team="Göteborg (SWE)",number="(15)",lastname="Svensson " },new PlayerModel {
            name = "Tobias ",age="58",team="Copenhagen (DEN)",number=" (6)",lastname="Linderoth " },new PlayerModel {
            name = "Niclas ",age="87",team="Göteborg (SWE)",number=" (7)",lastname="Alexandersson " },new PlayerModel {
            name = "Anders ",age="66",team="Elfsborg (SWE)",number=" (8)",lastname="Svensson " },new PlayerModel {
            name = "Fredrik ",age="57",team="Arsenal (ENG)",number=" (9)",lastname="Ljungberg " },new PlayerModel {
            name = "Kim ",age="34",team="Rennes (FRA)",number="(16)",lastname="Källström " },new PlayerModel {
            name = "Mattias ",age="53",team="Djurgården (SWE)",number="(18)",lastname="Jonson " },new PlayerModel {
            name = "Daniel ",age="47",team="Malmö (SWE)",number="(19)",lastname="Andersson " },new PlayerModel {
            name = "Christian ",age="29",team="Anderlecht (BEL)",number="(21)",lastname="Wilhelmsson " },new PlayerModel {
            name = "Zlatan ",age="38",team="Juventus (ITA)",number="(10)",lastname="Ibrahimović " },new PlayerModel {
            name = "Henrik ",age="89",team="Barcelona (ESP)",number="(11)",lastname="Larsson " },new PlayerModel {
            name = "Johan ",age="18",team="Brøndby (DEN)",number="(17)",lastname="Elmander " },new PlayerModel {
            name = "Marcus ",age="56",team="Copenhagen (DEN)",number="(20)",lastname="Allbäck " },new PlayerModel {
            name = "Markus ",age="8",team="Ajax (NED)",number="(22)",lastname="Rosenberg " }}},
            {
           "tg-togo",new List<PlayerModel>{
           new PlayerModel {
            name = "Ouro-Nimini ",age="9",team="Djoliba (MLI)",number="(1)",lastname="Tchagnirou " },new PlayerModel {
            name = "Kossi ",age="49",team="Metz (FRA)",number="(16)",lastname="Agassa " },new PlayerModel {
            name = "Kodjovi ",age="0",team="Étoile Filante (TOG)",number="(22)",lastname="Obilale " },new PlayerModel {
            name = "Daré ",age="16",team="Mons (BEL)",number=" (2)",lastname="Nibombé " },new PlayerModel {
            name = "Jean-Paul ",age="65",team="APOEL (CYP)",number=" (3)",lastname="Abalo " },new PlayerModel {
            name = "Massamasso ",age="34",team="Benevento (ITA)",number=" (5)",lastname="Tchangai " },new PlayerModel {
            name = "Éric ",age="32",team="Admira Wacker (AUT)",number="(12)",lastname="Akoto " },new PlayerModel {
            name = "Richmond ",age="8",team="Poiré (FRA)",number="(13)",lastname="Forson " },new PlayerModel {
            name = "Ludovic ",age="5",team="Ciudad de Murcia (ESP)",number="(19)",lastname="Assemoassa " },new PlayerModel {
            name = "Assimiou ",age="1",team="Bayer Leverkusen (GER)",number="(23)",lastname="Touré " },new PlayerModel {
            name = "Yao ",age="32",team="Young Boys (SUI)",number=" (6)",lastname="Aziawonou " },new PlayerModel {
            name = "Kuami ",age="4",team="Beveren (BEL)",number=" (8)",lastname="Agboh " },new PlayerModel {
            name = "Thomas ",age="10",team="Valenciennes (FRA)",number=" (9)",lastname="Dossevi " },new PlayerModel {
            name = "Mamam ",age="39",team="Metz (FRA)",number="(10)",lastname="Cherif " },new PlayerModel {
            name = "Adékambi ",age="24",team="Al-Siliyah (QAT)",number="(14)",lastname="Olufadé " },new PlayerModel {
            name = "Alaixys ",age="11",team="Louhans-Cuiseaux (FRA)",number="(15)",lastname="Romao " },new PlayerModel {
            name = "Yao ",age="16",team="YF Juventus (SUI)",number="(18)",lastname="Junior " },new PlayerModel {
            name = "Franck ",age="13",team="Al-Hilal (KSA)",number="(21)",lastname="Atsou " },new PlayerModel {
            name = "Emmanuel ",age="29",team="Arsenal (ENG)",number=" (4)",lastname="Adebayor " },new PlayerModel {
            name = "Moustapha ",age="34",team="Brest (FRA)",number=" (7)",lastname="Salifou " },new PlayerModel {
            name = "Robert ",age="1",team="Brest (FRA)",number="(11)",lastname="Malm " },new PlayerModel {
            name = "Mohamed ",age="46",team="Guingamp (FRA)",number="(17)",lastname="Kader " },new PlayerModel {
            name = "Affo ",age="6",team="Moulins (FRA)",number="(20)",lastname="Erassa " }}},
            {
           "tn-tunisia",new List<PlayerModel>{
           new PlayerModel {
            name = "Ali ",age="48",team="Club Africain (TUN)",number="(1)",lastname="Boumnijel " },new PlayerModel {
            name = "Adel ",age="0",team="Monastir (TUN)",number="(16)",lastname="Nefzi " },new PlayerModel {
            name = "Hamdi ",age="6",team="Espérance de Tunis (TUN)",number="(22)",lastname="Kasraoui " },new PlayerModel {
            name = "Karim ",age="7",team="Rosenborg (NOR)",number=" (2)",lastname="Essediri " },new PlayerModel {
            name = "Karim ",age="26",team="Strasbourg (FRA)",number=" (3)",lastname="Haggui " },new PlayerModel {
            name = "Alaeddine ",age="13",team="Saint-Étienne (FRA)",number=" (4)",lastname="Yahia " },new PlayerModel {
            name = "Hatem ",age="56",team="Ajax (NED)",number=" (6)",lastname="Trabelsi " },new PlayerModel {
            name = "Radhi ",age="89",team="Bolton Wanderers (ENG)",number="(15)",lastname="Jaïdi " },new PlayerModel {
            name = "David ",age="2",team="Bordeaux (FRA)",number="(18)",lastname="Jemmali " },new PlayerModel {
            name = "Anis ",age="24",team="Samsunspor (TUR)",number="(19)",lastname="Ayari " },new PlayerModel {
            name = "Karim ",age="15",team="Feyenoord (NED)",number="(21)",lastname="Saidi " },new PlayerModel {
            name = "Mehdi ",age="29",team="Birmingham City (ENG)",number=" (8)",lastname="Nafti " },new PlayerModel {
            name = "Kaies ",age="89",team="Konyaspor (TUR)",number="(10)",lastname="Ghodhbane " },new PlayerModel {
            name = "Jawhar ",age="37",team="Nuremberg (GER)",number="(12)",lastname="Mnari " },new PlayerModel {
            name = "Riadh ",age="85",team="Kayseri Erciyesspor (TUR)",number="(13)",lastname="Bouazizi " },new PlayerModel {
            name = "Adel ",age="38",team="Nuremberg (GER)",number="(14)",lastname="Chedli " },new PlayerModel {
            name = "Hamed ",age="14",team="Rangers (SCO)",number="(20)",lastname="Namouchi " },new PlayerModel {
            name = "Sofiane ",age="14",team="Gaziantepspor (TUR)",number="(23)",lastname="Melliti " },new PlayerModel {
            name = "Ziad ",age="61",team="Troyes (FRA)",number=" (5)",lastname="Jaziri " },new PlayerModel {
            name = "Haykel ",age="13",team="Strasbourg (FRA)",number=" (7)",lastname="Guemamdia " },new PlayerModel {
            name = "Yassine ",age="1",team="Étoile du Sahel (TUN)",number=" (9)",lastname="Chikhaoui " },new PlayerModel {
            name = "Francileudo ",age="28",team="Toulouse (FRA)",number="(11)",lastname="Santos " },new PlayerModel {
            name = "Chaouki ",age="11",team="Bastia (FRA)",number="(17)",lastname="Ben " }}},
            {
           "tt-trinidad-tobago",new List<PlayerModel>{
           new PlayerModel {
            name = "Shaka ",age="24",team="West Ham United (ENG)",number="(1)",lastname="Hislop " },new PlayerModel {
            name = "Kelvin ",age="32",team="Dundee (SCO)",number="(21)",lastname="Jack " },new PlayerModel {
            name = "Clayton ",age="63",team="Coventry City (ENG)",number="(22)",lastname="Ince " },new PlayerModel {
            name = "Ian ",age="16",team="Gillingham (ENG)",number=" (2)",lastname="Cox " },new PlayerModel {
            name = "Avery ",age="57",team="New England Revolution (USA)",number=" (3)",lastname="John " },new PlayerModel {
            name = "Marvin ",age="98",team="Rangers (SCO)",number=" (4)",lastname="Andrews " },new PlayerModel {
            name = "Brent ",age="40",team="Gillingham (ENG)",number=" (5)",lastname="Sancho " },new PlayerModel {
            name = "Dennis ",age="63",team="Wrexham (WAL)",number=" (6)",lastname="Lawrence " },new PlayerModel {
            name = "Cyd ",age="39",team="San Juan Jabloteh (TRI)",number=" (8)",lastname="Gray " },new PlayerModel {
            name = "David ",age="19",team="W Connection (TRI)",number="(17)",lastname="Atiba " },new PlayerModel {
            name = "Chris ",age="19",team="Port Vale (ENG)",number=" (7)",lastname="Birchall " },new PlayerModel {
            name = "Aurtis ",age="24",team="San Juan Jabloteh (TRI)",number=" (9)",lastname="Whitley " },new PlayerModel {
            name = "Russell ",age="66",team="Falkirk (SCO)",number="(10)",lastname="Latapy " },new PlayerModel {
            name = "Carlos ",age="51",team="Luton Town (ENG)",number="(11)",lastname="Edwards " },new PlayerModel {
            name = "Evans ",age="16",team="Waldhof Mannheim (GER)",number="(16)",lastname="Wise " },new PlayerModel {
            name = "Densill ",age="38",team="Falkirk (SCO)",number="(18)",lastname="Theobald " },new PlayerModel {
            name = "Anthony ",age="4",team="San Juan Jabloteh (TRI)",number="(23)",lastname="Wolfe " },new PlayerModel {
            name = "Collin ",age="18",team="Dundee United (SCO)",number="(12)",lastname="Samuel " },new PlayerModel {
            name = "Cornell ",age="35",team="LA Galaxy (USA)",number="(13)",lastname="Glen " },new PlayerModel {
            name = "Stern ",age="95",team="Coventry City (ENG)",number="(14)",lastname="John " },new PlayerModel {
            name = "Kenwyne ",age="29",team="Southampton (ENG)",number="(15)",lastname="Jones " },new PlayerModel {
            name = "Dwight ",age="54",team="Sydney FC (AUS)",number="(19)",lastname="Yorke " },new PlayerModel {
            name = "Jason ",age="25",team="St. Johnstone (SCO)",number="(20)",lastname="Scotland " }}},
            {
           "ua-ukraine",new List<PlayerModel>{
           new PlayerModel {
            name = "Oleksandr ",age="68",team="Dynamo Kyiv (UKR)",number="(1)",lastname="Shovkovskyi " },new PlayerModel {
            name = "Andriy ",age="1",team="Vorskla Poltava (UKR)",number="(12)",lastname="Pyatov " },new PlayerModel {
            name = "Bohdan ",age="2",team="Shakhtar Donetsk (UKR)",number="(23)",lastname="Shust " },new PlayerModel {
            name = "Andriy ",age="49",team="Dynamo Kyiv (UKR)",number=" (2)",lastname="Nesmachnyi " },new PlayerModel {
            name = "Oleksandr ",age="1",team="Kharkiv (UKR)",number=" (3)",lastname="Yatsenko " },new PlayerModel {
            name = "Volodymyr ",age="24",team="Dnipro Dnipropetrovsk (UKR)",number=" (5)",lastname="Yezerskyi " },new PlayerModel {
            name = "Andriy ",age="23",team="Dnipro Dnipropetrovsk (UKR)",number=" (6)",lastname="Rusol " },new PlayerModel {
            name = "Dmytro ",age="0",team="Shakhtar Donetsk (UKR)",number="(13)",lastname="Chyhrynskyi " },new PlayerModel {
            name = "Vladyslav ",age="58",team="Dynamo Kyiv (UKR)",number="(17)",lastname="Vashchuk " },new PlayerModel {
            name = "Vyacheslav ",age="6",team="Shakhtar Donetsk (UKR)",number="(22)",lastname="Sviderskyi " },new PlayerModel {
            name = "Anatoliy ",age="55",team="Shakhtar Donetsk (UKR)",number=" (4)",lastname="Tymoshchuk " },new PlayerModel {
            name = "Oleh ",age="19",team="Dnipro Dnipropetrovsk (UKR)",number=" (8)",lastname="Shelayev " },new PlayerModel {
            name = "Oleh ",age="25",team="Dynamo Kyiv (UKR)",number=" (9)",lastname="Husyev " },new PlayerModel {
            name = "Andriy ",age="64",team="Krylya Sovetov Samara (RUS)",number="(14)",lastname="Husin " },new PlayerModel {
            name = "Serhiy ",age="15",team="Dnipro Dnipropetrovsk (UKR)",number="(18)",lastname="Nazarenko " },new PlayerModel {
            name = "Maksym ",age="21",team="Spartak Moscow (RUS)",number="(19)",lastname="Kalynychenko " },new PlayerModel {
            name = "Ruslan ",age="19",team="Dynamo Kyiv (UKR)",number="(21)",lastname="Rotan " },new PlayerModel {
            name = "Andriy ",age="64",team="Milan (ITA)",number=" (7)",lastname="Shevchenko " },new PlayerModel {
            name = "Andriy ",age="32",team="Bayer Leverkusen (GER)",number="(10)",lastname="Voronin " },new PlayerModel {
            name = "Serhiy ",age="70",team="Dynamo Kyiv (UKR)",number="(11)",lastname="Rebrov " },new PlayerModel {
            name = "Artem ",age="0",team="Dynamo Kyiv (UKR)",number="(15)",lastname="Milevskyi " },new PlayerModel {
            name = "Andriy ",age="53",team="Shakhtar Donetsk (UKR)",number="(16)",lastname="Vorobey " },new PlayerModel {
            name = "Oleksiy ",age="15",team="Shakhtar Donetsk (UKR)",number="(20)",lastname="Byelik " },new PlayerModel {
            name = "",age="",team="",number="#",lastname="" },new PlayerModel {
            name = "p",age="",team="cements",number="# Ukraine (UKR)",lastname="l" },new PlayerModel {
            name = "1 ",age="",team="ayers",number="#",lastname="p" },new PlayerModel {
            name = "Vyacheslav ",age="16",team="Shakhtar Donetsk (UKR)",number=" (3)",lastname="Shevchuk " }}},
            {
           "us-united-states",new List<PlayerModel>{
           new PlayerModel {
            name = "Tim ",age="16",team="Manchester United (ENG)",number="(1)",lastname="Howard " },new PlayerModel {
            name = "Kasey ",age="93",team="Borussia Mönchengladbach (GER)",number="(18)",lastname="Keller " },new PlayerModel {
            name = "Marcus ",age="6",team="Reading (ENG)",number="(19)",lastname="Hahnemann " },new PlayerModel {
            name = "Chris ",age="20",team="LA Galaxy (USA)",number=" (2)",lastname="Albright " },new PlayerModel {
            name = "Carlos ",age="40",team="Fulham (ENG)",number=" (3)",lastname="Bocanegra " },new PlayerModel {
            name = "Steve ",age="35",team="Hannover 96 (GER)",number=" (6)",lastname="Cherundolo " },new PlayerModel {
            name = "Gregg ",age="44",team="Energie Cottbus (GER)",number="(12)",lastname="Berhalter " },new PlayerModel {
            name = "Jimmy ",age="15",team="Kansas City Wizards (USA)",number="(13)",lastname="Conrad " },new PlayerModel {
            name = "Oguchi ",age="14",team="Standard Liège (BEL)",number="(22)",lastname="Onyewu " },new PlayerModel {
            name = "Eddie ",age="80",team="Real Salt Lake (USA)",number="(23)",lastname="Pope " },new PlayerModel {
            name = "Pablo ",age="48",team="Colorado Rapids (USA)",number=" (4)",lastname="Mastroeni " },new PlayerModel {
            name = "John ",age="31",team="Chivas USA (USA)",number=" (5)",lastname="O'Brien " },new PlayerModel {
            name = "Eddie ",age="69",team="Leeds United (ENG)",number=" (7)",lastname="Lewis " },new PlayerModel {
            name = "Clint ",age="21",team="New England Revolution (USA)",number=" (8)",lastname="Dempsey " },new PlayerModel {
            name = "Claudio ",age="109",team="Manchester City (ENG)",number="(10)",lastname="Reyna " },new PlayerModel {
            name = "Ben ",age="34",team="D.C. United (USA)",number="(14)",lastname="Olsen " },new PlayerModel {
            name = "Bobby ",age="39",team="Reading (ENG)",number="(15)",lastname="Convey " },new PlayerModel {
            name = "DaMarcus ",age="58",team="PSV Eindhoven (NED)",number="(17)",lastname="Beasley " },new PlayerModel {
            name = "Eddie ",age="18",team="Kansas City Wizards (USA)",number=" (9)",lastname="Johnson " },new PlayerModel {
            name = "Brian ",age="20",team="Houston Dynamo (USA)",number="(11)",lastname="Ching " },new PlayerModel {
            name = "Josh ",age="47",team="Kansas City Wizards (USA)",number="(16)",lastname="Wolff " },new PlayerModel {
            name = "Brian ",age="92",team="Fulham (ENG)",number="(20)",lastname="McBride " },new PlayerModel {
            name = "Landon ",age="81",team="LA Galaxy (USA)",number="(21)",lastname="Donovan " }}
           }
           });
           squads.Add("2010",new Dictionary<string, List<PlayerModel>>
             {

             {"us-united-states",new List<PlayerModel>{new PlayerModel { name = "Tim ",age="16",team="Manchester United (ENG)",number="(1)",lastname="Howard " },new PlayerModel { name = "Kasey ",age="93",team="Borussia Mönchengladbach (GER)",number="(18)",lastname="Keller " },new PlayerModel { name = "Marcus ",age="6",team="Reading (ENG)",number="(19)",lastname="Hahnemann " },new PlayerModel { name = "Chris ",age="20",team="LA Galaxy (USA)",number=" (2)",lastname="Albright " },new PlayerModel { name = "Carlos ",age="40",team="Fulham (ENG)",number=" (3)",lastname="Bocanegra " },new PlayerModel { name = "Steve ",age="35",team="Hannover 96 (GER)",number=" (6)",lastname="Cherundolo " },new PlayerModel { name = "Gregg ",age="44",team="Energie Cottbus (GER)",number="(12)",lastname="Berhalter " },new PlayerModel { name = "Jimmy ",age="15",team="Kansas City Wizards (USA)",number="(13)",lastname="Conrad " },new PlayerModel { name = "Oguchi ",age="14",team="Standard Liège (BEL)",number="(22)",lastname="Onyewu " },new PlayerModel { name = "Eddie ",age="80",team="Real Salt Lake (USA)",number="(23)",lastname="Pope " },new PlayerModel { name = "Pablo ",age="48",team="Colorado Rapids (USA)",number=" (4)",lastname="Mastroeni " },new PlayerModel { name = "John ",age="31",team="Chivas USA (USA)",number=" (5)",lastname="O'Brien " },new PlayerModel { name = "Eddie ",age="69",team="Leeds United (ENG)",number=" (7)",lastname="Lewis " },new PlayerModel { name = "Clint ",age="21",team="New England Revolution (USA)",number=" (8)",lastname="Dempsey " },new PlayerModel { name = "Claudio ",age="109",team="Manchester City (ENG)",number="(10)",lastname="Reyna " },new PlayerModel { name = "Ben ",age="34",team="D.C. United (USA)",number="(14)",lastname="Olsen " },new PlayerModel { name = "Bobby ",age="39",team="Reading (ENG)",number="(15)",lastname="Convey " },new PlayerModel { name = "DaMarcus ",age="58",team="PSV Eindhoven (NED)",number="(17)",lastname="Beasley " },new PlayerModel { name = "Eddie ",age="18",team="Kansas City Wizards (USA)",number=" (9)",lastname="Johnson " },new PlayerModel { name = "Brian ",age="20",team="Houston Dynamo (USA)",number="(11)",lastname="Ching " },new PlayerModel { name = "Josh ",age="47",team="Kansas City Wizards (USA)",number="(16)",lastname="Wolff " },new PlayerModel { name = "Brian ",age="92",team="Fulham (ENG)",number="(20)",lastname="McBride " },new PlayerModel { name = "Landon ",age="81",team="LA Galaxy (USA)",number="(21)",lastname="Donovan " }}
             },
             {"ar-argentina",new List<PlayerModel>{new PlayerModel { name = "Diego ",age="3",team="Colón (ARG)",number="(1)",lastname="Pozo " },new PlayerModel { name = "Mariano ",age="4",team="Catania (ITA)",number="(21)",lastname="Andújar " },new PlayerModel { name = "Sergio ",age="5",team="AZ (NED)",number="(22)",lastname="Romero " },new PlayerModel { name = "Martín ",age="25",team="Bayern Munich (GER)",number=" (2)",lastname="Demichelis " },new PlayerModel { name = "Clemente ",age="11",team="Estudiantes (ARG)",number=" (3)",lastname="Rodríguez " },new PlayerModel { name = "Nicolás ",age="28",team="Roma (ITA)",number=" (4)",lastname="Burdisso " },new PlayerModel { name = "Gabriel ",age="63",team="Marseille (FRA)",number=" (6)",lastname="Heinze " },new PlayerModel { name = "Ariel ",age="3",team="Colón (ARG)",number="(12)",lastname="Garcé " },new PlayerModel { name = "Walter ",age="54",team="Internazionale (ITA)",number="(13)",lastname="Samuel " },new PlayerModel { name = "Nicolás ",age="6",team="Vélez Sársfield (ARG)",number="(15)",lastname="Otamendi " },new PlayerModel { name = "Mario ",age="4",team="Fiorentina (ITA)",number=" (5)",lastname="Bolatti " },new PlayerModel { name = "Ángel ",age="7",team="Benfica (POR)",number=" (7)",lastname="di " },new PlayerModel { name = "Juan ",age="69",team="Estudiantes (ARG)",number=" (8)",lastname="Sebastián " },new PlayerModel { name = "Javier ",age="56",team="Liverpool (ENG)",number="(14)",lastname="Mascherano " },new PlayerModel { name = "Jonás ",age="15",team="Newcastle United (ENG)",number="(17)",lastname="Gutiérrez " },new PlayerModel { name = "Maxi ",age="35",team="Liverpool (ENG)",number="(20)",lastname="Rodríguez " },new PlayerModel { name = "Javier ",age="0",team="Palermo (ITA)",number="(23)",lastname="Pastore " },new PlayerModel { name = "Gonzalo ",age="4",team="Real Madrid (ESP)",number=" (9)",lastname="Higuaín " },new PlayerModel { name = "Lionel ",age="44",team="Barcelona (ESP)",number="(10)",lastname="Messi " },new PlayerModel { name = "Carlos ",age="51",team="Manchester City (ENG)",number="(11)",lastname="Tévez " },new PlayerModel { name = "Sergio ",age="20",team="Atlético Madrid (ESP)",number="(16)",lastname="Agüero " },new PlayerModel { name = "Martín ",age="14",team="Boca Juniors (ARG)",number="(18)",lastname="Palermo " },new PlayerModel { name = "Diego ",age="20",team="Internazionale (ITA)",number="(19)",lastname="Milito " }}
             },
             {"au-australia",new List<PlayerModel>{new PlayerModel { name = "Mark ",age="75",team="Fulham (ENG)",number="(1)",lastname="Schwarzer " },new PlayerModel { name = "Adam ",age="1",team="Reading (ENG)",number="(12)",lastname="Federici " },new PlayerModel { name = "Eugene ",age="4",team="Adelaide United (AUS)",number="(18)",lastname="Galeković " },new PlayerModel { name = "Lucas ",age="56",team="Galatasaray (TUR)",number=" (2)",lastname="Neill " },new PlayerModel { name = "Craig ",age="50",team="",number=" (3)",lastname="Moore " },new PlayerModel { name = "Michael ",age="21",team="Al-Jazira (UAE)",number=" (6)",lastname="Beauchamp " },new PlayerModel { name = "Luke ",age="42",team="Dynamo Moscow (RUS)",number=" (8)",lastname="Wilkshire " },new PlayerModel { name = "Scott ",age="65",team="Basel (SUI)",number="(11)",lastname="Chipperfield " },new PlayerModel { name = "Mark ",age="10",team="JEF United (JPN)",number="(20)",lastname="Milligan " },new PlayerModel { name = "David ",age="25",team="Twente (NED)",number="(21)",lastname="Carney " },new PlayerModel { name = "Tim ",age="40",team="Everton (ENG)",number=" (4)",lastname="Cahill " },new PlayerModel { name = "Jason ",age="49",team="Gold Coast United (AUS)",number=" (5)",lastname="Čulina " },new PlayerModel { name = "Brett ",age="72",team="Blackburn Rovers (ENG)",number=" (7)",lastname="Emerton " },new PlayerModel { name = "Vince ",age="45",team="Blackburn Rovers (ENG)",number="(13)",lastname="Grella " },new PlayerModel { name = "Mile ",age="11",team="Antalyaspor (TUR)",number="(15)",lastname="Jedinak " },new PlayerModel { name = "Carl ",age="22",team="Sassuolo (ITA)",number="(16)",lastname="Valeri " },new PlayerModel { name = "Richard ",age="7",team="Hull City (ENG)",number="(19)",lastname="Garcia " },new PlayerModel { name = "Dario ",age="7",team="MSV Duisburg (GER)",number="(22)",lastname="Vidošić " },new PlayerModel { name = "Mark ",age="55",team="Palermo (ITA)",number="(23)",lastname="Bresciano " },new PlayerModel { name = "Joshua ",age="19",team="Nagoya Grampus (JPN)",number=" (9)",lastname="Kennedy " },new PlayerModel { name = "Harry ",age="45",team="Galatasaray (TUR)",number="(10)",lastname="Kewell " },new PlayerModel { name = "Brett ",age="31",team="AZ (NED)",number="(14)",lastname="Holman " },new PlayerModel { name = "Nikita ",age="3",team="Roeselare (BEL)",number="(17)",lastname="Rukavytsya " }}
             },
             {"br-brazil",new List<PlayerModel>{new PlayerModel { name = "Júlio ",age="47",team="Internazionale (ITA)",number="(1)",lastname="César " },new PlayerModel { name = "Gomes ",age="9",team="Tottenham Hotspur (ENG)",number="(12)",lastname="## " },new PlayerModel { name = "Doni ",age="10",team="Roma (ITA)",number="(22)",lastname="## " },new PlayerModel { name = "Maicon ",age="56",team="Internazionale (ITA)",number=" (2)",lastname="## " },new PlayerModel { name = "Lúcio ",age="89",team="Internazionale (ITA)",number=" (3)",lastname="## " },new PlayerModel { name = "Juan ",age="73",team="Roma (ITA)",number=" (4)",lastname="## " },new PlayerModel { name = "Michel ",age="3",team="Lyon (FRA)",number=" (6)",lastname="Bastos " },new PlayerModel { name = "Daniel ",age="33",team="Barcelona (ESP)",number="(13)",lastname="Alves " },new PlayerModel { name = "Luisão ",age="40",team="Benfica (POR)",number="(14)",lastname="## " },new PlayerModel { name = "Thiago ",age="4",team="Milan (ITA)",number="(15)",lastname="Silva " },new PlayerModel { name = "Gilberto ",age="32",team="Cruzeiro (BRA)",number="(16)",lastname="## " },new PlayerModel { name = "Felipe ",age="16",team="Juventus (ITA)",number=" (5)",lastname="Melo " },new PlayerModel { name = "Elano ",age="41",team="Galatasaray (TUR)",number=" (7)",lastname="## " },new PlayerModel { name = "Gilberto ",age="86",team="Panathinaikos (GRE)",number=" (8)",lastname="Silva " },new PlayerModel { name = "Kaká ",age="76",team="Real Madrid (ESP)",number="(10)",lastname="## " },new PlayerModel { name = "Josué ",age="26",team="VfL Wolfsburg (GER)",number="(17)",lastname="## " },new PlayerModel { name = "Ramires ",age="11",team="Benfica (POR)",number="(18)",lastname="## " },new PlayerModel { name = "Júlio ",age="45",team="Roma (ITA)",number="(19)",lastname="Baptista " },new PlayerModel { name = "Kléberson ",age="31",team="Flamengo (BRA)",number="(20)",lastname="## " },new PlayerModel { name = "Luís ",age="36",team="Sevilla (ESP)",number=" (9)",lastname="Fabiano " },new PlayerModel { name = "Robinho ",age="73",team="Santos (BRA)",number="(11)",lastname="## " },new PlayerModel { name = "Nilmar ",age="15",team="Villarreal (ESP)",number="(21)",lastname="## " },new PlayerModel { name = "Grafite ",age="2",team="VfL Wolfsburg (GER)",number="(23)",lastname="## " }}
             },
             {"ch-switzerland",new List<PlayerModel>{new PlayerModel { name = "Diego ",age="25",team="VfL Wolfsburg (GER)",number="(1)",lastname="Benaglio " },new PlayerModel { name = "Marco ",age="4",team="Young Boys (SUI)",number="(12)",lastname="Wölfli " },new PlayerModel { name = "Johnny ",age="0",team="Zürich (SUI)",number="(21)",lastname="Leoni " },new PlayerModel { name = "Stephan ",age="26",team="Lazio (ITA)",number=" (2)",lastname="Lichtsteiner " },new PlayerModel { name = "Ludovic ",age="61",team="Zürich (SUI)",number=" (3)",lastname="Magnin " },new PlayerModel { name = "Philippe ",age="38",team="Everton (ENG)",number=" (4)",lastname="Senderos " },new PlayerModel { name = "Steve ",age="10",team="Hertha BSC (GER)",number=" (5)",lastname="von " },new PlayerModel { name = "Stéphane ",age="33",team="Auxerre (FRA)",number="(13)",lastname="Grichting " },new PlayerModel { name = "Reto ",age="10",team="Sampdoria (ITA)",number="(17)",lastname="Ziegler " },new PlayerModel { name = "Mario ",age="8",team="Hannover 96 (GER)",number="(22)",lastname="Eggimann " },new PlayerModel { name = "Benjamin ",age="36",team="Basel (SUI)",number=" (6)",lastname="Huggel " },new PlayerModel { name = "Tranquillo ",age="50",team="Bayer Leverkusen (GER)",number=" (7)",lastname="Barnetta " },new PlayerModel { name = "Gökhan ",age="34",team="Udinese (ITA)",number=" (8)",lastname="Inler " },new PlayerModel { name = "Valon ",age="26",team="West Ham United (ENG)",number="(11)",lastname="Behrami " },new PlayerModel { name = "Marco ",age="7",team="Sampdoria (ITA)",number="(14)",lastname="Padalino " },new PlayerModel { name = "Hakan ",age="80",team="Luzern (SUI)",number="(15)",lastname="Yakin " },new PlayerModel { name = "Gelson ",age="22",team="Saint-Étienne (FRA)",number="(16)",lastname="Fernandes " },new PlayerModel { name = "Pirmin ",age="3",team="Eintracht Frankfurt (GER)",number="(20)",lastname="Schwegler " },new PlayerModel { name = "Xherdan ",age="1",team="Basel (SUI)",number="(23)",lastname="Shaqiri " },new PlayerModel { name = "Alexander ",age="73",team="Basel (SUI)",number=" (9)",lastname="Frei " },new PlayerModel { name = "Blaise ",age="29",team="Twente (NED)",number="(10)",lastname="Nkufo " },new PlayerModel { name = "Albert ",age="1",team="1. FC Nürnberg (GER)",number="(18)",lastname="Bunjaku " },new PlayerModel { name = "Eren ",age="19",team="Bayer Leverkusen (GER)",number="(19)",lastname="Derdiyok " }}
             },
             {"ci-cote-d-ivoire",new List<PlayerModel>{new PlayerModel { name = "Boubacar ",age="45",team="Lokeren (BEL)",number="(1)",lastname="Barry " },new PlayerModel { name = "Aristide ",age="6",team="Maccabi Netanya (ISR)",number="(16)",lastname="Zogbo " },new PlayerModel { name = "Daniel ",age="4",team="ASEC Mimosas (CIV)",number="(23)",lastname="Yeboah " },new PlayerModel { name = "Benjamin ",age="7",team="Valenciennes (FRA)",number=" (2)",lastname="Angoua " },new PlayerModel { name = "Arthur ",age="54",team="VfB Stuttgart (GER)",number=" (3)",lastname="Boka " },new PlayerModel { name = "Kolo ",age="76",team="Manchester City (ENG)",number=" (4)",lastname="Touré " },new PlayerModel { name = "Steve ",age="11",team="Wigan Athletic (ENG)",number=" (6)",lastname="Gohouri " },new PlayerModel { name = "Siaka ",age="55",team="Valenciennes (FRA)",number="(17)",lastname="Tiéné " },new PlayerModel { name = "Guy ",age="26",team="Hamburger SV (GER)",number="(20)",lastname="Demel " },new PlayerModel { name = "Emmanuel ",age="52",team="Arsenal (ENG)",number="(21)",lastname="Eboué " },new PlayerModel { name = "Sol ",age="16",team="Hibernian (SCO)",number="(22)",lastname="Bamba " },new PlayerModel { name = "Didier ",age="80",team="Sevilla (ESP)",number=" (5)",lastname="Zokora " },new PlayerModel { name = "Cheick ",age="8",team="Twente (NED)",number=" (9)",lastname="Tioté " },new PlayerModel { name = "Jean-Jacques ",age="6",team="AS Monaco (FRA)",number="(12)",lastname="Gosso " },new PlayerModel { name = "Romaric ",age="38",team="Sevilla (ESP)",number="(13)",lastname="## " },new PlayerModel { name = "Emmanuel ",age="12",team="International (ROU)",number="(14)",lastname="Koné " },new PlayerModel { name = "Kader ",age="55",team="Galatasaray (TUR)",number="(18)",lastname="Keïta " },new PlayerModel { name = "Yaya ",age="47",team="Barcelona (ESP)",number="(19)",lastname="Touré " },new PlayerModel { name = "Seydou ",age="5",team="Young Boys (SUI)",number=" (7)",lastname="Doumbia " },new PlayerModel { name = "Salomon ",age="28",team="Chelsea (ENG)",number=" (8)",lastname="Kalou " },new PlayerModel { name = "Gervinho ",age="15",team="Lille (FRA)",number="(10)",lastname="## " },new PlayerModel { name = "Didier ",age="68",team="Chelsea (ENG)",number="(11)",lastname="Drogba " },new PlayerModel { name = "Aruna ",age="54",team="Portsmouth (ENG)",number="(15)",lastname="Dindane " }}
             },
             {"cl-chile",new List<PlayerModel>{new PlayerModel { name = "Claudio ",age="41",team="Real Sociedad (ESP)",number="(1)",lastname="Bravo " },new PlayerModel { name = "Miguel ",age="13",team="Universidad de Chile (CHI)",number="(12)",lastname="Pinto " },new PlayerModel { name = "Luis ",age="2",team="Unión Española (CHI)",number="(23)",lastname="Marín " },new PlayerModel { name = "Ismael ",age="25",team="Universidad Católica (CHI)",number=" (2)",lastname="Fuentes " },new PlayerModel { name = "Waldo ",age="23",team="Universidad Católica (CHI)",number=" (3)",lastname="Ponce " },new PlayerModel { name = "Pablo ",age="49",team="PAOK (GRE)",number=" (5)",lastname="Contreras " },new PlayerModel { name = "Arturo ",age="21",team="Bayer Leverkusen (GER)",number=" (8)",lastname="Vidal " },new PlayerModel { name = "Gary ",age="23",team="Boca Juniors (ARG)",number="(17)",lastname="Medel " },new PlayerModel { name = "Gonzalo ",age="31",team="West Bromwich Albion (ENG)",number="(18)",lastname="Jara " },new PlayerModel { name = "Mauricio ",age="10",team="Udinese (ITA)",number=" (4)",lastname="Isla " },new PlayerModel { name = "Carlos ",age="18",team="Reggina (ITA)",number=" (6)",lastname="Carmona " },new PlayerModel { name = "Jorge ",age="36",team="Al-Ain (UAE)",number="(10)",lastname="Valdivia " },new PlayerModel { name = "Marco ",age="20",team="Universidad de Chile (CHI)",number="(13)",lastname="Estrada " },new PlayerModel { name = "Matías ",age="35",team="Sporting CP (POR)",number="(14)",lastname="Fernández " },new PlayerModel { name = "Gonzalo ",age="16",team="Flamengo (BRA)",number="(19)",lastname="Fierro " },new PlayerModel { name = "Rodrigo ",age="19",team="Colo-Colo (CHI)",number="(20)",lastname="Millar " },new PlayerModel { name = "Rodrigo ",age="32",team="Beşiktaş (TUR)",number="(21)",lastname="Tello " },new PlayerModel { name = "Alexis ",age="26",team="Udinese (ITA)",number=" (7)",lastname="Sánchez " },new PlayerModel { name = "Humberto ",age="41",team="Real Zaragoza (ESP)",number=" (9)",lastname="Suazo " },new PlayerModel { name = "Mark ",age="38",team="CSKA Moscow (RUS)",number="(11)",lastname="González " },new PlayerModel { name = "Jean ",age="23",team="América (MEX)",number="(15)",lastname="Beausejour " },new PlayerModel { name = "Fabián ",age="13",team="Xerez (ESP)",number="(16)",lastname="Orellana " },new PlayerModel { name = "Esteban ",age="12",team="Colo-Colo (CHI)",number="(22)",lastname="Paredes " }}
             },
             {"cm-cameroon",new List<PlayerModel>{new PlayerModel { name = "Carlos ",age="58",team="Espanyol (ESP)",number="(1)",lastname="Kameni " },new PlayerModel { name = "Souleymanou ",age="40",team="Kayserispor (TUR)",number="(16)",lastname="Hamidou " },new PlayerModel { name = "Guy ",age="0",team="Valenciennes (FRA)",number="(22)",lastname="N'dy " },new PlayerModel { name = "Benoît ",age="4",team="Tottenham Hotspur (ENG)",number=" (2)",lastname="Assou-Ekotto " },new PlayerModel { name = "Nicolas ",age="6",team="AS Monaco (FRA)",number=" (3)",lastname="N'Koulou " },new PlayerModel { name = "Rigobert ",age="133",team="Trabzonspor (TUR)",number=" (4)",lastname="Song " },new PlayerModel { name = "Sébastien ",age="3",team="Tottenham Hotspur (ENG)",number=" (5)",lastname="Bassong " },new PlayerModel { name = "Geremi ",age="109",team="Ankaragücü (TUR)",number=" (8)",lastname="## " },new PlayerModel { name = "Gaëtan ",age="0",team="Valenciennes (FRA)",number="(12)",lastname="Bong " },new PlayerModel { name = "Aurélien ",age="8",team="Lille (FRA)",number="(14)",lastname="Chedjou " },new PlayerModel { name = "Stéphane ",age="29",team="Marseille (FRA)",number="(19)",lastname="Mbia " },new PlayerModel { name = "Alex ",age="20",team="Arsenal (ENG)",number=" (6)",lastname="Song " },new PlayerModel { name = "Landry ",age="17",team="Celtic (SCO)",number=" (7)",lastname="N'Guémo " },new PlayerModel { name = "Achille ",age="32",team="Real Betis (ESP)",number="(10)",lastname="Emana " },new PlayerModel { name = "Jean ",age="46",team="Lyon (FRA)",number="(11)",lastname="Makoun " },new PlayerModel { name = "Eyong ",age="12",team="Ajax (NED)",number="(18)",lastname="Enoh " },new PlayerModel { name = "Georges ",age="4",team="1. FC Kaiserslautern (GER)",number="(20)",lastname="Mandjeck " },new PlayerModel { name = "Joël ",age="1",team="Schalke 04 (GER)",number="(21)",lastname="Matip " },new PlayerModel { name = "Samuel ",age="92",team="Internazionale (ITA)",number=" (9)",lastname="Eto'o " },new PlayerModel { name = "Eric ",age="0",team="1. FC Nürnberg (GER)",number="(13)",lastname="Choupo-Moting " },new PlayerModel { name = "Pierre ",age="39",team="Mallorca (ESP)",number="(15)",lastname="Webó " },new PlayerModel { name = "Mohammadou ",age="28",team="SC Freiburg (GER)",number="(17)",lastname="Idrissou " },new PlayerModel { name = "Vincent ",age="0",team="Cotonsport Garoua (CMR)",number="(23)",lastname="Aboubakar " }}
             },
             {"de-deutschland",new List<PlayerModel>{new PlayerModel { name = "Manuel ",age="5",team="Schalke 04 (GER)",number="(1)",lastname="Neuer " },new PlayerModel { name = "Tim ",age="2",team="Werder Bremen (GER)",number="(12)",lastname="Wiese " },new PlayerModel { name = "Hans-Jörg ",age="3",team="Bayern Munich (GER)",number="(22)",lastname="Butt " },new PlayerModel { name = "Marcell ",age="31",team="Hamburger SV (GER)",number=" (2)",lastname="Jansen " },new PlayerModel { name = "Arne ",age="72",team="Hertha BSC (GER)",number=" (3)",lastname="Friedrich " },new PlayerModel { name = "Dennis ",age="2",team="Hamburger SV (GER)",number=" (4)",lastname="Aogo " },new PlayerModel { name = "Serdar ",age="12",team="VfB Stuttgart (GER)",number=" (5)",lastname="Tasci " },new PlayerModel { name = "Holger ",age="2",team="Bayern Munich (GER)",number="(14)",lastname="Badstuber " },new PlayerModel { name = "Philipp ",age="65",team="Bayern Munich (GER)",number="(16)",lastname="Lahm " },new PlayerModel { name = "Per ",age="62",team="Werder Bremen (GER)",number="(17)",lastname="Mertesacker " },new PlayerModel { name = "Jérôme ",age="5",team="Hamburger SV (GER)",number="(20)",lastname="Boateng " },new PlayerModel { name = "Sami ",age="5",team="VfB Stuttgart (GER)",number=" (6)",lastname="Khedira " },new PlayerModel { name = "Bastian ",age="74",team="Bayern Munich (GER)",number=" (7)",lastname="Schweinsteiger " },new PlayerModel { name = "Mesut ",age="10",team="Werder Bremen (GER)",number=" (8)",lastname="Özil " },new PlayerModel { name = "Lukas ",age="73",team="1. FC Köln (GER)",number="(10)",lastname="Podolski " },new PlayerModel { name = "Thomas ",age="2",team="Bayern Munich (GER)",number="(13)",lastname="Müller " },new PlayerModel { name = "Piotr ",age="31",team="Hamburger SV (GER)",number="(15)",lastname="Trochowski " },new PlayerModel { name = "Toni ",age="4",team="Bayer Leverkusen (GER)",number="(18)",lastname="Kroos " },new PlayerModel { name = "Marko ",age="9",team="Werder Bremen (GER)",number="(21)",lastname="Marin " },new PlayerModel { name = "Stefan ",age="4",team="Bayer Leverkusen (GER)",number=" (9)",lastname="Kießling " },new PlayerModel { name = "Miroslav ",age="96",team="Bayern Munich (GER)",number="(11)",lastname="Klose " },new PlayerModel { name = "Cacau ",age="8",team="VfB Stuttgart (GER)",number="(19)",lastname="## " },new PlayerModel { name = "Mario ",age="34",team="Bayern Munich (GER)",number="(23)",lastname="Gómez " }}
             },
             {"dk-denmark",new List<PlayerModel>{new PlayerModel { name = "Thomas ",age="86",team="Stoke City (ENG)",number="(1)",lastname="Sørensen " },new PlayerModel { name = "Stephan ",age="5",team="Brøndby (DEN)",number="(16)",lastname="Andersen " },new PlayerModel { name = "Jesper ",age="11",team="København (DEN)",number="(22)",lastname="Christiansen " },new PlayerModel { name = "Simon ",age="9",team="Palermo (ITA)",number=" (3)",lastname="Kjær " },new PlayerModel { name = "Daniel ",age="30",team="Liverpool (ENG)",number=" (4)",lastname="Agger " },new PlayerModel { name = "William ",age="13",team="København (DEN)",number=" (5)",lastname="Kvist " },new PlayerModel { name = "Lars ",age="29",team="Blackburn Rovers (ENG)",number=" (6)",lastname="Jacobsen " },new PlayerModel { name = "Per ",age="28",team="Fiorentina (ITA)",number="(13)",lastname="Krøldrup " },new PlayerModel { name = "Simon ",age="4",team="AZ (NED)",number="(15)",lastname="Poulsen " },new PlayerModel { name = "Patrick ",age="2",team="Málaga (ESP)",number="(23)",lastname="Mtiliga " },new PlayerModel { name = "Christian ",age="72",team="Juventus (ITA)",number=" (2)",lastname="Poulsen " },new PlayerModel { name = "Daniel ",age="47",team="Werder Bremen (GER)",number=" (7)",lastname="Jensen " },new PlayerModel { name = "Jesper ",age="76",team="København (DEN)",number=" (8)",lastname="Grønkjær " },new PlayerModel { name = "Martin ",age="94",team="AGF (DEN)",number="(10)",lastname="Jørgensen " },new PlayerModel { name = "Thomas ",age="30",team="VfL Wolfsburg (GER)",number="(12)",lastname="Kahlenberg " },new PlayerModel { name = "Jakob ",age="11",team="AGF (DEN)",number="(14)",lastname="Poulsen " },new PlayerModel { name = "Mikkel ",age="3",team="Randers (DEN)",number="(17)",lastname="Beckmann " },new PlayerModel { name = "Dennis ",age="94",team="Ajax (NED)",number="(19)",lastname="Rommedahl " },new PlayerModel { name = "Thomas ",age="4",team="Groningen (NED)",number="(20)",lastname="Enevoldsen " },new PlayerModel { name = "Christian ",age="2",team="Ajax (NED)",number="(21)",lastname="Eriksen " },new PlayerModel { name = "Jon ",age="108",team="Feyenoord (NED)",number=" (9)",lastname="Dahl " },new PlayerModel { name = "Nicklas ",age="32",team="Arsenal (ENG)",number="(11)",lastname="Bendtner " },new PlayerModel { name = "Søren ",age="17",team="MSV Duisburg (GER)",number="(18)",lastname="Larsen " }}
             },
             {"dz-algeria",new List<PlayerModel>{new PlayerModel { name = "Lounès ",age="48",team="ASO Chlef (ALG)",number="(1)",lastname="Gaouaoui " },new PlayerModel { name = "Faouzi ",age="9",team="ES Sétif (ALG)",number="(16)",lastname="Chaouchi " },new PlayerModel { name = "Raïs ",age="1",team="Slavia Sofia (BUL)",number="(23)",lastname="M'Bohli " },new PlayerModel { name = "Madjid ",age="40",team="Rangers (SCO)",number=" (2)",lastname="Bougherra " },new PlayerModel { name = "Nadir ",age="44",team="Portsmouth (ENG)",number=" (3)",lastname="Belhadj " },new PlayerModel { name = "Antar ",age="43",team="VfL Bochum (GER)",number=" (4)",lastname="Yahia " },new PlayerModel { name = "Rafik ",age="15",team="Nacional (POR)",number=" (5)",lastname="Halliche " },new PlayerModel { name = "Habib ",age="1",team="Eintracht Frankfurt (GER)",number="(12)",lastname="Bellaïd " },new PlayerModel { name = "Abdelkader ",age="6",team="ES Sétif (ALG)",number="(14)",lastname="Laïfaoui " },new PlayerModel { name = "Carl ",age="0",team="Ajaccio (FRA)",number="(18)",lastname="Medjani " },new PlayerModel { name = "Djamel ",age="1",team="Lecce (ITA)",number="(20)",lastname="Mesbah " },new PlayerModel { name = "Yazid ",age="66",team="Lorient (FRA)",number=" (6)",lastname="Mansouri " },new PlayerModel { name = "Ryad ",age="1",team="Sochaux (FRA)",number=" (7)",lastname="Boudebouz " },new PlayerModel { name = "Medhi ",age="2",team="Racing Santander (ESP)",number=" (8)",lastname="Lacen " },new PlayerModel { name = "Karim ",age="54",team="VfL Wolfsburg (GER)",number="(15)",lastname="Ziani " },new PlayerModel { name = "Adlène ",age="1",team="Wolverhampton Wanderers (ENG)",number="(17)",lastname="Guedioura " },new PlayerModel { name = "Hassan ",age="9",team="Portsmouth (ENG)",number="(19)",lastname="Yebda " },new PlayerModel { name = "Foued ",age="1",team="Valenciennes (FRA)",number="(21)",lastname="Kadir " },new PlayerModel { name = "Djamel ",age="6",team="Nantes (FRA)",number="(22)",lastname="Abdoun " },new PlayerModel { name = "Abdelkader ",age="18",team="Siena (ITA)",number=" (9)",lastname="Ghezzal " },new PlayerModel { name = "Rafik ",age="59",team="Istres (FRA)",number="(10)",lastname="Saïfi " },new PlayerModel { name = "Rafik ",age="15",team="AEK (GRE)",number="(11)",lastname="Djebbour " },new PlayerModel { name = "Karim ",age="21",team="Borussia Mönchengladbach (GER)",number="(13)",lastname="Matmour " }}
             },
             {"en-england",new List<PlayerModel>{new PlayerModel { name = "David ",age="50",team="Portsmouth (ENG)",number="(1)",lastname="James " },new PlayerModel { name = "Robert ",age="10",team="West Ham United (ENG)",number="(12)",lastname="Green " },new PlayerModel { name = "Joe ",age="3",team="Birmingham City (ENG)",number="(23)",lastname="Hart " },new PlayerModel { name = "Glen ",age="22",team="Liverpool (ENG)",number=" (2)",lastname="Johnson " },new PlayerModel { name = "Ashley ",age="78",team="Chelsea (ENG)",number=" (3)",lastname="Cole " },new PlayerModel { name = "Michael ",age="0",team="Tottenham Hotspur (ENG)",number=" (5)",lastname="Dawson " },new PlayerModel { name = "John ",age="60",team="Chelsea (ENG)",number=" (6)",lastname="Terry " },new PlayerModel { name = "Stephen ",age="1",team="Aston Villa (ENG)",number="(13)",lastname="Warnock " },new PlayerModel { name = "Matthew ",age="19",team="West Ham United (ENG)",number="(15)",lastname="Upson " },new PlayerModel { name = "Jamie ",age="36",team="Liverpool (ENG)",number="(18)",lastname="Carragher " },new PlayerModel { name = "Ledley ",age="20",team="Tottenham Hotspur (ENG)",number="(20)",lastname="King " },new PlayerModel { name = "Steven ",age="80",team="Liverpool (ENG)",number=" (4)",lastname="Gerrard " },new PlayerModel { name = "Aaron ",age="17",team="Tottenham Hotspur (ENG)",number=" (7)",lastname="Lennon " },new PlayerModel { name = "Frank ",age="78",team="Chelsea (ENG)",number=" (8)",lastname="Lampard " },new PlayerModel { name = "Joe ",age="54",team="Chelsea (ENG)",number="(11)",lastname="Cole " },new PlayerModel { name = "Gareth ",age="36",team="Manchester City (ENG)",number="(14)",lastname="Barry " },new PlayerModel { name = "James ",age="8",team="Aston Villa (ENG)",number="(16)",lastname="Milner " },new PlayerModel { name = "Shaun ",age="31",team="Manchester City (ENG)",number="(17)",lastname="Wright-Phillips " },new PlayerModel { name = "Michael ",age="22",team="Manchester United (ENG)",number="(22)",lastname="Carrick " },new PlayerModel { name = "Peter ",age="38",team="Tottenham Hotspur (ENG)",number=" (9)",lastname="Crouch " },new PlayerModel { name = "Wayne ",age="60",team="Manchester United (ENG)",number="(10)",lastname="Rooney " },new PlayerModel { name = "Jermain ",age="39",team="Tottenham Hotspur (ENG)",number="(19)",lastname="Defoe " },new PlayerModel { name = "Emile ",age="58",team="Aston Villa (ENG)",number="(21)",lastname="Heskey " }}
             },
             {"es-espana",new List<PlayerModel>{new PlayerModel { name = "Iker ",age="104",team="Real Madrid (ESP)",number="(1)",lastname="Casillas " },new PlayerModel { name = "Víctor ",age="1",team="Barcelona (ESP)",number="(12)",lastname="Valdés " },new PlayerModel { name = "Pepe ",age="20",team="Liverpool (ENG)",number="(23)",lastname="Reina " },new PlayerModel { name = "Raúl ",age="23",team="Real Madrid (ESP)",number=" (2)",lastname="Albiol " },new PlayerModel { name = "Gerard ",age="16",team="Barcelona (ESP)",number=" (3)",lastname="Piqué " },new PlayerModel { name = "Carlos ",age="59",team="Valencia (ESP)",number=" (4)",lastname="Marchena " },new PlayerModel { name = "Carles ",age="83",team="Barcelona (ESP)",number=" (5)",lastname="Puyol " },new PlayerModel { name = "Joan ",age="46",team="Villarreal (ESP)",number="(11)",lastname="Capdevila " },new PlayerModel { name = "Sergio ",age="60",team="Real Madrid (ESP)",number="(15)",lastname="Ramos " },new PlayerModel { name = "Álvaro ",age="15",team="Real Madrid (ESP)",number="(17)",lastname="Arbeloa " },new PlayerModel { name = "Andrés ",age="43",team="Barcelona (ESP)",number=" (6)",lastname="Iniesta " },new PlayerModel { name = "Xavi ",age="87",team="Barcelona (ESP)",number=" (8)",lastname="## " },new PlayerModel { name = "Cesc ",age="49",team="Arsenal (ENG)",number="(10)",lastname="Fàbregas " },new PlayerModel { name = "Juan ",age="8",team="Valencia (ESP)",number="(13)",lastname="Mata " },new PlayerModel { name = "Xabi ",age="69",team="Real Madrid (ESP)",number="(14)",lastname="Alonso " },new PlayerModel { name = "Sergio ",age="13",team="Barcelona (ESP)",number="(16)",lastname="Busquets " },new PlayerModel { name = "Javi ",age="2",team="Athletic Bilbao (ESP)",number="(20)",lastname="Martínez " },new PlayerModel { name = "David ",age="36",team="Valencia (ESP)",number="(21)",lastname="Silva " },new PlayerModel { name = "Jesús ",age="6",team="Sevilla (ESP)",number="(22)",lastname="Navas " },new PlayerModel { name = "David ",age="58",team="Valencia (ESP)",number=" (7)",lastname="Villa " },new PlayerModel { name = "Fernando ",age="73",team="Liverpool (ENG)",number=" (9)",lastname="Torres " },new PlayerModel { name = "Pedro ",age="3",team="Barcelona (ESP)",number="(18)",lastname="## " },new PlayerModel { name = "Fernando ",age="7",team="Athletic Bilbao (ESP)",number="(19)",lastname="Llorente " }}
             },
             {"fr-france",new List<PlayerModel>{new PlayerModel { name = "Hugo ",age="11",team="Lyon (FRA)",number="(1)",lastname="Lloris " },new PlayerModel { name = "Steve ",age="13",team="Marseille (FRA)",number="(16)",lastname="Mandanda " },new PlayerModel { name = "Cédric ",age="0",team="Bordeaux (FRA)",number="(23)",lastname="Carrasso " },new PlayerModel { name = "Bacary ",age="20",team="Arsenal (ENG)",number=" (2)",lastname="Sagna " },new PlayerModel { name = "Éric ",age="54",team="Barcelona (ESP)",number=" (3)",lastname="Abidal " },new PlayerModel { name = "Anthony ",age="6",team="Lyon (FRA)",number=" (4)",lastname="Réveillère " },new PlayerModel { name = "William ",age="81",team="Arsenal (ENG)",number=" (5)",lastname="Gallas " },new PlayerModel { name = "Marc ",age="1",team="Bordeaux (FRA)",number=" (6)",lastname="Planus " },new PlayerModel { name = "Patrice ",age="30",team="Manchester United (ENG)",number="(13)",lastname="Evra " },new PlayerModel { name = "Sébastien ",age="20",team="Arsenal (ENG)",number="(17)",lastname="Squillaci " },new PlayerModel { name = "Gaël ",age="4",team="Arsenal (ENG)",number="(22)",lastname="Clichy " },new PlayerModel { name = "Franck ",age="45",team="Bayern Munich (GER)",number=" (7)",lastname="Ribéry " },new PlayerModel { name = "Yoann ",age="20",team="Lyon (FRA)",number=" (8)",lastname="Gourcuff " },new PlayerModel { name = "Jérémy ",age="34",team="Lyon (FRA)",number="(14)",lastname="Toulalan " },new PlayerModel { name = "Florent ",age="54",team="Chelsea (ENG)",number="(15)",lastname="Malouda " },new PlayerModel { name = "Alou ",age="25",team="Bordeaux (FRA)",number="(18)",lastname="Diarra " },new PlayerModel { name = "Abou ",age="5",team="Arsenal (ENG)",number="(19)",lastname="Diaby " },new PlayerModel { name = "Mathieu ",age="2",team="Marseille (FRA)",number="(20)",lastname="Valbuena " },new PlayerModel { name = "Djibril ",age="39",team="Panathinaikos (GRE)",number=" (9)",lastname="Cissé " },new PlayerModel { name = "Sidney ",age="46",team="Lyon (FRA)",number="(10)",lastname="Govou " },new PlayerModel { name = "André-Pierre ",age="13",team="Marseille (FRA)",number="(11)",lastname="Gignac " },new PlayerModel { name = "Thierry ",age="121",team="Barcelona (ESP)",number="(12)",lastname="Henry " },new PlayerModel { name = "Nicolas ",age="67",team="Chelsea (ENG)",number="(21)",lastname="Anelka " }}
             },
             {"gh-ghana",new List<PlayerModel>{new PlayerModel { name = "Daniel ",age="2",team="Liberty Professionals (GHA)",number="(1)",lastname="Adjei " },new PlayerModel { name = "Stephen ",age="0",team="Heart of Lions (GHA)",number="(16)",lastname="Ahorlu " },new PlayerModel { name = "Richard ",age="58",team="Wigan Athletic (ENG)",number="(22)",lastname="Kingson " },new PlayerModel { name = "Hans ",age="23",team="Bayer Leverkusen (GER)",number=" (2)",lastname="Sarpei " },new PlayerModel { name = "John ",age="65",team="Fulham (ENG)",number=" (4)",lastname="Paintsil " },new PlayerModel { name = "John ",age="58",team="Sunderland (ENG)",number=" (5)",lastname="Mensah " },new PlayerModel { name = "Samuel ",age="15",team="Basel (SUI)",number=" (7)",lastname="Inkoom " },new PlayerModel { name = "Jonathan ",age="3",team="Granada (ESP)",number=" (8)",lastname="Mensah " },new PlayerModel { name = "Isaac ",age="6",team="1899 Hoffenheim (GER)",number="(15)",lastname="Vorsah " },new PlayerModel { name = "Abdul ",age="6",team="Zamalek (EGY)",number="(17)",lastname="Rahim " },new PlayerModel { name = "Lee ",age="3",team="Bechem Chelsea (GHA)",number="(19)",lastname="Addy " },new PlayerModel { name = "Anthony ",age="38",team="Rosenborg (NOR)",number=" (6)",lastname="Annan " },new PlayerModel { name = "Derek ",age="19",team="Getafe (ESP)",number=" (9)",lastname="Boateng " },new PlayerModel { name = "Stephen ",age="56",team="Bologna (ITA)",number="(10)",lastname="Appiah " },new PlayerModel { name = "Sulley ",age="52",team="Internazionale (ITA)",number="(11)",lastname="Muntari " },new PlayerModel { name = "André ",age="15",team="Arles-Avignon (FRA)",number="(13)",lastname="Ayew " },new PlayerModel { name = "Quincy ",age="12",team="Al-Sadd (QAT)",number="(20)",lastname="Owusu-Abeyie " },new PlayerModel { name = "Kwadwo ",age="29",team="Udinese (ITA)",number="(21)",lastname="Asamoah " },new PlayerModel { name = "Kevin-Prince ",age="0",team="Portsmouth (ENG)",number="(23)",lastname="Boateng " },new PlayerModel { name = "Asamoah ",age="32",team="Rennes (FRA)",number=" (3)",lastname="Gyan " },new PlayerModel { name = "Prince ",age="17",team="1899 Hoffenheim (GER)",number="(12)",lastname="Tagoe " },new PlayerModel { name = "Matthew ",age="31",team="NAC (NED)",number="(14)",lastname="Amoah " },new PlayerModel { name = "Dominic ",age="4",team="Milan (ITA)",number="(18)",lastname="Adiyiah " }}
             },
             {"gr-greece",new List<PlayerModel>{new PlayerModel { name = "Kostas ",age="27",team="PAOK (GRE)",number="(1)",lastname="Chalkias " },new PlayerModel { name = "Alexandros ",age="6",team="Panathinaikos (GRE)",number="(12)",lastname="Tzorvas " },new PlayerModel { name = "Michalis ",age="1",team="Aris (GRE)",number="(13)",lastname="Sifakis " },new PlayerModel { name = "Giourkas ",age="67",team="Panathinaikos (GRE)",number=" (2)",lastname="Seitaridis " },new PlayerModel { name = "Christos ",age="41",team="Omonia (CYP)",number=" (3)",lastname="Patsatzoglou " },new PlayerModel { name = "Vangelis ",age="10",team="Bologna (ITA)",number=" (5)",lastname="Moras " },new PlayerModel { name = "Avraam ",age="12",team="Olympiakos (GRE)",number=" (8)",lastname="Papadopoulos " },new PlayerModel { name = "Loukas ",age="27",team="Panathinaikos (GRE)",number="(11)",lastname="Vyntra " },new PlayerModel { name = "Vasilis ",age="25",team="Olympiakos (GRE)",number="(15)",lastname="Torosidis " },new PlayerModel { name = "Sotirios ",age="56",team="Liverpool (ENG)",number="(16)",lastname="Kyrgiakos " },new PlayerModel { name = "Sokratis ",age="10",team="Genoa (ITA)",number="(19)",lastname="Papastathopoulos " },new PlayerModel { name = "Stelios ",age="0",team="PAOK (GRE)",number="(22)",lastname="Malezas " },new PlayerModel { name = "Nikos ",age="17",team="Panathinaikos (GRE)",number=" (4)",lastname="Spiropoulos " },new PlayerModel { name = "Alexandros ",age="17",team="Siena (ITA)",number=" (6)",lastname="Tziolis " },new PlayerModel { name = "Giorgos ",age="91",team="Panathinaikos (GRE)",number="(10)",lastname="Karagounis " },new PlayerModel { name = "Sotiris ",age="3",team="Panathinaikos (GRE)",number="(18)",lastname="Ninis " },new PlayerModel { name = "Kostas ",age="67",team="Panathinaikos (GRE)",number="(21)",lastname="Katsouranis " },new PlayerModel { name = "Sakis ",age="0",team="Aris (GRE)",number="(23)",lastname="Prittas " },new PlayerModel { name = "Georgios ",age="32",team="Celtic (SCO)",number=" (7)",lastname="Samaras " },new PlayerModel { name = "Angelos ",age="82",team="1. FC Nürnberg (GER)",number=" (9)",lastname="Charisteas " },new PlayerModel { name = "Dimitris ",age="34",team="Panathinaikos (GRE)",number="(14)",lastname="Salpingidis " },new PlayerModel { name = "Theofanis ",age="46",team="Hertha BSC (GER)",number="(17)",lastname="Gekas " },new PlayerModel { name = "Pantelis ",age="3",team="Steaua Bucureşti (ROM)",number="(20)",lastname="Kapetanos " }}
             },
             {"hn-honduras",new List<PlayerModel>{new PlayerModel { name = "Ricardo ",age="2",team="Motagua (HON)",number="(1)",lastname="Canales " },new PlayerModel { name = "Noel ",age="71",team="Olimpia (HON)",number="(18)",lastname="Valladares " },new PlayerModel { name = "Donis ",age="11",team="Olimpia (HON)",number="(22)",lastname="Escober " },new PlayerModel { name = "Osman ",age="26",team="Platense (HON)",number=" (2)",lastname="Chávez " },new PlayerModel { name = "Maynor ",age="66",team="Wigan Athletic (ENG)",number=" (3)",lastname="Figueroa " },new PlayerModel { name = "Johnny ",age="4",team="Olimpia (HON)",number=" (4)",lastname="Palacios " },new PlayerModel { name = "Víctor ",age="40",team="Anderlecht (BEL)",number=" (5)",lastname="Bernárdez " },new PlayerModel { name = "Oscar ",age="42",team="Olimpia (HON)",number="(14)",lastname="García " },new PlayerModel { name = "Mauricio ",age="25",team="Hangzhou Greentown (CHN)",number="(16)",lastname="Sabillón " },new PlayerModel { name = "Emilio ",age="39",team="Motagua (HON)",number="(21)",lastname="Izaguirre " },new PlayerModel { name = "Sergio ",age="46",team="Motagua (HON)",number="(23)",lastname="Mendoza " },new PlayerModel { name = "Hendry ",age="39",team="Wigan Athletic (ENG)",number=" (6)",lastname="Thomas " },new PlayerModel { name = "Ramón ",age="16",team="Olimpia (HON)",number=" (7)",lastname="Núñez " },new PlayerModel { name = "Wilson ",age="69",team="Tottenham Hotspur (ENG)",number=" (8)",lastname="Palacios " },new PlayerModel { name = "Edgar ",age="46",team="Bari",number="(17)",lastname="Álvarez " },new PlayerModel { name = "Danilo ",age="82",team="Olimpia (HON)",number="(19)",lastname="Turcios " },new PlayerModel { name = "Amado ",age="133",team="Motagua (HON)",number="(20)",lastname="Guevara " },new PlayerModel { name = "Carlos ",age="98",team="Real España (HON)",number=" (9)",lastname="Pavón " },new PlayerModel { name = "Jerry ",age="11",team="Hangzhou Greentown (CHN)",number="(10)",lastname="Palacios " },new PlayerModel { name = "David ",age="50",team="Genoa (ITA)",number="(11)",lastname="Suazo " },new PlayerModel { name = "Georgie ",age="11",team="Motagua (HON)",number="(12)",lastname="Welcome " },new PlayerModel { name = "Roger ",age="10",team="Kansas City Wizards (USA)",number="(13)",lastname="Espinoza " },new PlayerModel { name = "Walter ",age="34",team="Marathón (HON)",number="(15)",lastname="Martínez " }}
             },
             {"it-italy",new List<PlayerModel>{new PlayerModel { name = "Gianluigi ",age="101",team="Juventus (ITA)",number="(1)",lastname="Buffon " },new PlayerModel { name = "Federico ",age="5",team="Cagliari (ITA)",number="(12)",lastname="Marchetti " },new PlayerModel { name = "Morgan ",age="3",team="Napoli (ITA)",number="(14)",lastname="De " },new PlayerModel { name = "Christian ",age="5",team="Napoli (ITA)",number=" (2)",lastname="Maggio " },new PlayerModel { name = "Domenico ",age="7",team="Genoa (ITA)",number=" (3)",lastname="Criscito " },new PlayerModel { name = "Giorgio ",age="29",team="Juventus (ITA)",number=" (4)",lastname="Chiellini " },new PlayerModel { name = "Fabio ",age="133",team="Juventus (ITA)",number=" (5)",lastname="Cannavaro " },new PlayerModel { name = "Salvatore ",age="5",team="Genoa (ITA)",number="(13)",lastname="Bocchetti " },new PlayerModel { name = "Gianluca ",age="94",team="Milan (ITA)",number="(19)",lastname="Zambrotta " },new PlayerModel { name = "Leonardo ",age="2",team="Bari (ITA)",number="(23)",lastname="Bonucci " },new PlayerModel { name = "Daniele ",age="54",team="Roma (ITA)",number=" (6)",lastname="De " },new PlayerModel { name = "Simone ",age="15",team="Udinese (ITA)",number=" (7)",lastname="Pepe " },new PlayerModel { name = "Gennaro ",age="72",team="Milan (ITA)",number=" (8)",lastname="Gattuso " },new PlayerModel { name = "Claudio ",age="4",team="Juventus (ITA)",number="(15)",lastname="Marchisio " },new PlayerModel { name = "Mauro ",age="53",team="Juventus (ITA)",number="(16)",lastname="Camoranesi " },new PlayerModel { name = "Angelo ",age="17",team="Sampdoria (ITA)",number="(17)",lastname="Palombo " },new PlayerModel { name = "Andrea ",age="66",team="Milan (ITA)",number="(21)",lastname="Pirlo " },new PlayerModel { name = "Riccardo ",age="13",team="Fiorentina (ITA)",number="(22)",lastname="Montolivo " },new PlayerModel { name = "Vincenzo ",age="37",team="Juventus (ITA)",number=" (9)",lastname="Iaquinta " },new PlayerModel { name = "Antonio ",age="33",team="Udinese (ITA)",number="(10)",lastname="Di " },new PlayerModel { name = "Alberto ",age="41",team="Fiorentina (ITA)",number="(11)",lastname="Gilardino " },new PlayerModel { name = "Fabio ",age="20",team="Napoli (ITA)",number="(18)",lastname="Quagliarella " },new PlayerModel { name = "Giampaolo ",age="8",team="Sampdoria (ITA)",number="(20)",lastname="Pazzini " }}
             },
             {"jp-japan",new List<PlayerModel>{new PlayerModel { name = "Seigo ",age="76",team="Nagoya Grampus (JPN)",number="(1)",lastname="Narazaki " },new PlayerModel { name = "Eiji ",age="10",team="Kawasaki Frontale (JPN)",number="(21)",lastname="Kawashima " },new PlayerModel { name = "Yoshikatsu ",age="116",team="Júbilo Iwata (JPN)",number="(23)",lastname="Kawaguchi " },new PlayerModel { name = "Yūichi ",age="53",team="Júbilo Iwata (JPN)",number=" (3)",lastname="Komano " },new PlayerModel { name = "Marcus ",age="39",team="Nagoya Grampus (JPN)",number=" (4)",lastname="Tulio " },new PlayerModel { name = "Yuto ",age="26",team="FC Tokyo (JPN)",number=" (5)",lastname="Nagatomo " },new PlayerModel { name = "Atsuto ",age="31",team="Kashima Antlers (JPN)",number=" (6)",lastname="Uchida " },new PlayerModel { name = "Daiki ",age="2",team="Kashima Antlers (JPN)",number="(13)",lastname="Iwamasa " },new PlayerModel { name = "Yasuyuki ",age="37",team="FC Tokyo (JPN)",number="(15)",lastname="Konno " },new PlayerModel { name = "Yuji ",age="105",team="Yokohama F. Marinos (JPN)",number="(22)",lastname="Nakazawa " },new PlayerModel { name = "Yuki ",age="45",team="Urawa Red Diamonds (JPN)",number=" (2)",lastname="Abe " },new PlayerModel { name = "Yasuhito ",age="94",team="Gamba Osaka (JPN)",number=" (7)",lastname="Endō " },new PlayerModel { name = "Shunsuke ",age="97",team="Yokohama F. Marinos (JPN)",number="(10)",lastname="Nakamura " },new PlayerModel { name = "Kengo ",age="47",team="Kawasaki Frontale (JPN)",number="(14)",lastname="Nakamura " },new PlayerModel { name = "Makoto ",age="31",team="VfL Wolfsburg (GER)",number="(17)",lastname="Hasebe " },new PlayerModel { name = "Keisuke ",age="15",team="CSKA Moscow (RUS)",number="(18)",lastname="Honda " },new PlayerModel { name = "Junichi ",age="80",team="Kawasaki Frontale (JPN)",number="(20)",lastname="Inamoto " },new PlayerModel { name = "Daisuke ",age="23",team="Grenoble (FRA)",number=" (8)",lastname="Matsui " },new PlayerModel { name = "Shinji ",age="28",team="Shimizu S-Pulse (JPN)",number=" (9)",lastname="Okazaki " },new PlayerModel { name = "Keiji ",age="70",team="Nagoya Grampus (JPN)",number="(11)",lastname="Tamada " },new PlayerModel { name = "Kisho ",age="18",team="Albirex Niigata (JPN)",number="(12)",lastname="Yano " },new PlayerModel { name = "Yoshito ",age="49",team="Vissel Kobe (JPN)",number="(16)",lastname="Ōkubo " },new PlayerModel { name = "Takayuki ",age="6",team="Catania (ITA)",number="(19)",lastname="Morimoto " }}
             },
             {"kp-north-korea",new List<PlayerModel>{new PlayerModel { name = "Ri ",age="28",team="Pyongyang City (PRK)",number="(1)",lastname="Myong-Guk " },new PlayerModel { name = "Kim ",age="10",team="Amrokgang (PRK)",number="(18)",lastname="Myong-Gil " },new PlayerModel { name = "Kim ",age="9",team="Amrokgang (PRK)",number="(20)",lastname="Myong-Won " },new PlayerModel { name = "Cha ",age="31",team="Amrokgang (PRK)",number=" (2)",lastname="Jong-Hyok " },new PlayerModel { name = "Ri ",age="26",team="Sobaeksu (PRK)",number=" (3)",lastname="Jun-Il " },new PlayerModel { name = "Ri ",age="41",team="April 25 (PRK)",number=" (5)",lastname="Kwang-Chon " },new PlayerModel { name = "Ji ",age="23",team="April 25 (PRK)",number=" (8)",lastname="Yun-Nam " },new PlayerModel { name = "Pak ",age="34",team="Amrokgang (PRK)",number="(13)",lastname="Chol-Jin " },new PlayerModel { name = "Pak ",age="12",team="Amrokgang (PRK)",number="(14)",lastname="Nam-Chol " },new PlayerModel { name = "Nam ",age="41",team="April 25 (PRK)",number="(16)",lastname="Song-Chol " },new PlayerModel { name = "Ri ",age="15",team="Kyonggongop (PRK)",number="(21)",lastname="Kwang-Hyok " },new PlayerModel { name = "Pak ",age="35",team="April 25 (PRK)",number=" (4)",lastname="Nam-Chol " },new PlayerModel { name = "Kim ",age="11",team="April 25 (PRK)",number=" (6)",lastname="Kum-Il " },new PlayerModel { name = "Mun ",age="42",team="April 25 (PRK)",number="(11)",lastname="In-Guk " },new PlayerModel { name = "Kim ",age="52",team="Pyongyang City (PRK)",number="(15)",lastname="Yong-Jun " },new PlayerModel { name = "An ",age="24",team="Omiya Ardija (JPN)",number="(17)",lastname="Yong-Hak " },new PlayerModel { name = "Ri ",age="10",team="Pyongyang City (PRK)",number="(19)",lastname="Chol-Myong " },new PlayerModel { name = "Kim ",age="7",team="Rimyongsu (PRK)",number="(22)",lastname="Kyong-Il " },new PlayerModel { name = "Pak ",age="3",team="Sobaeksu (PRK)",number="(23)",lastname="Sung-Hyok " },new PlayerModel { name = "An ",age="16",team="Rimyongsu (PRK)",number=" (7)",lastname="Chol-Hyok " },new PlayerModel { name = "Jong ",age="20",team="Kawasaki Frontale (JPN)",number=" (9)",lastname="Tae-Se " },new PlayerModel { name = "Hong ",age="40",team="Rostov (RUS)",number="(10)",lastname="Yong-Jo " },new PlayerModel { name = "Choe ",age="16",team="April 25 (PRK)",number="(12)",lastname="Kum-Chol " }}
             },
             {"kr-south-korea",new List<PlayerModel>{new PlayerModel { name = "Lee ",age="130",team="Suwon Samsung Bluewings (KOR)",number="(1)",lastname="Woon-Jae " },new PlayerModel { name = "Jung ",age="15",team="Seongnam Ilhwa Chunma (KOR)",number="(18)",lastname="Sung-Ryong " },new PlayerModel { name = "Kim ",age="14",team="Ulsan Hyundai (KOR)",number="(21)",lastname="Young-Kwang " },new PlayerModel { name = "Oh ",age="37",team="Ulsan Hyundai (KOR)",number=" (2)",lastname="Beom-Seok " },new PlayerModel { name = "Kim ",age="2",team="Pohang Steelers (KOR)",number=" (3)",lastname="Hyung-Il " },new PlayerModel { name = "Lee ",age="112",team="Al-Hilal (KSA)",number="(12)",lastname="Young-Pyo " },new PlayerModel { name = "Lee ",age="24",team="Kashima Antlers (JPN)",number="(14)",lastname="Jung-Soo " },new PlayerModel { name = "Kim ",age="61",team="Ulsan Hyundai (KOR)",number="(15)",lastname="Dong-Jin " },new PlayerModel { name = "Cha ",age="46",team="SC Freiburg (GER)",number="(22)",lastname="Du-Ri " },new PlayerModel { name = "Kang ",age="31",team="Suwon Samsung Bluewings (KOR)",number="(23)",lastname="Min-Soo " },new PlayerModel { name = "Cho ",age="31",team="Jeju United (KOR)",number=" (4)",lastname="Yong-Hyung " },new PlayerModel { name = "Kim ",age="92",team="Tom Tomsk (RUS)",number=" (5)",lastname="Nam-Il " },new PlayerModel { name = "Kim ",age="6",team="Oita Trinita (JPN)",number=" (6)",lastname="Bo-Kyung " },new PlayerModel { name = "Park ",age="88",team="Manchester United (ENG)",number=" (7)",lastname="Ji-Sung " },new PlayerModel { name = "Kim ",age="7",team="Pohang Steelers (KOR)",number="(13)",lastname="Jae-Sung " },new PlayerModel { name = "Ki ",age="21",team="Celtic (SCO)",number="(16)",lastname="Sung-Yong " },new PlayerModel { name = "Lee ",age="23",team="Bolton Wanderers (ENG)",number="(17)",lastname="Chung-Yong " },new PlayerModel { name = "Kim ",age="54",team="Gwangju Sangmu (KOR)",number=" (8)",lastname="Jung-Woo " },new PlayerModel { name = "Ahn ",age="70",team="Dalian Shide (CHN)",number=" (9)",lastname="Jung-Hwan " },new PlayerModel { name = "Park ",age="40",team="AS Monaco (FRA)",number="(10)",lastname="Chu-Young " },new PlayerModel { name = "Lee ",age="8",team="FC Seoul (KOR)",number="(11)",lastname="Seung-Yeoul " },new PlayerModel { name = "Yeom ",age="33",team="Suwon Samsung Bluewings (KOR)",number="(19)",lastname="Ki-Hun " },new PlayerModel { name = "Lee ",age="83",team="Jeonbuk Hyundai Motors (KOR)",number="(20)",lastname="Dong-Gook " }}
             },
             {"mx-mexico",new List<PlayerModel>{new PlayerModel { name = "Óscar ",age="52",team="Chiapas (MEX)",number="(1)",lastname="Pérez " },new PlayerModel { name = "Guillermo ",age="37",team="América (MEX)",number="(13)",lastname="Ochoa " },new PlayerModel { name = "Luis ",age="4",team="Guadalajara (MEX)",number="(23)",lastname="Ernesto " },new PlayerModel { name = "Francisco ",age="48",team="PSV Eindhoven (NED)",number=" (2)",lastname="Rodríguez " },new PlayerModel { name = "Carlos ",age="73",team="PSV Eindhoven (NED)",number=" (3)",lastname="Salcido " },new PlayerModel { name = "Rafael ",age="91",team="Barcelona (ESP)",number=" (4)",lastname="Márquez " },new PlayerModel { name = "Ricardo ",age="76",team="VfB Stuttgart (GER)",number=" (5)",lastname="Osorio " },new PlayerModel { name = "Paul ",age="10",team="Pachuca (MEX)",number="(12)",lastname="Aguilar " },new PlayerModel { name = "Héctor ",age="10",team="AZ (NED)",number="(15)",lastname="Moreno " },new PlayerModel { name = "Efraín ",age="19",team="UNAM (MEX)",number="(16)",lastname="Juárez " },new PlayerModel { name = "Jonny ",age="52",team="Guadalajara (MEX)",number="(19)",lastname="Magallón " },new PlayerModel { name = "Jorge ",age="8",team="Atlas (MEX)",number="(20)",lastname="Torres " },new PlayerModel { name = "Gerardo ",age="114",team="Cruz Azul (MEX)",number=" (6)",lastname="Torrado " },new PlayerModel { name = "Pablo ",age="21",team="UNAM (MEX)",number=" (7)",lastname="Barrera " },new PlayerModel { name = "Israel ",age="31",team="UNAM (MEX)",number=" (8)",lastname="Castro " },new PlayerModel { name = "Andrés ",age="56",team="Deportivo La Coruña (ESP)",number="(18)",lastname="Guardado " },new PlayerModel { name = "Alberto ",age="56",team="Guadalajara (MEX)",number="(22)",lastname="Medina " },new PlayerModel { name = "Guillermo ",age="21",team="West Ham United (ENG)",number=" (9)",lastname="Franco " },new PlayerModel { name = "Cuauhtémoc ",age="115",team="Veracruz (MEX)",number="(10)",lastname="Blanco " },new PlayerModel { name = "Carlos ",age="28",team="Arsenal (ENG)",number="(11)",lastname="Vela " },new PlayerModel { name = "Javier ",age="12",team="Guadalajara (MEX)",number="(14)",lastname="Hernández " },new PlayerModel { name = "Giovani ",age="26",team="Galatasaray (TUR)",number="(17)",lastname="dos " },new PlayerModel { name = "Adolfo ",age="37",team="Guadalajara (MEX)",number="(21)",lastname="Bautista " }}
             },
             {"ng-nigeria",new List<PlayerModel>{new PlayerModel { name = "Vincent ",age="51",team="Hapoel Tel Aviv (ISR)",number="(1)",lastname="Enyeama " },new PlayerModel { name = "Austin ",age="16",team="Hapoel Petah Tikva (ISR)",number="(16)",lastname="Ejide " },new PlayerModel { name = "Dele ",age="9",team="Bnei Yehuda (ISR)",number="(23)",lastname="Aiyenugba " },new PlayerModel { name = "Joseph ",age="64",team="Everton (ENG)",number=" (2)",lastname="Yobo " },new PlayerModel { name = "Taye ",age="35",team="Marseille (FRA)",number=" (3)",lastname="Taiwo " },new PlayerModel { name = "Rabiu ",age="12",team="Red Bull Salzburg (AUT)",number=" (5)",lastname="Afolabi " },new PlayerModel { name = "Danny ",age="23",team="Bolton Wanderers (ENG)",number=" (6)",lastname="Shittu " },new PlayerModel { name = "Chidi ",age="21",team="CSKA Moscow (RUS)",number="(17)",lastname="Odiah " },new PlayerModel { name = "Uwa ",age="9",team="Rennes (FRA)",number="(21)",lastname="Echiéjilé " },new PlayerModel { name = "Dele ",age="5",team="Sparta Rotterdam (NED)",number="(22)",lastname="Adeleye " },new PlayerModel { name = "Ayila ",age="24",team="Dynamo Kyiv (UKR)",number="(13)",lastname="Yussuf " },new PlayerModel { name = "Sani ",age="16",team="Alania Vladikavkaz (RUS)",number="(14)",lastname="Kaita " },new PlayerModel { name = "Lukman ",age="5",team="AS Monaco (FRA)",number="(15)",lastname="Haruna " },new PlayerModel { name = "Dickson ",age="11",team="Fulham (ENG)",number="(20)",lastname="Etuhu " },new PlayerModel { name = "Nwankwo ",age="72",team="Portsmouth (ENG)",number=" (4)",lastname="Kanu " },new PlayerModel { name = "John ",age="41",team="Portsmouth (ENG)",number=" (7)",lastname="Utaka " },new PlayerModel { name = "Yakubu ",age="47",team="Everton (ENG)",number=" (8)",lastname="Aiyegbeni " },new PlayerModel { name = "Obafemi ",age="27",team="VfL Wolfsburg (GER)",number=" (9)",lastname="Martins " },new PlayerModel { name = "Brown ",age="0",team="Sochaux (FRA)",number="(10)",lastname="Ideye " },new PlayerModel { name = "Peter ",age="43",team="Lokomotiv Moscow (RUS)",number="(11)",lastname="Odemwingie " },new PlayerModel { name = "Kalu ",age="18",team="Almería (ESP)",number="(12)",lastname="Uche " },new PlayerModel { name = "Victor ",age="30",team="Málaga (ESP)",number="(18)",lastname="Obinna " },new PlayerModel { name = "Chinedu ",age="17",team="1899 Hoffenheim (GER)",number="(19)",lastname="Obasi " }}
             },
             {"nl-netherlands",new List<PlayerModel>{new PlayerModel { name = "Maarten ",age="25",team="Ajax (NED)",number="(1)",lastname="Stekelenburg " },new PlayerModel { name = "Michel ",age="3",team="Utrecht (NED)",number="(16)",lastname="Vorm " },new PlayerModel { name = "Sander ",age="1",team="Twente (NED)",number="(22)",lastname="Boschker " },new PlayerModel { name = "Gregory ",age="8",team="Ajax (NED)",number=" (2)",lastname="van " },new PlayerModel { name = "John ",age="51",team="Everton (ENG)",number=" (3)",lastname="Heitinga " },new PlayerModel { name = "Joris ",age="53",team="Hamburger SV (GER)",number=" (4)",lastname="Mathijsen " },new PlayerModel { name = "Giovanni ",age="97",team="Feyenoord (NED)",number=" (5)",lastname="van " },new PlayerModel { name = "Khalid ",age="28",team="VfB Stuttgart (GER)",number="(12)",lastname="Boulahrouz " },new PlayerModel { name = "André ",age="53",team="PSV Eindhoven (NED)",number="(13)",lastname="Ooijer " },new PlayerModel { name = "Edson ",age="5",team="Celtic (SCO)",number="(15)",lastname="Braafheid " },new PlayerModel { name = "Mark ",age="54",team="Bayern Munich (GER)",number=" (6)",lastname="van " },new PlayerModel { name = "Nigel ",age="40",team="Manchester City (ENG)",number=" (8)",lastname="de " },new PlayerModel { name = "Wesley ",age="59",team="Internazionale (ITA)",number="(10)",lastname="Sneijder " },new PlayerModel { name = "Demy ",age="23",team="Ajax (NED)",number="(14)",lastname="de " },new PlayerModel { name = "Stijn ",age="11",team="AZ (NED)",number="(18)",lastname="Schaars " },new PlayerModel { name = "Ibrahim ",age="20",team="PSV Eindhoven (NED)",number="(20)",lastname="Afellay " },new PlayerModel { name = "Rafael ",age="75",team="Real Madrid (ESP)",number="(23)",lastname="van " },new PlayerModel { name = "Dirk ",age="60",team="Liverpool (ENG)",number=" (7)",lastname="Kuyt " },new PlayerModel { name = "Robin ",age="41",team="Arsenal (ENG)",number=" (9)",lastname="van " },new PlayerModel { name = "Arjen ",age="46",team="Bayern Munich (GER)",number="(11)",lastname="Robben " },new PlayerModel { name = "Eljero ",age="5",team="Hamburger SV (GER)",number="(17)",lastname="Elia " },new PlayerModel { name = "Ryan ",age="38",team="Liverpool (ENG)",number="(19)",lastname="Babel " },new PlayerModel { name = "Klaas-Jan ",age="30",team="Milan (ITA)",number="(21)",lastname="Huntelaar " }}
             },
             {"nz-new-zealand",new List<PlayerModel>{new PlayerModel { name = "Mark ",age="23",team="Wellington Phoenix (NZL)",number="(1)",lastname="Paston " },new PlayerModel { name = "Glen ",age="15",team="Melbourne Victory (AUS)",number="(12)",lastname="Moss " },new PlayerModel { name = "James ",age="3",team="Team Wellington (NZL)",number="(23)",lastname="Bannatyne " },new PlayerModel { name = "Ben ",age="14",team="Wellington Phoenix (NZL)",number=" (2)",lastname="Sigmund " },new PlayerModel { name = "Tony ",age="30",team="Wellington Phoenix (NZL)",number=" (3)",lastname="Lochhead " },new PlayerModel { name = "Winston ",age="3",team="Midtjylland (DEN)",number=" (4)",lastname="Reid " },new PlayerModel { name = "Ivan ",age="66",team="Auckland City (NZL)",number=" (5)",lastname="Vicelich " },new PlayerModel { name = "Ryan ",age="41",team="Blackburn Rovers (ENG)",number=" (6)",lastname="Nelsen " },new PlayerModel { name = "Andrew ",age="15",team="New York Red Bulls (USA)",number="(18)",lastname="Boyens " },new PlayerModel { name = "Tommy ",age="4",team="Ipswich Town (ENG)",number="(19)",lastname="Smith " },new PlayerModel { name = "Simon ",age="63",team="",number=" (7)",lastname="Elliott " },new PlayerModel { name = "Tim ",age="25",team="Wellington Phoenix (NZL)",number=" (8)",lastname="Brown " },new PlayerModel { name = "Leo ",age="34",team="Wellington Phoenix (NZL)",number="(11)",lastname="Bertos " },new PlayerModel { name = "Andy ",age="11",team="Team Wellington (NZL)",number="(13)",lastname="Barron " },new PlayerModel { name = "Michael ",age="5",team="Motherwell (SCO)",number="(15)",lastname="McGlinchey " },new PlayerModel { name = "Aaron ",age="0",team="Canterbury United (NZL)",number="(16)",lastname="Clapham " },new PlayerModel { name = "David ",age="25",team="",number="(17)",lastname="Mulligan " },new PlayerModel { name = "Jeremy ",age="22",team="Tampa Bay (USA)",number="(21)",lastname="Christie " },new PlayerModel { name = "Jeremy ",age="18",team="Newcastle Jets (AUS)",number="(22)",lastname="Brockie " },new PlayerModel { name = "Shane ",age="30",team="Gold Coast United (AUS)",number=" (9)",lastname="Smeltz " },new PlayerModel { name = "Chris ",age="31",team="Middlesbrough (ENG)",number="(10)",lastname="Killen " },new PlayerModel { name = "Rory ",age="7",team="Plymouth Argyle (ENG)",number="(14)",lastname="Fallon " },new PlayerModel { name = "Chris ",age="9",team="West Bromwich Albion (ENG)",number="(20)",lastname="Wood " }}
             },
             {"pt-portugal",new List<PlayerModel>{new PlayerModel { name = "Eduardo ",age="12",team="Braga (POR)",number="(1)",lastname="## " },new PlayerModel { name = "Beto ",age="1",team="Porto (POR)",number="(12)",lastname="## " },new PlayerModel { name = "Daniel ",age="2",team="Iraklis (GRE)",number="(22)",lastname="Fernandes " },new PlayerModel { name = "Bruno ",age="28",team="Porto (POR)",number=" (2)",lastname="Alves " },new PlayerModel { name = "Paulo ",age="59",team="Chelsea (ENG)",number=" (3)",lastname="Ferreira " },new PlayerModel { name = "Rolando ",age="7",team="Porto (POR)",number=" (4)",lastname="## " },new PlayerModel { name = "Duda ",age="14",team="Málaga (ESP)",number=" (5)",lastname="## " },new PlayerModel { name = "Ricardo ",age="60",team="Chelsea (ENG)",number=" (6)",lastname="Carvalho " },new PlayerModel { name = "Miguel ",age="53",team="Valencia (ESP)",number="(13)",lastname="## " },new PlayerModel { name = "Pepe ",age="24",team="Real Madrid (ESP)",number="(15)",lastname="## " },new PlayerModel { name = "Ricardo ",age="6",team="Lille (FRA)",number="(21)",lastname="Costa " },new PlayerModel { name = "Fábio ",age="3",team="Benfica (POR)",number="(23)",lastname="Coentrão " },new PlayerModel { name = "Pedro ",age="5",team="Sporting CP (POR)",number=" (8)",lastname="Mendes " },new PlayerModel { name = "Danny ",age="8",team="Zenit Saint Petersburg (RUS)",number="(10)",lastname="## " },new PlayerModel { name = "Simão ",age="79",team="Atlético Madrid (ESP)",number="(11)",lastname="## " },new PlayerModel { name = "Miguel ",age="10",team="Sporting CP (POR)",number="(14)",lastname="Veloso " },new PlayerModel { name = "Raul ",age="31",team="Porto (POR)",number="(16)",lastname="Meireles " },new PlayerModel { name = "Rúben ",age="0",team="Benfica (POR)",number="(17)",lastname="Amorim " },new PlayerModel { name = "Tiago ",age="49",team="Atlético Madrid (ESP)",number="(19)",lastname="## " },new PlayerModel { name = "Deco ",age="71",team="Chelsea (ENG)",number="(20)",lastname="## " },new PlayerModel { name = "Cristiano ",age="69",team="Real Madrid (ESP)",number=" (7)",lastname="Ronaldo " },new PlayerModel { name = "Liédson ",age="7",team="Sporting CP (POR)",number=" (9)",lastname="## " },new PlayerModel { name = "Hugo ",age="23",team="Werder Bremen (GER)",number="(18)",lastname="Almeida " }}
             },
             {"py-paraguay",new List<PlayerModel>{new PlayerModel { name = "Justo ",age="71",team="Real Valladolid (ESP)",number="(1)",lastname="Villar " },new PlayerModel { name = "Diego ",age="2",team="Cerro Porteño (PAR)",number="(12)",lastname="Barreto " },new PlayerModel { name = "Aldo ",age="18",team="Independiente Medellín (COL)",number="(22)",lastname="Bobadilla " },new PlayerModel { name = "Darío ",age="27",team="UNAM (MEX)",number=" (2)",lastname="Verón " },new PlayerModel { name = "Claudio ",age="25",team="Boca Juniors (ARG)",number=" (3)",lastname="Morel " },new PlayerModel { name = "Denis ",age="95",team="León (MEX)",number=" (4)",lastname="Caniza " },new PlayerModel { name = "Julio ",age="59",team="Atlético Mineiro (BRA)",number=" (5)",lastname="César " },new PlayerModel { name = "Carlos ",age="60",team="Olimpia (PAR)",number=" (6)",lastname="Bonet " },new PlayerModel { name = "Paulo ",age="67",team="Sunderland (ENG)",number="(14)",lastname="da " },new PlayerModel { name = "Aureliano ",age="25",team="San Lorenzo (ARG)",number="(17)",lastname="Torres " },new PlayerModel { name = "Antolín ",age="5",team="Club Brugge (BEL)",number="(21)",lastname="Alcaraz " },new PlayerModel { name = "Édgar ",age="47",team="Atalanta (ITA)",number=" (8)",lastname="Barreto " },new PlayerModel { name = "Jonathan ",age="21",team="VfL Wolfsburg (GER)",number="(11)",lastname="Santana " },new PlayerModel { name = "Enrique ",age="25",team="LDU Quito (ECU)",number="(13)",lastname="Vera " },new PlayerModel { name = "Víctor ",age="25",team="Libertad (PAR)",number="(15)",lastname="Cáceres " },new PlayerModel { name = "Cristian ",age="45",team="Cruz Azul (MEX)",number="(16)",lastname="Riveros " },new PlayerModel { name = "Néstor ",age="3",team="Argentinos Juniors (ARG)",number="(20)",lastname="Ortigoza " },new PlayerModel { name = "Óscar ",age="29",team="Benfica (POR)",number=" (7)",lastname="Cardozo " },new PlayerModel { name = "Roque ",age="66",team="Manchester City (ENG)",number=" (9)",lastname="Santa " },new PlayerModel { name = "Édgar ",age="12",team="Pachuca (MEX)",number="(10)",lastname="Benítez " },new PlayerModel { name = "Nelson ",age="38",team="Borussia Dortmund (GER)",number="(18)",lastname="Valdez " },new PlayerModel { name = "Lucas ",age="3",team="Borussia Dortmund (GER)",number="(19)",lastname="Barrios " },new PlayerModel { name = "Rodolfo ",age="2",team="Libertad (PAR)",number="(23)",lastname="Gamarra " }}
             },
             {"rs-serbia",new List<PlayerModel>{new PlayerModel { name = "Vladimir ",age="33",team="Wigan Athletic (ENG)",number="(1)",lastname="Stojković " },new PlayerModel { name = "Bojan ",age="4",team="Zagłębie Lubin (POL)",number="(12)",lastname="Isailović " },new PlayerModel { name = "Anđelko ",age="1",team="União Leiria (POR)",number="(23)",lastname="Đuričić " },new PlayerModel { name = "Antonio ",age="20",team="1860 Munich (GER)",number=" (2)",lastname="Rukavina " },new PlayerModel { name = "Aleksandar ",age="13",team="Lazio (ITA)",number=" (3)",lastname="Kolarov " },new PlayerModel { name = "Nemanja ",age="45",team="Manchester United (ENG)",number=" (5)",lastname="Vidić " },new PlayerModel { name = "Branislav ",age="31",team="Chelsea (ENG)",number=" (6)",lastname="Ivanović " },new PlayerModel { name = "Aleksandar ",age="21",team="Udinese (ITA)",number="(13)",lastname="Luković " },new PlayerModel { name = "Ivan ",age="12",team="Real Zaragoza (ESP)",number="(16)",lastname="Obradović " },new PlayerModel { name = "Neven ",age="13",team="Borussia Dortmund (GER)",number="(20)",lastname="Subotić " },new PlayerModel { name = "Gojko ",age="17",team="Hertha BSC (GER)",number=" (4)",lastname="Kačar " },new PlayerModel { name = "Zoran ",age="21",team="1. FC Köln (GER)",number=" (7)",lastname="Tošić " },new PlayerModel { name = "Dejan ",age="88",team="Internazionale (ITA)",number="(10)",lastname="Stanković " },new PlayerModel { name = "Nenad ",age="17",team="Wolverhampton Wanderers (ENG)",number="(11)",lastname="Milijaš " },new PlayerModel { name = "Milan ",age="26",team="Standard Liège (BEL)",number="(14)",lastname="Jovanović " },new PlayerModel { name = "Miloš ",age="31",team="CSKA Moscow (RUS)",number="(17)",lastname="Krasić " },new PlayerModel { name = "Miloš ",age="9",team="Dynamo Kyiv (UKR)",number="(18)",lastname="Ninković " },new PlayerModel { name = "Radosav ",age="9",team="Partizan (SRB)",number="(19)",lastname="Petrović " },new PlayerModel { name = "Zdravko ",age="27",team="VfB Stuttgart (GER)",number="(22)",lastname="Kuzmanović " },new PlayerModel { name = "Danko ",age="37",team="Zenit Saint Petersburg (RUS)",number=" (8)",lastname="Lazović " },new PlayerModel { name = "Marko ",age="32",team="Ajax (NED)",number=" (9)",lastname="Pantelić " },new PlayerModel { name = "Nikola ",age="45",team="Valencia (ESP)",number="(15)",lastname="Žigić " },new PlayerModel { name = "Dragan ",age="6",team="Vojvodina (SRB)",number="(21)",lastname="Mrđa " }}
             },
             {"si-slovenia",new List<PlayerModel>{new PlayerModel { name = "Samir ",age="38",team="Udinese (ITA)",number="(1)",lastname="Handanović " },new PlayerModel { name = "Jasmin ",age="3",team="Mantova (ITA)",number="(12)",lastname="Handanovič " },new PlayerModel { name = "Aleksander ",age="1",team="Sparta Rotterdam (NED)",number="(16)",lastname="Šeliga " },new PlayerModel { name = "Mišo ",age="30",team="1. FC Köln (GER)",number=" (2)",lastname="Brečko " },new PlayerModel { name = "Elvedin ",age="0",team="Maribor (SVN)",number=" (3)",lastname="Džinić " },new PlayerModel { name = "Marko ",age="16",team="Gent (BEL)",number=" (4)",lastname="Šuler " },new PlayerModel { name = "Boštjan ",age="41",team="Grenoble (FRA)",number=" (5)",lastname="Cesar " },new PlayerModel { name = "Branko ",age="36",team="Lokomotiv Moscow (RUS)",number=" (6)",lastname="Ilič " },new PlayerModel { name = "Bojan ",age="33",team="Chievo (ITA)",number="(13)",lastname="Jokić " },new PlayerModel { name = "Suad ",age="14",team="Maribor (SVN)",number="(19)",lastname="Filekovič " },new PlayerModel { name = "Matej ",age="32",team="TuS Koblenz (GER)",number="(22)",lastname="Mavrič " },new PlayerModel { name = "Robert ",age="45",team="West Bromwich Albion (ENG)",number=" (8)",lastname="Koren " },new PlayerModel { name = "Rene ",age="3",team="Internazionale (ITA)",number="(15)",lastname="Krhin " },new PlayerModel { name = "Andraž ",age="25",team="Wisła Kraków (POL)",number="(17)",lastname="Kirm " },new PlayerModel { name = "Aleksandar ",age="14",team="Larissa (GRE)",number="(18)",lastname="Radosavljević " },new PlayerModel { name = "Andrej ",age="40",team="Maccabi Tel Aviv (ISR)",number="(20)",lastname="Komac " },new PlayerModel { name = "Dalibor ",age="15",team="Vitesse (NED)",number="(21)",lastname="Stevanovič " },new PlayerModel { name = "Nejc ",age="7",team="Nacional (POR)",number=" (7)",lastname="Pečnik " },new PlayerModel { name = "Zlatan ",age="16",team="Gent (BEL)",number=" (9)",lastname="Ljubijankič " },new PlayerModel { name = "Valter ",age="33",team="Auxerre (FRA)",number="(10)",lastname="Birsa " },new PlayerModel { name = "Milivoje ",age="37",team="1. FC Köln (GER)",number="(11)",lastname="Novakovič " },new PlayerModel { name = "Zlatko ",age="23",team="VfL Bochum (GER)",number="(14)",lastname="Dedič " },new PlayerModel { name = "Tim ",age="0",team="Groningen (NED)",number="(23)",lastname="Matavž " }}
             },
             {"sk-slovakia",new List<PlayerModel>{new PlayerModel { name = "Ján ",age="14",team="Legia Warszawa (POL)",number="(1)",lastname="Mucha " },new PlayerModel { name = "Dušan ",age="1",team="Dundee United (SCO)",number="(12)",lastname="Perniš " },new PlayerModel { name = "Dušan ",age="2",team="FC Vaslui (ROU)",number="(23)",lastname="Kuciak " },new PlayerModel { name = "Peter ",age="21",team="VfL Wolfsburg (GER)",number=" (2)",lastname="Pekarík " },new PlayerModel { name = "Martin ",age="37",team="Liverpool (ENG)",number=" (3)",lastname="Škrtel " },new PlayerModel { name = "Marek ",age="38",team="West Bromwich Albion (ENG)",number=" (4)",lastname="Čech " },new PlayerModel { name = "Radoslav ",age="42",team="Mainz 05 (GER)",number=" (5)",lastname="Zabavník " },new PlayerModel { name = "Ján ",age="35",team="Hannover 96 (GER)",number="(16)",lastname="Ďurica " },new PlayerModel { name = "Kornel ",age="3",team="Slovan Bratislava (SVK)",number="(21)",lastname="Saláta " },new PlayerModel { name = "Martin ",age="38",team="Cesena (ITA)",number="(22)",lastname="Petráš " },new PlayerModel { name = "Zdeno ",age="20",team="Skoda Xanthi (GRE)",number=" (6)",lastname="Štrba " },new PlayerModel { name = "Vladimír ",age="7",team="Bolton Wanderers (ENG)",number=" (7)",lastname="Weiss " },new PlayerModel { name = "Ján ",age="22",team="Timişoara (ROU)",number=" (8)",lastname="Kozák " },new PlayerModel { name = "Stanislav ",age="29",team="VfL Bochum (GER)",number=" (9)",lastname="Šesták " },new PlayerModel { name = "Marek ",age="24",team="Ankaragücü (TUR)",number="(10)",lastname="Sapara " },new PlayerModel { name = "Miroslav ",age="10",team="Twente (NED)",number="(15)",lastname="Stoch " },new PlayerModel { name = "Marek ",age="30",team="Napoli (ITA)",number="(17)",lastname="Hamšík " },new PlayerModel { name = "Juraj ",age="5",team="Sparta Prague (CZE)",number="(19)",lastname="Kucka " },new PlayerModel { name = "Kamil ",age="7",team="Spartak Trnava (SVK)",number="(20)",lastname="Kopúnek " },new PlayerModel { name = "Róbert ",age="69",team="Ankaragücü (TUR)",number="(11)",lastname="Vittek " },new PlayerModel { name = "Filip ",age="37",team="Beşiktaş (TUR)",number="(13)",lastname="Hološko " },new PlayerModel { name = "Martin ",age="21",team="Saturn Moscow Oblast (RUS)",number="(14)",lastname="Jakubko " },new PlayerModel { name = "Erik ",age="13",team="1. FC Kaiserslautern (GER)",number="(18)",lastname="Jendrišek " }}
             },
             {"us-united-states",new List<PlayerModel>{new PlayerModel { name = "Tim ",age="51",team="Everton (ENG)",number="(1)",lastname="Howard " },new PlayerModel { name = "Brad ",age="16",team="Aston Villa (ENG)",number="(18)",lastname="Guzan " },new PlayerModel { name = "Marcus ",age="7",team="Wolverhampton Wanderers (ENG)",number="(23)",lastname="Hahnemann " },new PlayerModel { name = "Jonathan ",age="25",team="West Ham United (ENG)",number=" (2)",lastname="Spector " },new PlayerModel { name = "Carlos ",age="79",team="Rennes (FRA)",number=" (3)",lastname="Bocanegra " },new PlayerModel { name = "Oguchi ",age="54",team="Milan (ITA)",number=" (5)",lastname="Onyewu " },new PlayerModel { name = "Steve ",age="60",team="Hannover 96 (GER)",number=" (6)",lastname="Cherundolo " },new PlayerModel { name = "Jonathan ",age="32",team="Chivas USA (USA)",number="(12)",lastname="Bornstein " },new PlayerModel { name = "Jay ",age="19",team="Watford (ENG)",number="(15)",lastname="DeMerit " },new PlayerModel { name = "Clarence ",age="14",team="Start (NOR)",number="(21)",lastname="Goodson " },new PlayerModel { name = "Michael ",age="43",team="Borussia Mönchengladbach (GER)",number=" (4)",lastname="Bradley " },new PlayerModel { name = "DaMarcus ",age="92",team="Rangers (SCO)",number=" (7)",lastname="Beasley " },new PlayerModel { name = "Clint ",age="62",team="Fulham (ENG)",number=" (8)",lastname="Dempsey " },new PlayerModel { name = "Landon ",age="123",team="Los Angeles Galaxy (USA)",number="(10)",lastname="Donovan " },new PlayerModel { name = "Stuart ",age="14",team="Bolton Wanderers (ENG)",number="(11)",lastname="Holden " },new PlayerModel { name = "Ricardo ",age="29",team="Eintracht Frankfurt (GER)",number="(13)",lastname="Clark " },new PlayerModel { name = "José ",age="10",team="Pachuca (MEX)",number="(16)",lastname="Francisco " },new PlayerModel { name = "Maurice ",age="13",team="Rangers (SCO)",number="(19)",lastname="Edu " },new PlayerModel { name = "Benny ",age="32",team="AGF (DEN)",number="(22)",lastname="Feilhaber " },new PlayerModel { name = "Herculez ",age="4",team="Puebla (MEX)",number=" (9)",lastname="Gomez " },new PlayerModel { name = "Edson ",age="3",team="Los Angeles Galaxy (USA)",number="(14)",lastname="Buddle " },new PlayerModel { name = "Jozy ",age="25",team="Hull City (ENG)",number="(17)",lastname="Altidore " },new PlayerModel { name = "Robbie ",age="6",team="Real Salt Lake (USA)",number="(20)",lastname="Findley " }}
             },
             {"uy-uruguay",new List<PlayerModel>{new PlayerModel { name = "Fernando ",age="6",team="Lazio (ITA)",number="(1)",lastname="Muslera " },new PlayerModel { name = "Juan ",age="11",team="Deportivo Cali (COL)",number="(12)",lastname="Castillo " },new PlayerModel { name = "Martín ",age="1",team="Defensor Sporting (URU)",number="(23)",lastname="Silva " },new PlayerModel { name = "Diego ",age="42",team="Fenerbahçe (TUR)",number=" (2)",lastname="Lugano " },new PlayerModel { name = "Diego ",age="38",team="Villarreal (ESP)",number=" (3)",lastname="Godín " },new PlayerModel { name = "Jorge ",age="24",team="Porto (POR)",number=" (4)",lastname="Fucile " },new PlayerModel { name = "Mauricio ",age="4",team="Universidad de Chile (CHI)",number=" (6)",lastname="Victorino " },new PlayerModel { name = "Maxi ",age="37",team="Benfica (POR)",number="(16)",lastname="Pereira " },new PlayerModel { name = "Andrés ",age="26",team="Colo-Colo (CHI)",number="(19)",lastname="Scotti " },new PlayerModel { name = "Martín ",age="19",team="Sevilla (ESP)",number="(22)",lastname="Cáceres " },new PlayerModel { name = "Walter ",age="28",team="Napoli (ITA)",number=" (5)",lastname="Gargano " },new PlayerModel { name = "Sebastián ",age="27",team="AIK (SWE)",number=" (8)",lastname="Eguren " },new PlayerModel { name = "Álvaro ",age="15",team="Porto (POR)",number="(11)",lastname="Pereira " },new PlayerModel { name = "Nicolás ",age="4",team="Ajax (NED)",number="(14)",lastname="Lodeiro " },new PlayerModel { name = "Diego ",age="50",team="AS Monaco (FRA)",number="(15)",lastname="Pérez " },new PlayerModel { name = "Egidio ",age="6",team="Peñarol (URU)",number="(17)",lastname="Arévalo " },new PlayerModel { name = "Ignacio ",age="17",team="Valencia (ESP)",number="(18)",lastname="González " },new PlayerModel { name = "Álvaro ",age="7",team="Universidad de Chile (CHI)",number="(20)",lastname="Fernández " },new PlayerModel { name = "Edinson ",age="14",team="Palermo (ITA)",number=" (7)",lastname="Cavani " },new PlayerModel { name = "Luis ",age="30",team="Ajax (NED)",number=" (9)",lastname="Suárez " },new PlayerModel { name = "Diego ",age="62",team="Atlético Madrid (ESP)",number="(10)",lastname="Forlán " },new PlayerModel { name = "Sebastián ",age="56",team="Botafogo (BRA)",number="(13)",lastname="Abreu " },new PlayerModel { name = "Sebastián ",age="6",team="Banfield (ARG)",number="(21)",lastname="Fernández " }}
             },
             {"za-south-africa",new List<PlayerModel>
             {
                 new PlayerModel { name = "Moeneeb ",age="17",team="Orlando Pirates (RSA)",number="(1)",lastname="Josephs " },new PlayerModel { name = "Itumeleng ",age="27",team="Kaizer Chiefs (RSA)",number="(16)",lastname="Khune " },new PlayerModel { name = "Shu-Aib ",age="0",team="Maritzburg United (RSA)",number="(22)",lastname="Walters " },new PlayerModel { name = "Siboniso ",age="37",team="Mamelodi Sundowns (RSA)",number=" (2)",lastname="Gaxa " },new PlayerModel { name = "Tsepo ",age="31",team="Maccabi Haifa (ISR)",number=" (3)",lastname="Masilela " },new PlayerModel { name = "Aaron ",age="101",team="Portsmouth (ENG)",number=" (4)",lastname="Mokoena " },new PlayerModel { name = "Anele ",age="5",team="Racing Genk (BEL)",number=" (5)",lastname="Ngcongca " },new PlayerModel { name = "Matthew ",age="27",team="Mamelodi Sundowns (RSA)",number="(14)",lastname="Booth " },new PlayerModel { name = "Lucas ",age="24",team="Orlando Pirates (RSA)",number="(15)",lastname="Thwala " },new PlayerModel { name = "Bongani ",age="14",team="Supersport United (RSA)",number="(20)",lastname="Khumalo " },new PlayerModel { name = "Siyabonga ",age="8",team="Golden Arrows (RSA)",number="(21)",lastname="Sangweni " },new PlayerModel { name = "MacBeth ",age="58",team="Rubin Kazan (RUS)",number=" (6)",lastname="Sibaya " },new PlayerModel { name = "Lance ",age="22",team="Ajax Cape Town (RSA)",number=" (7)",lastname="Davids " },new PlayerModel { name = "Siphiwe ",age="48",team="Kaizer Chiefs (RSA)",number=" (8)",lastname="Tshabalala " },new PlayerModel { name = "Steven ",age="50",team="Everton (ENG)",number="(10)",lastname="Pienaar " },new PlayerModel { name = "Teko ",age="52",team="Orlando Pirates (RSA)",number="(11)",lastname="Modise " },new PlayerModel { name = "Reneilwe ",age="13",team="Kaizer Chiefs (RSA)",number="(12)",lastname="Letsholonyane " },new PlayerModel { name = "Kagisho ",age="37",team="Fulham (ENG)",number="(13)",lastname="Dikgacoi " },new PlayerModel { name = "Surprise ",age="34",team="Mamelodi Sundowns (RSA)",number="(19)",lastname="Moriri " },new PlayerModel { name = "Thanduyise ",age="9",team="Golden Arrows (RSA)",number="(23)",lastname="Khuboni " },new PlayerModel { name = "Katlego ",age="31",team="Mamelodi Sundowns (RSA)",number=" (9)",lastname="Mphela " },new PlayerModel { name = "Bernard ",age="28",team="Twente (NED)",number="(17)",lastname="Parker " },new PlayerModel { name = "Siyabonga ",age="76",team="Moroka Swallows (RSA)",number="(18)",lastname="Nomvethe " }
                 }
             }
            
          });
           squads.Add( "2014",new Dictionary<string, List<PlayerModel>>
             {

            {"za-south-africa",new List<PlayerModel>{new PlayerModel { name = "Moeneeb ",age="17",team="Orlando Pirates (RSA)",number="(1)",lastname="Josephs " },new PlayerModel { name = "Itumeleng ",age="27",team="Kaizer Chiefs (RSA)",number="(16)",lastname="Khune " },new PlayerModel { name = "Shu-Aib ",age="0",team="Maritzburg United (RSA)",number="(22)",lastname="Walters " },new PlayerModel { name = "Siboniso ",age="37",team="Mamelodi Sundowns (RSA)",number=" (2)",lastname="Gaxa " },new PlayerModel { name = "Tsepo ",age="31",team="Maccabi Haifa (ISR)",number=" (3)",lastname="Masilela " },new PlayerModel { name = "Aaron ",age="101",team="Portsmouth (ENG)",number=" (4)",lastname="Mokoena " },new PlayerModel { name = "Anele ",age="5",team="Racing Genk (BEL)",number=" (5)",lastname="Ngcongca " },new PlayerModel { name = "Matthew ",age="27",team="Mamelodi Sundowns (RSA)",number="(14)",lastname="Booth " },new PlayerModel { name = "Lucas ",age="24",team="Orlando Pirates (RSA)",number="(15)",lastname="Thwala " },new PlayerModel { name = "Bongani ",age="14",team="Supersport United (RSA)",number="(20)",lastname="Khumalo " },new PlayerModel { name = "Siyabonga ",age="8",team="Golden Arrows (RSA)",number="(21)",lastname="Sangweni " },new PlayerModel { name = "MacBeth ",age="58",team="Rubin Kazan (RUS)",number=" (6)",lastname="Sibaya " },new PlayerModel { name = "Lance ",age="22",team="Ajax Cape Town (RSA)",number=" (7)",lastname="Davids " },new PlayerModel { name = "Siphiwe ",age="48",team="Kaizer Chiefs (RSA)",number=" (8)",lastname="Tshabalala " },new PlayerModel { name = "Steven ",age="50",team="Everton (ENG)",number="(10)",lastname="Pienaar " },new PlayerModel { name = "Teko ",age="52",team="Orlando Pirates (RSA)",number="(11)",lastname="Modise " },new PlayerModel { name = "Reneilwe ",age="13",team="Kaizer Chiefs (RSA)",number="(12)",lastname="Letsholonyane " },new PlayerModel { name = "Kagisho ",age="37",team="Fulham (ENG)",number="(13)",lastname="Dikgacoi " },new PlayerModel { name = "Surprise ",age="34",team="Mamelodi Sundowns (RSA)",number="(19)",lastname="Moriri " },new PlayerModel { name = "Thanduyise ",age="9",team="Golden Arrows (RSA)",number="(23)",lastname="Khuboni " },new PlayerModel { name = "Katlego ",age="31",team="Mamelodi Sundowns (RSA)",number=" (9)",lastname="Mphela " },new PlayerModel { name = "Bernard ",age="28",team="Twente (NED)",number="(17)",lastname="Parker " },new PlayerModel { name = "Siyabonga ",age="76",team="Moroka Swallows (RSA)",number="(18)",lastname="Nomvethe " }}
            },
            {"ar-argentina",new List<PlayerModel>{new PlayerModel { name = "Sergio ",age="45",team="AS Monaco (FRA)",number=" (1)",lastname="Romero " },new PlayerModel { name = "Agustín ",age="3",team="Boca Juniors (ARG)",number="(12)",lastname="Orión " },new PlayerModel { name = "Mariano ",age="10",team="Catania (ITA)",number="(21)",lastname="Andújar " },new PlayerModel { name = "Ezequiel ",age="18",team="Benfica (POR)",number=" (2)",lastname="Garay " },new PlayerModel { name = "Hugo ",age="13",team="Internazionale (ITA)",number=" (3)",lastname="Campagnaro " },new PlayerModel { name = "Pablo ",age="36",team="Manchester City (ENG)",number=" (4)",lastname="Zabaleta " },new PlayerModel { name = "Martín ",age="37",team="Manchester City (ENG)",number="(15)",lastname="Demichelis " },new PlayerModel { name = "Marcos ",age="20",team="Sporting (POR)",number="(16)",lastname="Rojo " },new PlayerModel { name = "Federico ",age="24",team="Napoli (ITA)",number="(17)",lastname="Fernández " },new PlayerModel { name = "José ",age="8",team="Monterrey (MEX)",number="(23)",lastname="María " },new PlayerModel { name = "Fernando ",age="47",team="Boca Juniors (ARG)",number=" (5)",lastname="Gago " },new PlayerModel { name = "Lucas ",age="16",team="Lazio (ITA)",number=" (6)",lastname="Biglia " },new PlayerModel { name = "Ángel ",age="45",team="Real Madrid (ESP)",number=" (7)",lastname="di " },new PlayerModel { name = "Enzo ",age="5",team="Benfica (POR)",number=" (8)",lastname="Pérez " },new PlayerModel { name = "Maxi ",age="53",team="Newell's Old Boys (ARG)",number="(11)",lastname="Rodríguez " },new PlayerModel { name = "Augusto ",age="7",team="Celta Vigo (ESP)",number="(13)",lastname="Fernández " },new PlayerModel { name = "Javier ",age="96",team="Barcelona (ESP)",number="(14)",lastname="Mascherano " },new PlayerModel { name = "Ricardo ",age="5",team="Internazionale (ITA)",number="(19)",lastname="Álvarez " },new PlayerModel { name = "Gonzalo ",age="36",team="Napoli (ITA)",number=" (9)",lastname="Higuaín " },new PlayerModel { name = "Lionel ",age="84",team="Barcelona (ESP)",number="(10)",lastname="Messi " },new PlayerModel { name = "Rodrigo ",age="15",team="Internazionale (ITA)",number="(18)",lastname="Palacio " },new PlayerModel { name = "Sergio ",age="50",team="Manchester City (ENG)",number="(20)",lastname="Agüero " },new PlayerModel { name = "Ezequiel ",age="29",team="Paris Saint-Germain (FRA)",number="(22)",lastname="Lavezzi " }}
            },
            {"au-australia",new List<PlayerModel>{new PlayerModel { name = "Mathew ",age="6",team="Club Brugge (BEL)",number=" (1)",lastname="Ryan " },new PlayerModel { name = "Mitchell ",age="3",team="Borussia Dortmund (GER)",number="(12)",lastname="Langerak " },new PlayerModel { name = "Eugene ",age="8",team="Adelaide United (AUS)",number="(18)",lastname="Galeković " },new PlayerModel { name = "Ivan ",age="8",team="Brisbane Roar (AUS)",number=" (2)",lastname="Franjić " },new PlayerModel { name = "Jason ",age="6",team="Heracles Almelo (NED)",number=" (3)",lastname="Davidson " },new PlayerModel { name = "Matthew ",age="17",team="Western Sydney Wanderers (AUS)",number=" (6)",lastname="Špiranović " },new PlayerModel { name = "Bailey ",age="0",team="Preston North End (ENG)",number=" (8)",lastname="Wright " },new PlayerModel { name = "Ryan ",age="9",team="Shandong Luneng Taishan (CHN)",number="(19)",lastname="McGowan " },new PlayerModel { name = "Alex ",age="2",team="Jeonbuk Hyundai Motors",number="(22)",lastname="Wilkinson " },new PlayerModel { name = "Mark ",age="28",team="Melbourne Victory (AUS)",number=" (5)",lastname="Milligan " },new PlayerModel { name = "Ben ",age="1",team="Fortuna Düsseldorf (GER)",number="(10)",lastname="Halloran " },new PlayerModel { name = "Tommy ",age="14",team="Utrecht (NED)",number="(11)",lastname="Oar " },new PlayerModel { name = "Oliver ",age="3",team="Luzern (SUI)",number="(13)",lastname="Bozanić " },new PlayerModel { name = "James ",age="10",team="Atalanta (ITA)",number="(14)",lastname="Troisi " },new PlayerModel { name = "Mile ",age="43",team="Crystal Palace (ENG)",number="(15)",lastname="Jedinak " },new PlayerModel { name = "James ",age="13",team="Austria Wien (AUT)",number="(16)",lastname="Holland " },new PlayerModel { name = "Matt ",age="46",team="Brisbane Roar (AUS)",number="(17)",lastname="McKay " },new PlayerModel { name = "Dario ",age="22",team="Sion (SWI)",number="(20)",lastname="Vidošić " },new PlayerModel { name = "Massimo ",age="1",team="Swindon Town (ENG)",number="(21)",lastname="Luongo " },new PlayerModel { name = "Mark ",age="73",team="Al-Gharafa (QAT)",number="(23)",lastname="Bresciano " },new PlayerModel { name = "Tim ",age="68",team="New York Red Bulls (USA)",number=" (4)",lastname="Cahill " },new PlayerModel { name = "Mathew ",age="7",team="FSV Frankfurt (GER)",number=" (7)",lastname="Leckie " },new PlayerModel { name = "Adam ",age="4",team="Newcastle Jets (AUS)",number=" (9)",lastname="Taggart " }}
            },
            {"ba-bosnia-herzegovina",new List<PlayerModel>{new PlayerModel { name = "Asmir ",age="30",team="Stoke City (ENG)",number=" (1)",lastname="Begović " },new PlayerModel { name = "Jasmin ",age="0",team="VfR Aalen (GER)",number="(12)",lastname="Fejzić " },new PlayerModel { name = "Asmir ",age="3",team="Borac Banja Luka (BIH)",number="(22)",lastname="Avdukić " },new PlayerModel { name = "Avdija ",age="13",team="Hajduk Split (CRO)",number=" (2)",lastname="Vršajević " },new PlayerModel { name = "Ermin ",age="7",team="Eintracht Braunschweig (GER)",number=" (3)",lastname="Bičakčić " },new PlayerModel { name = "Emir ",age="74",team="Bayer Leverkusen (GER)",number=" (4)",lastname="Spahić " },new PlayerModel { name = "Sead ",age="4",team="Schalke 04 (GER)",number=" (5)",lastname="Kolašinac " },new PlayerModel { name = "Ognjen ",age="13",team="Elazığspor (TUR)",number=" (6)",lastname="Vranješ " },new PlayerModel { name = "Muhamed ",age="9",team="Ferencváros (HUN)",number=" (7)",lastname="Bešić " },new PlayerModel { name = "Mensur ",age="24",team="SC Freiburg (GER)",number="(13)",lastname="Mujdža " },new PlayerModel { name = "Toni ",age="7",team="Zorya Luhansk (UKR)",number="(15)",lastname="Šunjić " },new PlayerModel { name = "Miralem ",age="48",team="Roma (ITA)",number=" (8)",lastname="Pjanić " },new PlayerModel { name = "Zvjezdan ",age="82",team="Guizhou Renhe (CHN)",number="(10)",lastname="Misimović " },new PlayerModel { name = "Izet ",age="7",team="Galatasaray (TUR)",number="(14)",lastname="Hajrović " },new PlayerModel { name = "Senad ",age="33",team="Lazio (ITA)",number="(16)",lastname="Lulić " },new PlayerModel { name = "Senijad ",age="42",team="Kayseri Erciyesspor (TUR)",number="(17)",lastname="Ibričić " },new PlayerModel { name = "Haris ",age="35",team="Gaziantepspor (TUR)",number="(18)",lastname="Medunjanin " },new PlayerModel { name = "Anel ",age="2",team="Sturm Graz (AUT)",number="(20)",lastname="Hadžić " },new PlayerModel { name = "Tino-Sven ",age="2",team="Hajduk Split (CRO)",number="(21)",lastname="Sušić " },new PlayerModel { name = "Sejad ",age="42",team="1899 Hoffenheim (GER)",number="(23)",lastname="Salihović " },new PlayerModel { name = "Vedad ",age="55",team="VfB Stuttgart (GER)",number=" (9)",lastname="Ibišević " },new PlayerModel { name = "Edin ",age="62",team="Manchester City (ENG)",number="(11)",lastname="Džeko " },new PlayerModel { name = "Edin ",age="10",team="İstanbul BB (TUR)",number="(19)",lastname="Višća " }}
            },
            {"be-belgium",new List<PlayerModel>{new PlayerModel { name = "Thibaut ",age="16",team="Atlético Madrid (ESP)",number=" (1)",lastname="Courtois " },new PlayerModel { name = "Simon ",age="14",team="Liverpool (ENG)",number="(12)",lastname="Mignolet " },new PlayerModel { name = "Sammy ",age="1",team="Zulte Waregem (BEL)",number="(13)",lastname="Bossut " },new PlayerModel { name = "Toby ",age="34",team="Atlético Madrid (ESP)",number=" (2)",lastname="Alderweireld " },new PlayerModel { name = "Thomas ",age="48",team="Arsenal (ENG)",number=" (3)",lastname="Vermaelen " },new PlayerModel { name = "Vincent ",age="59",team="Manchester City (ENG)",number=" (4)",lastname="Kompany " },new PlayerModel { name = "Jan ",age="56",team="Tottenham Hotspur (ENG)",number=" (5)",lastname="Vertonghen " },new PlayerModel { name = "Daniel ",age="79",team="Bayern Munich (GER)",number="(15)",lastname="Van " },new PlayerModel { name = "Nicolas ",age="26",team="Zenit Saint Petersburg (RUS)",number="(18)",lastname="Lombaerts " },new PlayerModel { name = "Anthony ",age="25",team="Anderlecht (BEL)",number="(21)",lastname="Vanden " },new PlayerModel { name = "Laurent ",age="8",team="Standard Liège (BEL)",number="(23)",lastname="Ciman " },new PlayerModel { name = "Axel ",age="48",team="Zenit Saint Petersburg (RUS)",number=" (6)",lastname="Witsel " },new PlayerModel { name = "Kevin ",age="22",team="VfL Wolfsburg (GER)",number=" (7)",lastname="De " },new PlayerModel { name = "Marouane ",age="50",team="Manchester United (ENG)",number=" (8)",lastname="Fellaini " },new PlayerModel { name = "Eden ",age="45",team="Chelsea (ENG)",number="(10)",lastname="Hazard " },new PlayerModel { name = "Kevin ",age="44",team="Everton (ENG)",number="(11)",lastname="Mirallas " },new PlayerModel { name = "Steven ",age="43",team="Porto (POR)",number="(16)",lastname="Defour " },new PlayerModel { name = "Mousa ",age="55",team="Tottenham Hotspur (ENG)",number="(19)",lastname="Dembélé " },new PlayerModel { name = "Adnan ",age="1",team="Manchester United (ENG)",number="(20)",lastname="Januzaj " },new PlayerModel { name = "Nacer ",age="20",team="Tottenham Hotspur (ENG)",number="(22)",lastname="Chadli " },new PlayerModel { name = "Romelu ",age="29",team="Everton (ENG)",number=" (9)",lastname="Lukaku " },new PlayerModel { name = "Dries ",age="24",team="Napoli (ITA)",number="(14)",lastname="Mertens " },new PlayerModel { name = "Divock ",age="2",team="Lille (FRA)",number="(17)",lastname="Origi " }}
            },
            {"br-brazil",new List<PlayerModel>{new PlayerModel { name = "Jefferson ",age="9",team="Botafogo (BRA)",number=" (1)",lastname="## " },new PlayerModel { name = "Júlio ",age="79",team="Toronto (CAN)",number="(12)",lastname="César " },new PlayerModel { name = "Victor ",age="6",team="Atlético Mineiro (BRA)",number="(22)",lastname="## " },new PlayerModel { name = "Dani ",age="74",team="Barcelona (ESP)",number=" (2)",lastname="Alves " },new PlayerModel { name = "Thiago ",age="45",team="Paris Saint-Germain (FRA)",number=" (3)",lastname="Silva " },new PlayerModel { name = "David ",age="35",team="Chelsea (ENG)",number=" (4)",lastname="Luiz " },new PlayerModel { name = "Marcelo ",age="30",team="Real Madrid (ESP)",number=" (6)",lastname="## " },new PlayerModel { name = "Dante ",age="12",team="Bayern Munich (GER)",number="(13)",lastname="## " },new PlayerModel { name = "Maxwell ",age="8",team="Paris Saint-Germain (FRA)",number="(14)",lastname="## " },new PlayerModel { name = "Henrique ",age="5",team="Napoli (ITA)",number="(15)",lastname="## " },new PlayerModel { name = "Maicon ",age="71",team="Roma (ITA)",number="(23)",lastname="## " },new PlayerModel { name = "Fernandinho ",age="6",team="Manchester City (ENG)",number=" (5)",lastname="## " },new PlayerModel { name = "Paulinho ",age="25",team="Tottenham Hotspur (ENG)",number=" (8)",lastname="## " },new PlayerModel { name = "Oscar ",age="30",team="Chelsea (ENG)",number="(11)",lastname="## " },new PlayerModel { name = "Ramires ",age="42",team="Chelsea (ENG)",number="(16)",lastname="## " },new PlayerModel { name = "Luiz ",age="18",team="VfL Wolfsburg (GER)",number="(17)",lastname="Gustavo " },new PlayerModel { name = "Hernanes ",age="24",team="Internazionale (ITA)",number="(18)",lastname="## " },new PlayerModel { name = "Willian ",age="6",team="Chelsea (ENG)",number="(19)",lastname="## " },new PlayerModel { name = "Hulk ",age="34",team="Zenit Saint Petersburg (RUS)",number=" (7)",lastname="## " },new PlayerModel { name = "Fred ",age="33",team="Fluminense (BRA)",number=" (9)",lastname="## " },new PlayerModel { name = "Neymar ",age="48",team="Barcelona (ESP)",number="(10)",lastname="## " },new PlayerModel { name = "Bernard ",age="10",team="Shakhtar Donetsk (UKR)",number="(20)",lastname="## " },new PlayerModel { name = "Jô ",age="16",team="Atlético Mineiro (BRA)",number="(21)",lastname="## " }}
            },
            {"ch-switzerland",new List<PlayerModel>{new PlayerModel { name = "Diego ",age="56",team="VfL Wolfsburg (GER)",number=" (1)",lastname="Benaglio " },new PlayerModel { name = "Yann ",age="6",team="Basel (SUI)",number="(12)",lastname="Sommer " },new PlayerModel { name = "Roman ",age="0",team="Grasshopper (SUI)",number="(21)",lastname="Bürki " },new PlayerModel { name = "Stephan ",age="62",team="Juventus (ITA)",number=" (2)",lastname="Lichtsteiner " },new PlayerModel { name = "Reto ",age="35",team="Sassuolo (ITA)",number=" (3)",lastname="Ziegler " },new PlayerModel { name = "Philippe ",age="53",team="Valencia (ESP)",number=" (4)",lastname="Senderos " },new PlayerModel { name = "Steve ",age="40",team="Young Boys (SUI)",number=" (5)",lastname="von " },new PlayerModel { name = "Michael ",age="5",team="Grasshopper (SUI)",number=" (6)",lastname="Lang " },new PlayerModel { name = "Ricardo ",age="20",team="VfL Wolfsburg (GER)",number="(13)",lastname="Rodríguez " },new PlayerModel { name = "Johan ",age="44",team="Hamburger SV (GER)",number="(20)",lastname="Djourou " },new PlayerModel { name = "Fabian ",age="5",team="Basel (SUI)",number="(22)",lastname="Schär " },new PlayerModel { name = "Tranquillo ",age="73",team="Eintracht Frankfurt (GER)",number=" (7)",lastname="Barnetta " },new PlayerModel { name = "Gökhan ",age="71",team="Napoli (ITA)",number=" (8)",lastname="Inler " },new PlayerModel { name = "Granit ",age="25",team="Borussia Mönchengladbach (GER)",number="(10)",lastname="Xhaka " },new PlayerModel { name = "Valon ",age="47",team="Napoli (ITA)",number="(11)",lastname="Behrami " },new PlayerModel { name = "Valentin ",age="23",team="Basel (SUI)",number="(14)",lastname="Stocker " },new PlayerModel { name = "Blerim ",age="33",team="Napoli (ITA)",number="(15)",lastname="Džemaili " },new PlayerModel { name = "Gelson ",age="47",team="SC Freiburg (GER)",number="(16)",lastname="Fernandes " },new PlayerModel { name = "Xherdan ",age="32",team="Bayern Munich (GER)",number="(23)",lastname="Shaqiri " },new PlayerModel { name = "Haris ",age="10",team="Real Sociedad (ESP)",number=" (9)",lastname="Seferović " },new PlayerModel { name = "Mario ",age="10",team="Zürich (SUI)",number="(17)",lastname="Gavranović " },new PlayerModel { name = "Admir ",age="20",team="SC Freiburg (GER)",number="(18)",lastname="Mehmedi " },new PlayerModel { name = "Josip ",age="6",team="1. FC Nürnberg (GER)",number="(19)",lastname="Drmić " }}
            },
            {"ci-cote-d-ivoire",new List<PlayerModel>{new PlayerModel { name = "Boubacar ",age="79",team="Lokeren (BEL)",number=" (1)",lastname="Barry " },new PlayerModel { name = "Sylvain ",age="1",team="Séwé Sport (CIV)",number="(16)",lastname="Gbohouo " },new PlayerModel { name = "Sayouba ",age="1",team="Stabæk (NOR)",number="(23)",lastname="Mandé " },new PlayerModel { name = "Ousmane ",age="3",team="Çaykur Rizespor (TUR)",number=" (2)",lastname="Viera " },new PlayerModel { name = "Arthur ",age="79",team="VfB Stuttgart (GER)",number=" (3)",lastname="Boka " },new PlayerModel { name = "Kolo ",age="106",team="Liverpool (ENG)",number=" (4)",lastname="Touré " },new PlayerModel { name = "Didier ",age="119",team="Trabzonspor (TUR)",number=" (5)",lastname="Zokora " },new PlayerModel { name = "Jean-Daniel ",age="1",team="Toulouse (FRA)",number=" (7)",lastname="Akpa-Akpro " },new PlayerModel { name = "Serge ",age="8",team="Toulouse (FRA)",number="(17)",lastname="Aurier " },new PlayerModel { name = "Constant ",age="4",team="Eintracht Frankfurt (GER)",number="(18)",lastname="Djakpa " },new PlayerModel { name = "Sol ",age="43",team="Trabzonspor (TUR)",number="(22)",lastname="Bamba " },new PlayerModel { name = "Cheick ",age="44",team="Newcastle United (ENG)",number=" (9)",lastname="Tioté " },new PlayerModel { name = "Didier ",age="25",team="Hannover 96 (GER)",number="(13)",lastname="Ya " },new PlayerModel { name = "Ismaël ",age="1",team="Saint-Étienne (FRA)",number="(14)",lastname="Diomandé " },new PlayerModel { name = "Yaya ",age="83",team="Manchester City (ENG)",number="(19)",lastname="Touré " },new PlayerModel { name = "Serey ",age="6",team="Basel (SWI)",number="(20)",lastname="Die " },new PlayerModel { name = "Mathis ",age="3",team="Fortuna Düsseldorf (GER)",number=" (6)",lastname="Bolly " },new PlayerModel { name = "Salomon ",age="64",team="Lille (FRA)",number=" (8)",lastname="Kalou " },new PlayerModel { name = "Gervinho ",age="53",team="Roma (ITA)",number="(10)",lastname="## " },new PlayerModel { name = "Didier ",age="100",team="Galatasaray (TUR)",number="(11)",lastname="Drogba " },new PlayerModel { name = "Wilfried ",age="24",team="Swansea City (WAL)",number="(12)",lastname="Bony " },new PlayerModel { name = "Max ",age="25",team="Saint-Étienne (FRA)",number="(15)",lastname="Gradel " },new PlayerModel { name = "Giovanni ",age="7",team="Basel (SWI)",number="(21)",lastname="Sio " }}
            },
            {"cl-chile",new List<PlayerModel>{new PlayerModel { name = "Claudio ",age="79",team="Real Sociedad (ESP)",number=" (1)",lastname="Bravo " },new PlayerModel { name = "Cristopher ",age="4",team="Universidad Católica (CHI)",number="(12)",lastname="Toselli " },new PlayerModel { name = "Johnny ",age="7",team="Universidad de Chile (CHI)",number="(23)",lastname="Herrera " },new PlayerModel { name = "Eugenio ",age="24",team="Santos (BRA)",number=" (2)",lastname="Mena " },new PlayerModel { name = "Miiko ",age="2",team="Malmö FF (SWE)",number=" (3)",lastname="Albornoz " },new PlayerModel { name = "José ",age="18",team="Universidad de Chile (CHI)",number="(13)",lastname="Rojas " },new PlayerModel { name = "Gary ",age="60",team="Cardiff City (WAL)",number="(17)",lastname="Medel " },new PlayerModel { name = "Gonzalo ",age="65",team="Nottingham Forest (ENG)",number="(18)",lastname="Jara " },new PlayerModel { name = "Mauricio ",age="46",team="Juventus (ITA)",number=" (4)",lastname="Isla " },new PlayerModel { name = "Francisco ",age="11",team="Osasuna (ESP)",number=" (5)",lastname="Silva " },new PlayerModel { name = "Carlos ",age="43",team="Atalanta (ITA)",number=" (6)",lastname="Carmona " },new PlayerModel { name = "Arturo ",age="53",team="Juventus (ITA)",number=" (8)",lastname="Vidal " },new PlayerModel { name = "Jorge ",age="56",team="Palmeiras (BRA)",number="(10)",lastname="Valdívia " },new PlayerModel { name = "Fabián ",age="25",team="Celta Vigo (ESP)",number="(14)",lastname="Orellana " },new PlayerModel { name = "Jean ",age="59",team="Wigan Athletic (ENG)",number="(15)",lastname="Beausejour " },new PlayerModel { name = "Felipe ",age="17",team="Twente (NED)",number="(16)",lastname="Gutiérrez " },new PlayerModel { name = "José ",age="23",team="Colo-Colo (CHI)",number="(19)",lastname="Pedro " },new PlayerModel { name = "Charles ",age="20",team="Internacional (BRA)",number="(20)",lastname="Aránguiz " },new PlayerModel { name = "Marcelo ",age="20",team="Basel (SWI)",number="(21)",lastname="Díaz " },new PlayerModel { name = "Alexis ",age="66",team="Barcelona (ESP)",number=" (7)",lastname="Sánchez " },new PlayerModel { name = "Mauricio ",age="26",team="Cagliari (ITA)",number=" (9)",lastname="Pinilla " },new PlayerModel { name = "Eduardo ",age="29",team="Valencia (ESP)",number="(11)",lastname="Vargas " },new PlayerModel { name = "Esteban ",age="34",team="Colo-Colo (CHI)",number="(22)",lastname="Paredes " }}
            },
            {"cm-cameroon",new List<PlayerModel>{new PlayerModel { name = "Loïc ",age="1",team="Coton Sport (CMR)",number=" (1)",lastname="Feudjou " },new PlayerModel { name = "Charles ",age="9",team="Konyaspor (TUR)",number="(16)",lastname="Itandje " },new PlayerModel { name = "Sammy ",age="2",team="Fethiyespor (TUR)",number="(23)",lastname="N'Djock " },new PlayerModel { name = "Benoît ",age="21",team="Queens Park Rangers (ENG)",number=" (2)",lastname="Assou-Ekotto " },new PlayerModel { name = "Nicolas ",age="47",team="Marseille (FRA)",number=" (3)",lastname="N'Koulou " },new PlayerModel { name = "Cédric ",age="3",team="Coton Sport (CMR)",number=" (4)",lastname="Djeugoué " },new PlayerModel { name = "Dany ",age="15",team="Beşiktaş (TUR)",number=" (5)",lastname="Nounkeu " },new PlayerModel { name = "Henri ",age="30",team="Lyon (FRA)",number="(12)",lastname="Bedimo " },new PlayerModel { name = "Aurélien ",age="30",team="Galatasaray (TUR)",number="(14)",lastname="Chedjou " },new PlayerModel { name = "Allan ",age="8",team="Granada (ESP)",number="(22)",lastname="Nyom " },new PlayerModel { name = "Alex ",age="46",team="Barcelona (ESP)",number=" (6)",lastname="Song " },new PlayerModel { name = "Landry ",age="39",team="Bordeaux (FRA)",number=" (7)",lastname="N'Guémo " },new PlayerModel { name = "Jean ",age="66",team="Rennes (FRA)",number="(11)",lastname="Makoun " },new PlayerModel { name = "Stéphane ",age="49",team="Sevilla (ESP)",number="(17)",lastname="Mbia " },new PlayerModel { name = "Eyong ",age="37",team="Antalyaspor (TUR)",number="(18)",lastname="Enoh " },new PlayerModel { name = "Edgar ",age="8",team="Lens (FRA)",number="(20)",lastname="Salli " },new PlayerModel { name = "Joël ",age="22",team="Schalke 04 (GER)",number="(21)",lastname="Matip " },new PlayerModel { name = "Benjamin ",age="16",team="Nancy (FRA)",number=" (8)",lastname="Moukandjo " },new PlayerModel { name = "Samuel ",age="116",team="Chelsea (ENG)",number=" (9)",lastname="Eto'o " },new PlayerModel { name = "Vincent ",age="23",team="Lorient (FRA)",number="(10)",lastname="Aboubakar " },new PlayerModel { name = "Maxim ",age="26",team="Mainz 05 (GER)",number="(13)",lastname="Choupo-Moting " },new PlayerModel { name = "Pierre ",age="55",team="Fenerbahçe (TUR)",number="(15)",lastname="Webó " },new PlayerModel { name = "Fabrice ",age="7",team="Zulte Waregem (BEL)",number="(19)",lastname="Olinga " }}
            },
            {"co-colombia",new List<PlayerModel>{new PlayerModel { name = "David ",age="42",team="Nice (FRA)",number=" (1)",lastname="Ospina " },new PlayerModel { name = "Camilo ",age="0",team="Santa Fe (COL)",number="(12)",lastname="Vargas " },new PlayerModel { name = "Faryd ",age="55",team="Deportivo Cali (COL)",number="(22)",lastname="Mondragón " },new PlayerModel { name = "Cristián ",age="21",team="Milan (ITA)",number=" (2)",lastname="Zapata " },new PlayerModel { name = "Mario ",age="96",team="Atalanta (ITA)",number=" (3)",lastname="Yepes " },new PlayerModel { name = "Santiago ",age="5",team="PSV (NED)",number=" (4)",lastname="Arias " },new PlayerModel { name = "Pablo ",age="51",team="West Ham United (ENG)",number=" (7)",lastname="Armero " },new PlayerModel { name = "Éder ",age="2",team="River Plate (ARG)",number="(16)",lastname="Álvarez " },new PlayerModel { name = "Juan ",age="52",team="Napoli (ITA)",number="(18)",lastname="Camilo " },new PlayerModel { name = "Carlos ",age="13",team="San Lorenzo (ARG)",number="(23)",lastname="Valdés " },new PlayerModel { name = "Carlos ",age="1",team="River Plate (ARG)",number=" (5)",lastname="Carbonero " },new PlayerModel { name = "Carlos ",age="44",team="Elche (ESP)",number=" (6)",lastname="Sánchez " },new PlayerModel { name = "Abel ",age="48",team="Toulouse (FRA)",number=" (8)",lastname="Aguilar " },new PlayerModel { name = "James ",age="21",team="AS Monaco (FRA)",number="(10)",lastname="Rodríguez " },new PlayerModel { name = "Juan ",age="26",team="Fiorentina (ITA)",number="(11)",lastname="Guillermo " },new PlayerModel { name = "Fredy ",age="48",team="Internazionale (ITA)",number="(13)",lastname="Guarín " },new PlayerModel { name = "Víctor ",age="8",team="Cagliari (ITA)",number="(14)",lastname="Ibarbo " },new PlayerModel { name = "Alexander ",age="9",team="Atlético Nacional (COL)",number="(15)",lastname="Mejía " },new PlayerModel { name = "Juan ",age="4",team="Porto (POR)",number="(20)",lastname="Fernando " },new PlayerModel { name = "Teófilo ",age="29",team="River Plate (ARG)",number=" (9)",lastname="Gutiérrez " },new PlayerModel { name = "Carlos ",age="10",team="Sevilla (ESP)",number="(17)",lastname="Bacca " },new PlayerModel { name = "Adrián ",age="24",team="Hertha BSC (GER)",number="(19)",lastname="Ramos " },new PlayerModel { name = "Jackson ",age="27",team="Porto (POR)",number="(21)",lastname="Martínez " }}
            },
            {"cr-costa-rica",new List<PlayerModel>{new PlayerModel { name = "Keylor ",age="52",team="Levante (ESP)",number=" (1)",lastname="Navas " },new PlayerModel { name = "Patrick ",age="20",team="Alajuelense (CRC)",number="(18)",lastname="Pemberton " },new PlayerModel { name = "Daniel ",age="4",team="Herediano (CRC)",number="(23)",lastname="Cambronero " },new PlayerModel { name = "Johnny ",age="25",team="Alajuelense (CRC)",number=" (2)",lastname="Acosta " },new PlayerModel { name = "Giancarlo ",age="34",team="Columbus Crew (USA)",number=" (3)",lastname="González " },new PlayerModel { name = "Michael ",age="82",team="Saprissa (CRC)",number=" (4)",lastname="Umaña " },new PlayerModel { name = "Óscar ",age="10",team="Club Brugge (BEL)",number=" (6)",lastname="Duarte " },new PlayerModel { name = "Heiner ",age="21",team="Saprissa (CRC)",number=" (8)",lastname="Mora " },new PlayerModel { name = "Waylon ",age="1",team="Columbus Crew (USA)",number="(12)",lastname="Francis " },new PlayerModel { name = "Júnior ",age="61",team="Mainz 05 (GER)",number="(15)",lastname="Díaz " },new PlayerModel { name = "Cristian ",age="25",team="Rosenborg (NOR)",number="(16)",lastname="Gamboa " },new PlayerModel { name = "Roy ",age="48",team="New York Red Bulls (USA)",number="(19)",lastname="Miller " },new PlayerModel { name = "Celso ",age="62",team="AIK (SWE)",number=" (5)",lastname="Borges " },new PlayerModel { name = "Christian ",age="54",team="Copenhagen (DEN)",number=" (7)",lastname="Bolaños " },new PlayerModel { name = "Michael ",age="50",team="Aalesund (NOR)",number="(11)",lastname="Barrantes " },new PlayerModel { name = "Esteban ",age="11",team="Herediano (CRC)",number="(13)",lastname="Granados " },new PlayerModel { name = "Yeltsin ",age="22",team="Saprissa (CRC)",number="(17)",lastname="Tejeda " },new PlayerModel { name = "Diego ",age="9",team="Vålerenga (NOR)",number="(20)",lastname="Calvo " },new PlayerModel { name = "José ",age="34",team="Herediano (CRC)",number="(22)",lastname="Miguel " },new PlayerModel { name = "Joel ",age="32",team="Olympiacos (GRE)",number=" (9)",lastname="Campbell " },new PlayerModel { name = "Bryan ",age="62",team="PSV (NED)",number="(10)",lastname="Ruiz " },new PlayerModel { name = "Randall ",age="38",team="Cartaginés (CRC)",number="(14)",lastname="Brenes " },new PlayerModel { name = "Marco ",age="23",team="Kuban Krasnodar (RUS)",number="(21)",lastname="Ureña " }}
            },
            {"de-deutschland",new List<PlayerModel>{new PlayerModel { name = "Manuel ",age="45",team="Bayern Munich (GER)",number=" (1)",lastname="Neuer " },new PlayerModel { name = "Ron-Robert ",age="3",team="Hannover 96 (GER)",number="(12)",lastname="Zieler " },new PlayerModel { name = "Roman ",age="2",team="Borussia Dortmund (GER)",number="(22)",lastname="Weidenfeller " },new PlayerModel { name = "Kevin ",age="4",team="Borussia Dortmund (GER)",number=" (2)",lastname="Großkreutz " },new PlayerModel { name = "Benedikt ",age="20",team="Schalke 04 (GER)",number=" (4)",lastname="Höwedes " },new PlayerModel { name = "Mats ",age="29",team="Borussia Dortmund (GER)",number=" (5)",lastname="Hummels " },new PlayerModel { name = "Erik ",age="1",team="Borussia Dortmund (GER)",number="(15)",lastname="Durm " },new PlayerModel { name = "Philipp ",age="105",team="Bayern Munich (GER)",number="(16)",lastname="Lahm " },new PlayerModel { name = "Per ",age="97",team="Arsenal (ENG)",number="(17)",lastname="Mertesacker " },new PlayerModel { name = "Jérôme ",age="38",team="Bayern Munich (GER)",number="(20)",lastname="Boateng " },new PlayerModel { name = "Matthias ",age="2",team="SC Freiburg (GER)",number=" (3)",lastname="Ginter " },new PlayerModel { name = "Sami ",age="45",team="Real Madrid (ESP)",number=" (6)",lastname="Khedira " },new PlayerModel { name = "Bastian ",age="101",team="Bayern Munich (GER)",number=" (7)",lastname="Schweinsteiger " },new PlayerModel { name = "Mesut ",age="54",team="Arsenal (ENG)",number=" (8)",lastname="Özil " },new PlayerModel { name = "André ",age="32",team="Chelsea (ENG)",number=" (9)",lastname="Schürrle " },new PlayerModel { name = "Thomas ",age="48",team="Bayern Munich (GER)",number="(13)",lastname="Müller " },new PlayerModel { name = "Julian ",age="11",team="Schalke 04 (GER)",number="(14)",lastname="Draxler " },new PlayerModel { name = "Toni ",age="43",team="Bayern Munich (GER)",number="(18)",lastname="Kroos " },new PlayerModel { name = "Mario ",age="28",team="Bayern Munich (GER)",number="(19)",lastname="Götze " },new PlayerModel { name = "Marco ",age="20",team="Borussia Dortmund (GER)",number="(21)",lastname="Reus " },new PlayerModel { name = "Christoph ",age="2",team="Borussia Mönchengladbach (GER)",number="(23)",lastname="Kramer " },new PlayerModel { name = "Lukas ",age="113",team="Arsenal (ENG)",number="(10)",lastname="Podolski " },new PlayerModel { name = "Miroslav ",age="131",team="Lazio (ITA)",number="(11)",lastname="Klose " }}
            },
            {"dz-algeria",new List<PlayerModel>{new PlayerModel { name = "Cédric ",age="1",team="CS Constantine (ALG)",number=" (1)",lastname="Si " },new PlayerModel { name = "Mohamed ",age="7",team="USM Alger (ALG)",number="(16)",lastname="Zemmamouche " },new PlayerModel { name = "Raïs ",age="27",team="CSKA Sofia (BUL)",number="(23)",lastname="M'Bolhi " },new PlayerModel { name = "Madjid ",age="61",team="Lekhwiya (QAT)",number=" (2)",lastname="Bougherra " },new PlayerModel { name = "Faouzi ",age="5",team="Napoli (ITA)",number=" (3)",lastname="Ghoulam " },new PlayerModel { name = "Essaïd ",age="13",team="Watford (ENG)",number=" (4)",lastname="Belkalem " },new PlayerModel { name = "Rafik ",age="28",team="Académica (POR)",number=" (5)",lastname="Halliche " },new PlayerModel { name = "Djamel ",age="26",team="Livorno (ITA)",number=" (6)",lastname="Mesbah " },new PlayerModel { name = "Carl ",age="25",team="Valenciennes (FRA)",number=" (7)",lastname="Medjani " },new PlayerModel { name = "Liassine ",age="6",team="Mallorca (ESP)",number="(17)",lastname="Cadamuro-Bentaïba " },new PlayerModel { name = "Aïssa ",age="2",team="Reims (FRA)",number="(20)",lastname="Mandi " },new PlayerModel { name = "Hassan ",age="24",team="Udinese (ITA)",number=" (8)",lastname="Yebda " },new PlayerModel { name = "Sofiane ",age="18",team="Valencia (ESP)",number="(10)",lastname="Feghouli " },new PlayerModel { name = "Yacine ",age="5",team="Granada (ESP)",number="(11)",lastname="Brahimi " },new PlayerModel { name = "Medhi ",age="29",team="Getafe (ESP)",number="(12)",lastname="Lacen " },new PlayerModel { name = "Nabil ",age="2",team="Tottenham Hotspur (ENG)",number="(14)",lastname="Bentaleb " },new PlayerModel { name = "Abdelmoumene ",age="76",team="Club Africain (TUN)",number="(18)",lastname="Djabou " },new PlayerModel { name = "Saphir ",age="10",team="Internazionale (ITA)",number="(19)",lastname="Taïder " },new PlayerModel { name = "Riyad ",age="1",team="Leicester City (ENG)",number="(21)",lastname="Mahrez " },new PlayerModel { name = "Mehdi ",age="22",team="Ajaccio (FRA)",number="(22)",lastname="Mostefa " },new PlayerModel { name = "Nabil ",age="5",team="Porto (POR)",number=" (9)",lastname="Ghilas " },new PlayerModel { name = "Islam ",age="19",team="Sporting CP (POR)",number="(13)",lastname="Slimani " },new PlayerModel { name = "El ",age="21",team="Dinamo Zagreb (CRO)",number="(15)",lastname="Arbi " }}
            },
            {"ec-ecuador",new List<PlayerModel>{new PlayerModel { name = "Máximo ",age="24",team="Barcelona (ECU)",number=" (1)",lastname="Banguera " },new PlayerModel { name = "Adrián ",age="3",team="El Nacional (ECU)",number="(12)",lastname="Bone " },new PlayerModel { name = "Alexander ",age="18",team="LDU Quito (ECU)",number="(22)",lastname="Domínguez " },new PlayerModel { name = "Jorge ",age="58",team="Emelec (ECU)",number=" (2)",lastname="Guagua " },new PlayerModel { name = "Frickson ",age="36",team="Flamengo (BRA)",number=" (3)",lastname="Erazo " },new PlayerModel { name = "Juan ",age="37",team="Barcelona (ECU)",number=" (4)",lastname="Carlos " },new PlayerModel { name = "Walter ",age="89",team="Pachuca (MEX)",number="(10)",lastname="Ayoví " },new PlayerModel { name = "Óscar ",age="21",team="Emelec (ECU)",number="(18)",lastname="Bagüí " },new PlayerModel { name = "Gabriel ",age="22",team="Emelec (ECU)",number="(21)",lastname="Achilier " },new PlayerModel { name = "Renato ",age="17",team="Vitesse (NED)",number=" (5)",lastname="Ibarra " },new PlayerModel { name = "Christian ",age="41",team="Dynamo Moscow (RUS)",number=" (6)",lastname="Noboa " },new PlayerModel { name = "Jefferson ",age="39",team="Morelia (MEX)",number=" (7)",lastname="Montero " },new PlayerModel { name = "Édison ",age="109",team="Santa Fe (COL)",number=" (8)",lastname="Méndez " },new PlayerModel { name = "Joao ",age="29",team="Cruz Azul (MEX)",number=" (9)",lastname="Rojas " },new PlayerModel { name = "Segundo ",age="81",team="Al-Hilal (KSA)",number="(14)",lastname="Castillo " },new PlayerModel { name = "Michael ",age="20",team="Atlante (MEX)",number="(15)",lastname="Arroyo " },new PlayerModel { name = "Antonio ",age="70",team="Manchester United (ENG)",number="(16)",lastname="Valencia " },new PlayerModel { name = "Luis ",age="48",team="Barcelona (ECU)",number="(19)",lastname="Saritama " },new PlayerModel { name = "Fidel ",age="8",team="Tijuana (MEX)",number="(20)",lastname="Martínez " },new PlayerModel { name = "Carlos ",age="2",team="VfB Stuttgart (GER)",number="(23)",lastname="Gruezo " },new PlayerModel { name = "Felipe ",age="49",team="Al-Jazira (UAE)",number="(11)",lastname="Caicedo " },new PlayerModel { name = "Enner ",age="9",team="Pachuca (MEX)",number="(13)",lastname="Valencia " },new PlayerModel { name = "Jaime ",age="30",team="Tijuana (MEX)",number="(17)",lastname="Ayoví " }}
            },
            {"en-england",new List<PlayerModel>{new PlayerModel { name = "Joe ",age="40",team="Manchester City (ENG)",number=" (1)",lastname="Hart " },new PlayerModel { name = "Ben ",age="6",team="West Bromwich Albion (ENG)",number="(13)",lastname="Foster " },new PlayerModel { name = "Fraser ",age="1",team="Celtic (SCO)",number="(22)",lastname="Forster " },new PlayerModel { name = "Glen ",age="51",team="Liverpool (ENG)",number=" (2)",lastname="Johnson " },new PlayerModel { name = "Leighton ",age="23",team="Everton (ENG)",number=" (3)",lastname="Baines " },new PlayerModel { name = "Gary ",age="23",team="Chelsea (ENG)",number=" (5)",lastname="Cahill " },new PlayerModel { name = "Phil ",age="25",team="Everton (ENG)",number=" (6)",lastname="Jagielka " },new PlayerModel { name = "Chris ",age="11",team="Manchester United (ENG)",number="(12)",lastname="Smalling " },new PlayerModel { name = "Phil ",age="9",team="Manchester United (ENG)",number="(16)",lastname="Jones " },new PlayerModel { name = "Luke ",age="1",team="Southampton (ENG)",number="(23)",lastname="Shaw " },new PlayerModel { name = "Steven ",age="110",team="Liverpool (ENG)",number=" (4)",lastname="Gerrard " },new PlayerModel { name = "Jack ",age="16",team="Arsenal (ENG)",number=" (7)",lastname="Wilshere " },new PlayerModel { name = "Frank ",age="103",team="Chelsea (ENG)",number=" (8)",lastname="Lampard " },new PlayerModel { name = "Jordan ",age="9",team="Liverpool (ENG)",number="(14)",lastname="Henderson " },new PlayerModel { name = "Alex ",age="14",team="Arsenal (ENG)",number="(15)",lastname="Oxlade-Chamberlain " },new PlayerModel { name = "James ",age="46",team="Manchester City (ENG)",number="(17)",lastname="Milner " },new PlayerModel { name = "Raheem ",age="3",team="Liverpool (ENG)",number="(19)",lastname="Sterling " },new PlayerModel { name = "Adam ",age="4",team="Southampton (ENG)",number="(20)",lastname="Lallana " },new PlayerModel { name = "Ross ",age="4",team="Everton (ENG)",number="(21)",lastname="Barkley " },new PlayerModel { name = "Daniel ",age="11",team="Liverpool (ENG)",number=" (9)",lastname="Sturridge " },new PlayerModel { name = "Wayne ",age="90",team="Manchester United (ENG)",number="(10)",lastname="Rooney " },new PlayerModel { name = "Danny ",age="22",team="Manchester United (ENG)",number="(11)",lastname="Welbeck " },new PlayerModel { name = "Rickie ",age="4",team="Southampton (ENG)",number="(18)",lastname="Lambert " }}
            },
            {"es-espana",new List<PlayerModel>{new PlayerModel { name = "Iker ",age="153",team="Real Madrid (ESP)",number=" (1)",lastname="Casillas " },new PlayerModel { name = "David ",age="0",team="Manchester United (ENG)",number="(12)",lastname="de " },new PlayerModel { name = "Pepe ",age="31",team="Napoli (ITA)",number="(23)",lastname="Reina " },new PlayerModel { name = "Raúl ",age="46",team="Napoli (ITA)",number=" (2)",lastname="Albiol " },new PlayerModel { name = "Gerard ",age="60",team="Barcelona (ESP)",number=" (3)",lastname="Piqué " },new PlayerModel { name = "Juanfran ",age="6",team="Atlético Madrid (ESP)",number=" (5)",lastname="## " },new PlayerModel { name = "Sergio ",age="115",team="Real Madrid (ESP)",number="(15)",lastname="Ramos " },new PlayerModel { name = "Jordi ",age="25",team="Barcelona (ESP)",number="(18)",lastname="Alba " },new PlayerModel { name = "César ",age="6",team="Chelsea (ENG)",number="(22)",lastname="Azpilicueta " },new PlayerModel { name = "Javi ",age="16",team="Bayern Munich (GER)",number=" (4)",lastname="Martínez " },new PlayerModel { name = "Andrés ",age="95",team="Barcelona (ESP)",number=" (6)",lastname="Iniesta " },new PlayerModel { name = "Xavi ",age="131",team="Barcelona (ESP)",number=" (8)",lastname="## " },new PlayerModel { name = "Cesc ",age="88",team="Barcelona (ESP)",number="(10)",lastname="Fàbregas " },new PlayerModel { name = "Juan ",age="32",team="Manchester United (ENG)",number="(13)",lastname="Mata " },new PlayerModel { name = "Xabi ",age="109",team="Real Madrid (ESP)",number="(14)",lastname="Alonso " },new PlayerModel { name = "Sergio ",age="64",team="Barcelona (ESP)",number="(16)",lastname="Busquets " },new PlayerModel { name = "Koke ",age="7",team="Atlético Madrid (ESP)",number="(17)",lastname="## " },new PlayerModel { name = "Santi ",age="62",team="Arsenal (ENG)",number="(20)",lastname="Cazorla " },new PlayerModel { name = "David ",age="79",team="Manchester City (ENG)",number="(21)",lastname="Silva " },new PlayerModel { name = "David ",age="94",team="Atlético Madrid (ESP)",number=" (7)",lastname="Villa " },new PlayerModel { name = "Fernando ",age="107",team="Chelsea (ENG)",number=" (9)",lastname="Torres " },new PlayerModel { name = "Pedro ",age="38",team="Barcelona (ESP)",number="(11)",lastname="## " },new PlayerModel { name = "Diego ",age="1",team="Atlético Madrid (ESP)",number="(19)",lastname="Costa " }}
            },
            {"fr-france",new List<PlayerModel>{new PlayerModel { name = "Hugo ",age="56",team="Tottenham Hotspur (ENG)",number=" (1)",lastname="Lloris " },new PlayerModel { name = "Stéphane ",age="2",team="Saint-Étienne (FRA)",number="(16)",lastname="Ruffier " },new PlayerModel { name = "Mickaël ",age="11",team="Bastia (FRA)",number="(23)",lastname="Landreau " },new PlayerModel { name = "Mathieu ",age="20",team="Newcastle United (ENG)",number=" (2)",lastname="Debuchy " },new PlayerModel { name = "Patrice ",age="57",team="Manchester United (ENG)",number=" (3)",lastname="Evra " },new PlayerModel { name = "Raphaël ",age="5",team="Real Madrid (ESP)",number=" (4)",lastname="Varane " },new PlayerModel { name = "Mamadou ",age="18",team="Liverpool (ENG)",number=" (5)",lastname="Sakho " },new PlayerModel { name = "Eliaquim ",age="3",team="Porto (POR)",number="(13)",lastname="Mangala " },new PlayerModel { name = "Bacary ",age="40",team="Arsenal (ENG)",number="(15)",lastname="Sagna " },new PlayerModel { name = "Lucas ",age="2",team="Paris Saint-Germain (FRA)",number="(17)",lastname="Digne " },new PlayerModel { name = "Laurent ",age="17",team="Arsenal (ENG)",number="(21)",lastname="Koscielny " },new PlayerModel { name = "Yohan ",age="29",team="Paris Saint-Germain (FRA)",number=" (6)",lastname="Cabaye " },new PlayerModel { name = "Mathieu ",age="33",team="Marseille (FRA)",number=" (8)",lastname="Valbuena " },new PlayerModel { name = "Antoine ",age="3",team="Real Sociedad (ESP)",number="(11)",lastname="Griezmann " },new PlayerModel { name = "Rio ",age="11",team="Lille (FRA)",number="(12)",lastname="Mavuba " },new PlayerModel { name = "Blaise ",age="22",team="Paris Saint-Germain (FRA)",number="(14)",lastname="Matuidi " },new PlayerModel { name = "Moussa ",age="16",team="Newcastle United (ENG)",number="(18)",lastname="Sissoko " },new PlayerModel { name = "Paul ",age="10",team="Juventus (ITA)",number="(19)",lastname="Pogba " },new PlayerModel { name = "Morgan ",age="0",team="Southampton (ENG)",number="(22)",lastname="Schneiderlin " },new PlayerModel { name = "Rémy ",age="1",team="Montpellier (FRA)",number=" (7)",lastname="Cabella " },new PlayerModel { name = "Olivier ",age="29",team="Arsenal (ENG)",number=" (9)",lastname="Giroud " },new PlayerModel { name = "Karim ",age="65",team="Real Madrid (ESP)",number="(10)",lastname="Benzema " },new PlayerModel { name = "Loïc ",age="24",team="Newcastle United (ENG)",number="(20)",lastname="Rémy " }}
            },
            {"gh-ghana",new List<PlayerModel>{new PlayerModel { name = "Steven ",age="7",team="Aduana Stars (GHA)",number=" (1)",lastname="Adams " },new PlayerModel { name = "Adam ",age="21",team="Strømsgodset (NOR)",number="(12)",lastname="Kwarasey " },new PlayerModel { name = "Fatau ",age="17",team="Orlando Pirates (SAF)",number="(16)",lastname="Dauda " },new PlayerModel { name = "Samuel ",age="46",team="Platanias (GRE)",number=" (2)",lastname="Inkoom " },new PlayerModel { name = "Daniel ",age="16",team="Standard Liège (BEL)",number=" (4)",lastname="Opare " },new PlayerModel { name = "Rashid ",age="6",team="Mamelodi Sundowns (SAF)",number="(15)",lastname="Sumaila " },new PlayerModel { name = "Jonathan ",age="26",team="Évian (FRA)",number="(19)",lastname="Mensah " },new PlayerModel { name = "John ",age="29",team="Rennes (FRA)",number="(21)",lastname="Boye " },new PlayerModel { name = "Harrison ",age="40",team="Espérance (TUN)",number="(23)",lastname="Afful " },new PlayerModel { name = "Michael ",age="57",team="Milan (ITA)",number=" (5)",lastname="Essien " },new PlayerModel { name = "Afriyie ",age="4",team="Parma (ITA)",number=" (6)",lastname="Acquah " },new PlayerModel { name = "Christian ",age="22",team="Vitesse (NED)",number=" (7)",lastname="Atsu " },new PlayerModel { name = "Emmanuel ",age="48",team="Udinese (ITA)",number=" (8)",lastname="Agyemang-Badu " },new PlayerModel { name = "André ",age="48",team="Marseille (FRA)",number="(10)",lastname="Ayew " },new PlayerModel { name = "Sulley ",age="81",team="Milan (ITA)",number="(11)",lastname="Muntari " },new PlayerModel { name = "Albert ",age="14",team="Middlesbrough (ENG)",number="(14)",lastname="Adomah " },new PlayerModel { name = "Mohammed ",age="16",team="Kuban Krasnodar (RUS)",number="(17)",lastname="Rabiu " },new PlayerModel { name = "Kwadwo ",age="61",team="Juventus (ITA)",number="(20)",lastname="Asamoah " },new PlayerModel { name = "Wakaso ",age="16",team="Rubin Kazan (RUS)",number="(22)",lastname="Mubarak " },new PlayerModel { name = "Asamoah ",age="78",team="Al-Ain (UAE)",number=" (3)",lastname="Gyan " },new PlayerModel { name = "Kevin-Prince ",age="12",team="Schalke 04 (GER)",number=" (9)",lastname="Boateng " },new PlayerModel { name = "Jordan ",age="12",team="Sochaux (FRA)",number="(13)",lastname="Ayew " },new PlayerModel { name = "Majeed ",age="9",team="Valenciennes (FRA)",number="(18)",lastname="Waris " }}
            },
            {"gr-greece",new List<PlayerModel>{new PlayerModel { name = "Orestis ",age="18",team="Granada (ESP)",number=" (1)",lastname="Karnezis " },new PlayerModel { name = "Panagiotis ",age="2",team="PAOK (GRE)",number="(12)",lastname="Glykos " },new PlayerModel { name = "Stefanos ",age="2",team="Panathinaikos (GRE)",number="(13)",lastname="Kapino " },new PlayerModel { name = "Giannis ",age="29",team="Olympiacos (GRE)",number=" (2)",lastname="Maniatis " },new PlayerModel { name = "Giorgos ",age="13",team="PAOK (GRE)",number=" (3)",lastname="Tzavellas " },new PlayerModel { name = "Kostas ",age="8",team="Olympiacos (GRE)",number=" (4)",lastname="Manolas " },new PlayerModel { name = "Vangelis ",age="18",team="Verona (ITA)",number=" (5)",lastname="Moras " },new PlayerModel { name = "Loukas ",age="49",team="Levante (ESP)",number="(11)",lastname="Vyntra " },new PlayerModel { name = "Vasilis ",age="65",team="Roma (ITA)",number="(15)",lastname="Torosidis " },new PlayerModel { name = "Sokratis ",age="47",team="Borussia Dortmund (GER)",number="(19)",lastname="Papastathopoulos " },new PlayerModel { name = "José ",age="21",team="Olympiacos (GRE)",number="(20)",lastname="Holebas " },new PlayerModel { name = "Alexandros ",age="49",team="Kayserispor (TUR)",number=" (6)",lastname="Tziolis " },new PlayerModel { name = "Panagiotis ",age="15",team="Bologna (ITA)",number=" (8)",lastname="Kone " },new PlayerModel { name = "Giorgos ",age="134",team="Fulham (ENG)",number="(10)",lastname="Karagounis " },new PlayerModel { name = "Lazaros ",age="18",team="Bologna (ITA)",number="(16)",lastname="Christodoulopoulos " },new PlayerModel { name = "Giannis ",age="18",team="Genoa (ITA)",number="(18)",lastname="Fetfatzidis " },new PlayerModel { name = "Kostas ",age="110",team="PAOK (GRE)",number="(21)",lastname="Katsouranis " },new PlayerModel { name = "Andreas ",age="4",team="Olympiacos (GRE)",number="(22)",lastname="Samaris " },new PlayerModel { name = "Panagiotis ",age="5",team="Torino (ITA)",number="(23)",lastname="Tachtsidis " },new PlayerModel { name = "Giorgos ",age="73",team="Celtic (SCO)",number=" (7)",lastname="Samaras " },new PlayerModel { name = "Kostas ",age="31",team="Fulham (ENG)",number=" (9)",lastname="Mitroglou " },new PlayerModel { name = "Dimitris ",age="75",team="PAOK (GRE)",number="(14)",lastname="Salpingidis " },new PlayerModel { name = "Theofanis ",age="71",team="Konyaspor (TUR)",number="(17)",lastname="Gekas " }}
            },
            {"hn-honduras",new List<PlayerModel>{new PlayerModel { name = "Luis ",age="0",team="Real España (HON)",number=" (1)",lastname="López " },new PlayerModel { name = "Noel ",age="121",team="Olimpia (HON)",number="(18)",lastname="Valladares " },new PlayerModel { name = "Donis ",age="26",team="Olimpia (HON)",number="(22)",lastname="Escober " },new PlayerModel { name = "Osman ",age="54",team="Qingdao Jonoon (CHN)",number=" (2)",lastname="Chávez " },new PlayerModel { name = "Maynor ",age="104",team="Hull City (ENG)",number=" (3)",lastname="Figueroa " },new PlayerModel { name = "Juan ",age="11",team="Motagua (HON)",number=" (4)",lastname="Pablo " },new PlayerModel { name = "Víctor ",age="77",team="San Jose Earthquakes (USA)",number=" (5)",lastname="Bernárdez " },new PlayerModel { name = "Juan ",age="33",team="Wigan Athletic (ENG)",number=" (6)",lastname="Carlos " },new PlayerModel { name = "Emilio ",age="67",team="Celtic (SCO)",number=" (7)",lastname="Izaguirre " },new PlayerModel { name = "Brayan ",age="22",team="Olimpia (HON)",number="(23)",lastname="Beckeles " },new PlayerModel { name = "Wilson ",age="94",team="Stoke City (ENG)",number=" (8)",lastname="Palacios " },new PlayerModel { name = "Mario ",age="35",team="Real España (HON)",number="(10)",lastname="Martínez " },new PlayerModel { name = "Edder ",age="25",team="Real España (HON)",number="(12)",lastname="Delgado " },new PlayerModel { name = "Óscar ",age="92",team="Houston Dynamo (USA)",number="(14)",lastname="García " },new PlayerModel { name = "Roger ",age="41",team="Wigan Athletic (ENG)",number="(15)",lastname="Espinoza " },new PlayerModel { name = "Marvin ",age="41",team="Chivas USA (USA)",number="(17)",lastname="Chávez " },new PlayerModel { name = "Luis ",age="19",team="Olimpia (HON)",number="(19)",lastname="Garrido " },new PlayerModel { name = "Jorge ",age="48",team="Motagua (HON)",number="(20)",lastname="Claros " },new PlayerModel { name = "Andy ",age="16",team="Anderlecht (BEL)",number="(21)",lastname="Najar " },new PlayerModel { name = "Jerry ",age="23",team="Alajuelense (CRC)",number=" (9)",lastname="Palacios " },new PlayerModel { name = "Jerry ",age="43",team="New England Revolution (USA)",number="(11)",lastname="Bengtson " },new PlayerModel { name = "Carlo ",age="69",team="Real España (HON)",number="(13)",lastname="Costly " },new PlayerModel { name = "Rony ",age="12",team="Real Sociedad (HON)",number="(16)",lastname="Martínez " }}
            },
            {"hr-croatia",new List<PlayerModel>{new PlayerModel { name = "Stipe ",age="110",team="Rostov (RUS)",number=" (1)",lastname="Pletikosa " },new PlayerModel { name = "Oliver ",age="0",team="Lokomotiva (CRO)",number="(12)",lastname="Zelenika " },new PlayerModel { name = "Danijel ",age="6",team="AS Monaco (FRA)",number="(23)",lastname="Subašić " },new PlayerModel { name = "Šime ",age="6",team="Genoa (ITA)",number=" (2)",lastname="Vrsaljko " },new PlayerModel { name = "Danijel ",age="48",team="Panathinaikos (GRE)",number=" (3)",lastname="Pranjić " },new PlayerModel { name = "Vedran ",age="72",team="Lokomotiv Moscow (RUS)",number=" (5)",lastname="Ćorluka " },new PlayerModel { name = "Dejan ",age="23",team="Southampton (ENG)",number=" (6)",lastname="Lovren " },new PlayerModel { name = "Darijo ",age="112",team="Shakhtar Donetsk (UKR)",number="(11)",lastname="Srna " },new PlayerModel { name = "Gordon ",age="21",team="Panathinaikos (GRE)",number="(13)",lastname="Schildenfeld " },new PlayerModel { name = "Domagoj ",age="23",team="Dynamo Kyiv (UKR)",number="(21)",lastname="Vida " },new PlayerModel { name = "Ivan ",age="28",team="VfL Wolfsburg (GER)",number=" (4)",lastname="Perišić " },new PlayerModel { name = "Ivan ",age="61",team="Sevilla (ESP)",number=" (7)",lastname="Rakitić " },new PlayerModel { name = "Ognjen ",age="55",team="Dynamo Kyiv (UKR)",number=" (8)",lastname="Vukojević " },new PlayerModel { name = "Luka ",age="74",team="Real Madrid (ESP)",number="(10)",lastname="Modrić " },new PlayerModel { name = "Marcelo ",age="0",team="Dinamo Zagreb (CRO)",number="(14)",lastname="Brozović " },new PlayerModel { name = "Ivan ",age="0",team="Rijeka (CRO)",number="(15)",lastname="Močinić " },new PlayerModel { name = "Sammir ",age="5",team="Getafe (SPA)",number="(19)",lastname="## " },new PlayerModel { name = "Mateo ",age="9",team="Internazionale (ITA)",number="(20)",lastname="Kovačić " },new PlayerModel { name = "Nikica ",age="33",team="Hull City (ENG)",number=" (9)",lastname="Jelavić " },new PlayerModel { name = "Ante ",age="4",team="Fiorentina (ITA)",number="(16)",lastname="Rebić " },new PlayerModel { name = "Mario ",age="49",team="Bayern Munich (GER)",number="(17)",lastname="Mandžukić " },new PlayerModel { name = "Ivica ",age="91",team="VfL Wolfsburg (GER)",number="(18)",lastname="Olić " },new PlayerModel { name = "Eduardo ",age="63",team="Shakhtar Donetsk (UKR)",number="(22)",lastname="## " }}
            },
            {"ir-iran",new List<PlayerModel>{new PlayerModel { name = "Rahman ",age="10",team="Sepahan (IRN)",number=" (1)",lastname="Ahmadi " },new PlayerModel { name = "Alireza ",age="5",team="Sporting Covilhã (POR)",number="(12)",lastname="Haghighi " },new PlayerModel { name = "Daniel ",age="4",team="Eintracht Braunschweig (GER)",number="(22)",lastname="Davari " },new PlayerModel { name = "Jalal ",age="84",team="Persepolis (IRN)",number=" (4)",lastname="Hosseini " },new PlayerModel { name = "Amir ",age="16",team="Esteghlal (IRN)",number=" (5)",lastname="Hossein " },new PlayerModel { name = "Hossein ",age="21",team="Persepolis (IRN)",number="(13)",lastname="Mahini " },new PlayerModel { name = "Pejman ",age="21",team="Umm Salal (QAT)",number="(15)",lastname="Montazeri " },new PlayerModel { name = "Ahmad ",age="9",team="Naft Tehran (IRN)",number="(17)",lastname="Alenemeh " },new PlayerModel { name = "Hashem ",age="17",team="Esteghlal (IRN)",number="(19)",lastname="Beikzadeh " },new PlayerModel { name = "Steven ",age="6",team="Vancouver Whitecaps (CAN)",number="(20)",lastname="Beitashour " },new PlayerModel { name = "Mehrdad ",age="19",team="Persepolis (IRN)",number="(23)",lastname="Pouladi " },new PlayerModel { name = "Khosro ",age="48",team="Esteghlal (IRN)",number=" (2)",lastname="Heydari " },new PlayerModel { name = "Ehsan ",age="61",team="Sepahan (IRN)",number=" (3)",lastname="Hajsafi " },new PlayerModel { name = "Javad ",age="139",team="Al-Kuwait (KUW)",number=" (6)",lastname="Nekounam " },new PlayerModel { name = "Masoud ",age="49",team="Las Palmas (ESP)",number=" (7)",lastname="Shojaei " },new PlayerModel { name = "Reza ",age="7",team="Persepolis (IRN)",number=" (8)",lastname="Haghighi " },new PlayerModel { name = "Ghasem ",age="16",team="Zob Ahan (IRN)",number="(11)",lastname="Haddadifar " },new PlayerModel { name = "Andranik ",age="78",team="Esteghlal (IRN)",number="(14)",lastname="Teymourian " },new PlayerModel { name = "Bakhtiar ",age="4",team="Foolad (IRN)",number="(18)",lastname="Rahmani " },new PlayerModel { name = "Ashkan ",age="13",team="Fulham (ENG)",number="(21)",lastname="Dejagah " },new PlayerModel { name = "Alireza ",age="6",team="NEC (NED)",number=" (9)",lastname="Jahanbakhsh " },new PlayerModel { name = "Karim ",age="41",team="Tractor Sazi (IRN)",number="(10)",lastname="Ansarifard " },new PlayerModel { name = "Reza ",age="13",team="Charlton Athletic (ENG)",number="(16)",lastname="Ghoochannejhad " }}
            },
            {"it-italy",new List<PlayerModel>{new PlayerModel { name = "Gianluigi ",age="139",team="Juventus (ITA)",number=" (1)",lastname="Buffon " },new PlayerModel { name = "Salvatore ",age="8",team="Paris Saint-Germain (FRA)",number="(12)",lastname="Sirigu " },new PlayerModel { name = "Mattia ",age="0",team="Genoa (ITA)",number="(13)",lastname="Perin " },new PlayerModel { name = "Mattia ",age="10",team="Milan (ITA)",number=" (2)",lastname="De " },new PlayerModel { name = "Giorgio ",age="67",team="Juventus (ITA)",number=" (3)",lastname="Chiellini " },new PlayerModel { name = "Matteo ",age="1",team="Torino (ITA)",number=" (4)",lastname="Darmian " },new PlayerModel { name = "Ignazio ",age="19",team="Milan (ITA)",number=" (7)",lastname="Abate " },new PlayerModel { name = "Andrea ",age="47",team="Juventus (ITA)",number="(15)",lastname="Barzagli " },new PlayerModel { name = "Leonardo ",age="36",team="Juventus (ITA)",number="(19)",lastname="Bonucci " },new PlayerModel { name = "Gabriel ",age="2",team="Parma (ITA)",number="(20)",lastname="Paletta " },new PlayerModel { name = "Thiago ",age="20",team="Paris Saint-Germain (FRA)",number=" (5)",lastname="Motta " },new PlayerModel { name = "Antonio ",age="19",team="Lazio (ITA)",number=" (6)",lastname="Candreva " },new PlayerModel { name = "Claudio ",age="43",team="Juventus (ITA)",number=" (8)",lastname="Marchisio " },new PlayerModel { name = "Alberto ",age="34",team="Fiorentina (ITA)",number="(14)",lastname="Aquilani " },new PlayerModel { name = "Daniele ",age="94",team="Roma (ITA)",number="(16)",lastname="De " },new PlayerModel { name = "Marco ",age="3",team="Parma (ITA)",number="(18)",lastname="Parolo " },new PlayerModel { name = "Andrea ",age="108",team="Juventus (ITA)",number="(21)",lastname="Pirlo " },new PlayerModel { name = "Marco ",age="5",team="Paris Saint-Germain (FRA)",number="(23)",lastname="Verratti " },new PlayerModel { name = "Mario ",age="29",team="Milan (ITA)",number=" (9)",lastname="Balotelli " },new PlayerModel { name = "Antonio ",age="36",team="Parma (ITA)",number="(10)",lastname="Cassano " },new PlayerModel { name = "Alessio ",age="11",team="Torino (ITA)",number="(11)",lastname="Cerci " },new PlayerModel { name = "Ciro ",age="2",team="Torino (ITA)",number="(17)",lastname="Immobile " },new PlayerModel { name = "Lorenzo ",age="4",team="Napoli (ITA)",number="(22)",lastname="Insigne " }}
            },
            {"jp-japan",new List<PlayerModel>{new PlayerModel { name = "Eiji ",age="56",team="Standard Liège (BEL)",number=" (1)",lastname="Kawashima " },new PlayerModel { name = "Shusaku ",age="12",team="Urawa Red Diamonds (JPN)",number="(12)",lastname="Nishikawa " },new PlayerModel { name = "Shūichi ",age="2",team="F.C. Tokyo (JPN)",number="(23)",lastname="Gonda " },new PlayerModel { name = "Atsuto ",age="67",team="Schalke 04 (GER)",number=" (2)",lastname="Uchida " },new PlayerModel { name = "Gōtoku ",age="12",team="VfB Stuttgart (GER)",number=" (3)",lastname="Sakai " },new PlayerModel { name = "Yuto ",age="69",team="Internazionale (ITA)",number=" (5)",lastname="Nagatomo " },new PlayerModel { name = "Masato ",age="9",team="F.C. Tokyo (JPN)",number=" (6)",lastname="Morishige " },new PlayerModel { name = "Yasuyuki ",age="80",team="Gamba Osaka (JPN)",number="(15)",lastname="Konno " },new PlayerModel { name = "Masahiko ",age="21",team="Jubilo Iwata (JPN)",number="(19)",lastname="Inoha " },new PlayerModel { name = "Hiroki ",age="17",team="Hannover 96 (GER)",number="(21)",lastname="Sakai " },new PlayerModel { name = "Maya ",age="40",team="Southampton (ENG)",number="(22)",lastname="Yoshida " },new PlayerModel { name = "Keisuke ",age="55",team="Milan (ITA)",number=" (4)",lastname="Honda " },new PlayerModel { name = "Yasuhito ",age="143",team="Gamba Osaka (JPN)",number=" (7)",lastname="Endō " },new PlayerModel { name = "Hiroshi ",age="25",team="1. FC Nürnberg (GER)",number=" (8)",lastname="Kiyotake " },new PlayerModel { name = "Shinji ",age="56",team="Manchester United (ENG)",number="(10)",lastname="Kagawa " },new PlayerModel { name = "Toshihiro ",age="5",team="Sanfrecce Hiroshima (JPN)",number="(14)",lastname="Aoyama " },new PlayerModel { name = "Hotaru ",age="11",team="Cerezo Osaka (JPN)",number="(16)",lastname="Yamaguchi " },new PlayerModel { name = "Makoto ",age="78",team="1. FC Nürnberg (GER)",number="(17)",lastname="Hasebe " },new PlayerModel { name = "Shinji ",age="75",team="Mainz 05 (GER)",number=" (9)",lastname="Okazaki " },new PlayerModel { name = "Yoichiro ",age="11",team="Cerezo Osaka (JPN)",number="(11)",lastname="Kakitani " },new PlayerModel { name = "Yoshito ",age="56",team="Kawasaki Frontale (JPN)",number="(13)",lastname="Ōkubo " },new PlayerModel { name = "Yuya ",age="8",team="1860 München (GER)",number="(18)",lastname="Osako " },new PlayerModel { name = "Manabu ",age="4",team="Yokohama F. Marinos (JPN)",number="(20)",lastname="Saitō " }}
            },
            {"kr-south-korea",new List<PlayerModel>{new PlayerModel { name = "Jung ",age="60",team="Suwon Bluewings (KOR)",number=" (1)",lastname="Sung-Ryong " },new PlayerModel { name = "Kim ",age="5",team="Ulsan Hyundai (KOR)",number="(21)",lastname="Seung-Gyu " },new PlayerModel { name = "Lee ",age="0",team="Busan I'Park (KOR)",number="(23)",lastname="Bum-Young " },new PlayerModel { name = "Kim ",age="8",team="Kashiwa Reysol (JPN)",number=" (2)",lastname="Chang-Soo " },new PlayerModel { name = "Yun ",age="3",team="Queens Park Rangers (ENG)",number=" (3)",lastname="Suk-Young " },new PlayerModel { name = "Kwak ",age="34",team="Al-Hilal (KSA)",number=" (4)",lastname="Tae-Hwi " },new PlayerModel { name = "Kim ",age="20",team="Guangzhou Evergrande (CHN)",number=" (5)",lastname="Young-Gwon " },new PlayerModel { name = "Hwang ",age="3",team="Sanfrecce Hiroshima (JPN)",number=" (6)",lastname="Seok-Ho " },new PlayerModel { name = "Lee ",age="11",team="Ulsan Hyundai (KOR)",number="(12)",lastname="Yong " },new PlayerModel { name = "Hong ",age="24",team="FC Augsburg (GER)",number="(20)",lastname="Jeong-Ho " },new PlayerModel { name = "Park ",age="13",team="Mainz 05 (GER)",number="(22)",lastname="Joo-Ho " },new PlayerModel { name = "Kim ",age="27",team="Cardiff City (WAL)",number=" (7)",lastname="Bo-Kyung " },new PlayerModel { name = "Ha ",age="13",team="Beijing Guoan (CHN)",number=" (8)",lastname="Dae-Sung " },new PlayerModel { name = "Koo ",age="36",team="Mainz 05 (GER)",number="(13)",lastname="Ja-Cheol " },new PlayerModel { name = "Han ",age="9",team="Kashiwa Reysol (JPN)",number="(14)",lastname="Kook-Young " },new PlayerModel { name = "Park ",age="10",team="Guangzhou R&F (CHN)",number="(15)",lastname="Jong-Woo " },new PlayerModel { name = "Ki ",age="58",team="Sunderland (ENG)",number="(16)",lastname="Sung-Yueng " },new PlayerModel { name = "Lee ",age="54",team="Bolton Wanderers (ENG)",number="(17)",lastname="Chung-Yong " },new PlayerModel { name = "Son ",age="24",team="Bayer Leverkusen (GER)",number=" (9)",lastname="Heung-Min " },new PlayerModel { name = "Park ",age="63",team="Watford (ENG)",number="(10)",lastname="Chu-Young " },new PlayerModel { name = "Lee ",age="63",team="Sangju Sangmu (KOR)",number="(11)",lastname="Keun-Ho " },new PlayerModel { name = "Kim ",age="26",team="Ulsan Hyundai (KOR)",number="(18)",lastname="Shin-Wook " },new PlayerModel { name = "Ji ",age="27",team="FC Augsburg (GER)",number="(19)",lastname="Dong-Won " }}
            },
            {"mx-mexico",new List<PlayerModel>{}
            },
            {"ng-nigeria",new List<PlayerModel>{new PlayerModel { name = "Vincent ",age="90",team="Lille (FRA)",number=" (1)",lastname="Enyeama " },new PlayerModel { name = "Austin ",age="32",team="Hapoel Be'er Sheva (ISR)",number="(16)",lastname="Ejide " },new PlayerModel { name = "Chigozie ",age="11",team="Gombe United (NGA)",number="(21)",lastname="Agbim " },new PlayerModel { name = "Joseph ",age="96",team="Norwich City (ENG)",number=" (2)",lastname="Yobo " },new PlayerModel { name = "Uwa ",age="42",team="AS Monaco (FRA)",number=" (3)",lastname="Elderson " },new PlayerModel { name = "Efe ",age="36",team="Celtic (SCO)",number=" (5)",lastname="Ambrose " },new PlayerModel { name = "Azubuike ",age="32",team="Warri Wolves (NGA)",number=" (6)",lastname="Egwuekwe " },new PlayerModel { name = "Kunle ",age="10",team="Sunshine Stars (NGA)",number="(12)",lastname="Odunlami " },new PlayerModel { name = "Juwon ",age="10",team="Ashdod (ISR)",number="(13)",lastname="Oshaniwa " },new PlayerModel { name = "Godfrey ",age="35",team="Çaykur Rizespor (TUR)",number="(14)",lastname="Oboabona " },new PlayerModel { name = "Kenneth ",age="17",team="Middlesbrough (ENG)",number="(22)",lastname="Omeruo " },new PlayerModel { name = "Reuben ",age="11",team="Waasland-Beveren (BEL)",number=" (4)",lastname="Gabriel " },new PlayerModel { name = "John ",age="59",team="Chelsea (ENG)",number="(10)",lastname="Obi " },new PlayerModel { name = "Victor ",age="20",team="Liverpool (ENG)",number="(11)",lastname="Moses " },new PlayerModel { name = "Ramon ",age="1",team="Almería (ESP)",number="(15)",lastname="Azeez " },new PlayerModel { name = "Ogenyi ",age="20",team="Lazio (ITA)",number="(17)",lastname="Onazi " },new PlayerModel { name = "Michael ",age="4",team="Volyn Lutsk (UKR)",number="(18)",lastname="Babatunde " },new PlayerModel { name = "Ahmed ",age="35",team="CSKA Moscow (RUS)",number=" (7)",lastname="Musa " },new PlayerModel { name = "Peter ",age="60",team="Stoke City (ENG)",number=" (8)",lastname="Odemwingie " },new PlayerModel { name = "Emmanuel ",age="22",team="Fenerbahçe (TUR)",number=" (9)",lastname="Emenike " },new PlayerModel { name = "Uche ",age="6",team="Heerenveen (NED)",number="(19)",lastname="Nwofor " },new PlayerModel { name = "Michael ",age="3",team="Cercle Brugge (BEL)",number="(20)",lastname="Uchebo " },new PlayerModel { name = "Shola ",age="6",team="Newcastle United (ENG)",number="(23)",lastname="Ameobi " }}
            },
            {"nl-netherlands",new List<PlayerModel>{new PlayerModel { name = "Jasper ",age="7",team="Ajax",number=" (1)",lastname="Cillessen " },new PlayerModel { name = "Michel ",age="14",team="Swansea City (WAL)",number="(22)",lastname="Vorm " },new PlayerModel { name = "Tim ",age="5",team="Newcastle United (ENG)",number="(23)",lastname="Krul " },new PlayerModel { name = "Ron ",age="23",team="Aston Villa (ENG)",number=" (2)",lastname="Vlaar " },new PlayerModel { name = "Stefan ",age="11",team="Feyenoord (NED)",number=" (3)",lastname="de " },new PlayerModel { name = "Bruno ",age="15",team="Feyenoord (NED)",number=" (4)",lastname="Martins " },new PlayerModel { name = "Daley ",age="11",team="Ajax (NED)",number=" (5)",lastname="Blind " },new PlayerModel { name = "Daryl ",age="15",team="Feyenoord",number=" (7)",lastname="Janmaat " },new PlayerModel { name = "Paul ",age="2",team="Augsburg (GER)",number="(12)",lastname="Verhaegh " },new PlayerModel { name = "Joël ",age="2",team="Ajax (NED)",number="(13)",lastname="Veltman " },new PlayerModel { name = "Terence ",age="1",team="Feyenoord (NED)",number="(14)",lastname="Kongolo " },new PlayerModel { name = "Jonathan ",age="10",team="Swansea City (WAL)",number=" (6)",lastname="de " },new PlayerModel { name = "Nigel ",age="70",team="Milan (ITA)",number=" (8)",lastname="de " },new PlayerModel { name = "Wesley ",age="98",team="Galatasaray (TUR)",number="(10)",lastname="Sneijder " },new PlayerModel { name = "Arjen ",age="74",team="Bayern Munich (GER)",number="(11)",lastname="Robben " },new PlayerModel { name = "Jordy ",age="8",team="Feyenoord (NED)",number="(16)",lastname="Clasie " },new PlayerModel { name = "Leroy ",age="5",team="Norwich City (ENG)",number="(18)",lastname="Fer " },new PlayerModel { name = "Georginio ",age="4",team="PSV (NED)",number="(20)",lastname="Wijnaldum " },new PlayerModel { name = "Memphis ",age="6",team="PSV (NED)",number="(21)",lastname="Depay " },new PlayerModel { name = "Robin ",age="84",team="Manchester United (ENG)",number=" (9)",lastname="van " },new PlayerModel { name = "Dirk ",age="98",team="Fenerbahçe (TUR)",number="(15)",lastname="Kuyt " },new PlayerModel { name = "Jeremain ",age="21",team="Dynamo Kyiv (UKR)",number="(17)",lastname="Lens " },new PlayerModel { name = "Klaas-Jan ",age="61",team="Schalke 04 (GER)",number="(19)",lastname="Huntelaar " }}
            },
            {"pt-portugal",new List<PlayerModel>{new PlayerModel { name = "Eduardo ",age="33",team="Braga (POR)",number=" (1)",lastname="## " },new PlayerModel { name = "Rui ",age="29",team="Sporting (POR)",number="(12)",lastname="Patrício " },new PlayerModel { name = "Beto ",age="7",team="Sevilla (ESP)",number="(22)",lastname="## " },new PlayerModel { name = "Bruno ",age="71",team="Fenerbahçe (TUR)",number=" (2)",lastname="Alves " },new PlayerModel { name = "Pepe ",age="57",team="Real Madrid (ESP)",number=" (3)",lastname="## " },new PlayerModel { name = "Fábio ",age="43",team="Real Madrid (ESP)",number=" (5)",lastname="Coentrão " },new PlayerModel { name = "Ricardo ",age="18",team="Valencia (ESP)",number="(13)",lastname="Costa " },new PlayerModel { name = "Luís ",age="7",team="Zenit Saint Petersburg (RUS)",number="(14)",lastname="Neto " },new PlayerModel { name = "André ",age="3",team="Benfica (POR)",number="(19)",lastname="Almeida " },new PlayerModel { name = "João ",age="35",team="Valencia (ESP)",number="(21)",lastname="Pereira " },new PlayerModel { name = "Miguel ",age="47",team="Dynamo Kyiv (UKR)",number=" (4)",lastname="Veloso " },new PlayerModel { name = "William ",age="3",team="Sporting (POR)",number=" (6)",lastname="Carvalho " },new PlayerModel { name = "João ",age="66",team="AS Monaco (FRA)",number=" (8)",lastname="Moutinho " },new PlayerModel { name = "Vieirinha ",age="7",team="VfL Wolfsburg (GER)",number="(10)",lastname="## " },new PlayerModel { name = "Rafa ",age="2",team="Braga (POR)",number="(15)",lastname="Silva " },new PlayerModel { name = "Raul ",age="73",team="Fenerbahçe (TUR)",number="(16)",lastname="Meireles " },new PlayerModel { name = "Nani ",age="73",team="Manchester United (ENG)",number="(17)",lastname="## " },new PlayerModel { name = "Silvestre ",age="22",team="Porto (POR)",number="(18)",lastname="Varela " },new PlayerModel { name = "Rúben ",age="11",team="Benfica (POR)",number="(20)",lastname="Amorim " },new PlayerModel { name = "Cristiano ",age="110",team="Real Madrid (ESP)",number=" (7)",lastname="Ronaldo " },new PlayerModel { name = "Hugo ",age="54",team="Beşiktaş (TUR)",number=" (9)",lastname="Almeida " },new PlayerModel { name = "Éder ",age="7",team="Braga (POR)",number="(11)",lastname="## " },new PlayerModel { name = "Hélder ",age="67",team="Lazio (ITA)",number="(23)",lastname="Postiga " }}
            },
            {"ru-russia",new List<PlayerModel>{new PlayerModel { name = "Igor ",age="67",team="CSKA Moscow",number=" (1)",lastname="Akinfeev " },new PlayerModel { name = "Yuri ",age="2",team="Zenit Saint Petersburg",number="(12)",lastname="Lodygin " },new PlayerModel { name = "Sergey ",age="1",team="Rubin Kazan",number="(16)",lastname="Ryzhikov " },new PlayerModel { name = "Aleksei ",age="10",team="Dynamo Moscow",number=" (2)",lastname="Kozlov " },new PlayerModel { name = "Georgi ",age="3",team="CSKA Moscow",number=" (3)",lastname="Shchennikov " },new PlayerModel { name = "Sergei ",age="95",team="CSKA Moscow",number=" (4)",lastname="Ignashevich " },new PlayerModel { name = "Andrei ",age="1",team="Terek Grozny",number=" (5)",lastname="Semyonov " },new PlayerModel { name = "Vladimir ",age="4",team="Dynamo Moscow",number="(13)",lastname="Granat " },new PlayerModel { name = "Vasili ",age="77",team="CSKA Moscow",number="(14)",lastname="Berezutski " },new PlayerModel { name = "Andrey ",age="11",team="Anzhi Makhachkala",number="(22)",lastname="Yeshchenko " },new PlayerModel { name = "Dmitri ",age="21",team="Spartak Moscow",number="(23)",lastname="Kombarov " },new PlayerModel { name = "Igor ",age="42",team="Dynamo Moscow",number=" (7)",lastname="Denisov " },new PlayerModel { name = "Denis ",age="26",team="Spartak Moscow",number=" (8)",lastname="Glushakov " },new PlayerModel { name = "Alan ",age="31",team="CSKA Moscow",number="(10)",lastname="Dzagoev " },new PlayerModel { name = "Roman ",age="40",team="Krasnodar",number="(15)",lastname="Shirokov " },new PlayerModel { name = "Oleg ",age="6",team="Zenit Saint Petersburg",number="(17)",lastname="Shatov " },new PlayerModel { name = "Viktor ",age="18",team="Zenit Saint Petersburg",number="(20)",lastname="Fayzulin " },new PlayerModel { name = "Maksim ",age="2",team="Rubin Kazan",number=" (6)",lastname="Kanunnikov " },new PlayerModel { name = "Aleksandr ",age="20",team="Dynamo Moscow",number=" (9)",lastname="Kokorin " },new PlayerModel { name = "Aleksandr ",age="79",team="Zenit Saint Petersburg",number="(11)",lastname="Kerzhakov " },new PlayerModel { name = "Yuri ",age="59",team="Dynamo Moscow",number="(18)",lastname="Zhirkov " },new PlayerModel { name = "Aleksandr ",age="16",team="Lokomotiv Moscow",number="(19)",lastname="Samedov " },new PlayerModel { name = "Aleksei ",age="5",team="Dynamo Moscow",number="(21)",lastname="Ionov " }}
            },
            {"us-united-states",new List<PlayerModel>{new PlayerModel { name = "Tim ",age="99",team="Everton (ENG)",number=" (1)",lastname="Howard " },new PlayerModel { name = "Brad ",age="25",team="Aston Villa (ENG)",number="(12)",lastname="Guzan " },new PlayerModel { name = "Nick ",age="14",team="Real Salt Lake (USA)",number="(22)",lastname="Rimando " },new PlayerModel { name = "DeAndre ",age="4",team="Seattle Sounders FC (USA)",number=" (2)",lastname="Yedlin " },new PlayerModel { name = "Omar ",age="19",team="Los Angeles Galaxy (USA)",number=" (3)",lastname="Gonzalez " },new PlayerModel { name = "Matt ",age="16",team="Sporting Kansas City (USA)",number=" (5)",lastname="Besler " },new PlayerModel { name = "John ",age="4",team="Hertha BSC (GER)",number=" (6)",lastname="Brooks " },new PlayerModel { name = "DaMarcus ",age="115",team="Puebla (MEX)",number=" (7)",lastname="Beasley " },new PlayerModel { name = "Geoff ",age="26",team="Stoke City (ENG)",number="(20)",lastname="Cameron " },new PlayerModel { name = "Timothy ",age="12",team="1. FC Nürnberg (GER)",number="(21)",lastname="Chandler " },new PlayerModel { name = "Fabian ",age="21",team="1899 Hoffenheim (GER)",number="(23)",lastname="Johnson " },new PlayerModel { name = "Michael ",age="85",team="Toronto FC (CAN)",number=" (4)",lastname="Bradley " },new PlayerModel { name = "Mikkel ",age="19",team="Rosenborg (NOR)",number="(10)",lastname="Diskerud " },new PlayerModel { name = "Alejandro ",age="27",team="Nantes (FRA)",number="(11)",lastname="Bedoya " },new PlayerModel { name = "Jermaine ",age="41",team="Beşiktaş (TUR)",number="(13)",lastname="Jones " },new PlayerModel { name = "Brad ",age="16",team="Houston Dynamo (USA)",number="(14)",lastname="Davis " },new PlayerModel { name = "Kyle ",age="36",team="Real Salt Lake (USA)",number="(15)",lastname="Beckerman " },new PlayerModel { name = "Julian ",age="2",team="Bayern Munich (GER)",number="(16)",lastname="Green " },new PlayerModel { name = "Graham ",age="22",team="Sporting Kansas City (USA)",number="(19)",lastname="Zusi " },new PlayerModel { name = "Clint ",age="104",team="Seattle Sounders FC (USA)",number=" (8)",lastname="Dempsey " },new PlayerModel { name = "Aron ",age="8",team="AZ (NED)",number=" (9)",lastname="Jóhannsson " },new PlayerModel { name = "Jozy ",age="69",team="Sunderland (ENG)",number="(17)",lastname="Altidore " },new PlayerModel { name = "Chris ",age="20",team="San Jose Earthquakes (USA)",number="(18)",lastname="Wondolowski " }}
            },
            {"uy-uruguay",new List<PlayerModel>
            {
                new PlayerModel { name = "Fernando ",age="57",team="Galatasaray (TUR)",number=" (1)",lastname="Muslera " },new PlayerModel { name = "Rodrigo ",age="0",team="Libertad (PAR)",number="(12)",lastname="Muñoz " },new PlayerModel { name = "Martín ",age="4",team="Vasco da Gama (BRA)",number="(23)",lastname="Silva " },new PlayerModel { name = "Diego ",age="93",team="West Bromwich Albion (ENG)",number=" (2)",lastname="Lugano " },new PlayerModel { name = "Diego ",age="76",team="Atlético Madrid (ESP)",number=" (3)",lastname="Godín " },new PlayerModel { name = "Sebastián ",age="14",team="Nacional (URU)",number=" (4)",lastname="Coates " },new PlayerModel { name = "Jorge ",age="41",team="Porto (POR)",number="(13)",lastname="Fucile " },new PlayerModel { name = "Maxi ",age="89",team="Benfica (POR)",number="(16)",lastname="Pereira " },new PlayerModel { name = "José ",age="5",team="Atlético Madrid (ESP)",number="(19)",lastname="María " },new PlayerModel { name = "Martín ",age="56",team="Juventus (ITA)",number="(22)",lastname="Cáceres " },new PlayerModel { name = "Walter ",age="62",team="Parma (ITA)",number=" (5)",lastname="Gargano " },new PlayerModel { name = "Álvaro ",age="56",team="São Paulo (BRA)",number=" (6)",lastname="Pereira " },new PlayerModel { name = "Cristian ",age="72",team="Atlético Madrid (ESP)",number=" (7)",lastname="Rodríguez " },new PlayerModel { name = "Nicolás ",age="26",team="Botafogo (BRA)",number="(14)",lastname="Lodeiro " },new PlayerModel { name = "Diego ",age="89",team="Bologna (ITA)",number="(15)",lastname="Pérez " },new PlayerModel { name = "Egidio ",age="54",team="Morelia (MEX)",number="(17)",lastname="Arévalo " },new PlayerModel { name = "Gastón ",age="28",team="Southampton (ENG)",number="(18)",lastname="Ramírez " },new PlayerModel { name = "Álvaro ",age="42",team="Lazio (ITA)",number="(20)",lastname="González " },new PlayerModel { name = "Abel ",age="12",team="Palermo (ITA)",number=" (8)",lastname="Hernández " },new PlayerModel { name = "Luis ",age="77",team="Liverpool (ENG)",number=" (9)",lastname="Suárez " },new PlayerModel { name = "Diego ",age="109",team="Cerezo Osaka (JPN)",number="(10)",lastname="Forlán " },new PlayerModel { name = "Christian ",age="9",team="Espanyol (ESP)",number="(11)",lastname="Stuani " },new PlayerModel { name = "Edinson ",age="61",team="Paris Saint-Germain (FRA)",number="(21)",lastname="Cavani " }
            }
             }});
        }
    }
}
