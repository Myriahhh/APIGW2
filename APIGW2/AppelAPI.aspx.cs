using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace APIGW2
{
    public class Event
    {
        public string Id { get; set; }
        public string Type { get; set; }
    }

    public class Wing
    {
        public string Id { get; set; }
        public List<Event> Events { get; set; }
    }

    public class RaidWing
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("wings")]
        public List<Wing> Wings { get; set; }
    }

    //Projets API GW2
   /* public class ListBoss
    {
        public string id { get; set; }
        public string type { get; set; }
    }
    public class Wing
    {
        public string id { get; set; }
        public List<ListBoss> events { get; set; }
    }
    public class ListWing
    {
         public string id { get; set; }
         public List<Wing> wings { get; set; }
    }
    public class Raids
    {
        public List<ListWing> compileRaid { get; set; }
    }
   */
    internal class APIGW2V2RAID
    {
        private readonly string BaseURI = "https://api.guildwars2.com/v2/";
        private readonly string URIRaid = "account/raids?access_token=";
        string testPushGit;

        public List<string> RaidInit()
        {
            List<string> result = new List<string>();
            WebClient client = new WebClient();

            string myJSON = client.DownloadString("https://api.guildwars2.com/v2/raids");

            result = JsonConvert.DeserializeObject<List<string>>(myJSON);

            return result;

        }
        public void TestRaid()
        {
            List<string> result = new List<string>(); 
            result = RaidInit();
            var chaineboss = String.Join(",", result);
            WebClient client = new WebClient();

            string myJSON = client.DownloadString(@"https://api.guildwars2.com/v2/raids?ids=" + chaineboss) ;

            
            RaidWing[] myDeserializedObjList = JsonConvert.DeserializeObject<RaidWing[]>(myJSON);
            string bla = myDeserializedObjList[myDeserializedObjList.Count()-1].Wings[0].Events[0].Id;
            //Raids myDeserializedClass = JsonConvert.DeserializeObject<Raids>(myJSON);
            //myDeserializedClass[0].MyArray[0].wings[0].id.ToString();
        }

        protected void BossDone()
        {

        //https://api.guildwars2.com/v2/raids?ids=forsaken_thicket,bastion_of_the_penitent,hall_of_chains,mythwright_gambit,the_key_of_ahdashim
        }
        

    }

    // TEST ZONE
    public class ListeDonjons
    {
        public string Nom { get; set; }
    }
   /* public class Root
    {
        public int id { get; set; }
    }
    */
    internal class CheckRaidDone
    {
        private readonly string token = "83E933A4-C5B4-064E-89B4-6C596607AF52A70B7656-8025-42C1-96CA-29D84CD11033";
        private readonly string BaseURI = "https://api.guildwars2.com/v2/";
        private readonly string URIRaid = "account/raids?access_token=";

        //https://api.guildwars2.com/v2/guild/7E73F4B6-814D-E811-81A8-06006DED2D04?access_token=83E933A4-C5B4-064E-89B4-6C596607AF52A70B7656-8025-42C1-96CA-29D84CD11033
        //https://api.guildwars2.com/v2/guild/7E73F4B6-814D-E811-81A8-06006DED2D04/log?access_token=83E933A4-C5B4-064E-89B4-6C596607AF52A70B7656-8025-42C1-96CA-29D84CD11033 log pour la depose des sous
        public string WeeklyBossDoneAPI()
        {
            WebClient client = new WebClient();
            string myJSON = client.DownloadString(BaseURI + URIRaid + token);
            return myJSON;
        }
    }

    public partial class AppelAPI : System.Web.UI.Page
    {

    protected void Page_Load(object sender, EventArgs e)
       {


            WebClient client = new WebClient();

            string myJSON = client.DownloadString("https://api.guildwars2.com/v2/build?access_token=83E933A4-C5B4-064E-89B4-6C596607AF52A70B7656-8025-42C1-96CA-29D84CD11033");

            RaidWing myDeserializedClass = JsonConvert.DeserializeObject<RaidWing>(myJSON);
            // Create the web request

            //string test = Donjons.ListeDonjons[1].ToString();

            //string json = client.DownloadString("https://api.guildwars2.com/v2/raid?access_token=83E933A4-C5B4-064E-89B4-6C596607AF52A70B7656-8025-42C1-96CA-29D84CD11033");

            //List<string> videogames = JsonConvert.DeserializeObject<List<string>>(json);

            CheckRaidDone blabla = new CheckRaidDone();
            string test = blabla.WeeklyBossDoneAPI();


            List<string> result = JsonConvert.DeserializeObject<List<string>>(test);

            List<string> BossDone = new List<string>();

            foreach (string name in result)
            {
                BossDone.Add(name);
            }

            
            rptResults1.DataSource = BossDone;
            rptResults1.DataBind();


            //TEST

            APIGW2V2RAID api = new APIGW2V2RAID();
            api.RaidInit();
            api.TestRaid();
            Class1 bouh = new Class1();
            bouh.TestPushGitBoulot.ToString();
        }
    }
}