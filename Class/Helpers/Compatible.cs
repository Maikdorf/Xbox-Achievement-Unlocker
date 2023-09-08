using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Xbox_Achievement_Unlocker.Class.Helpers
{
    internal class Compatible
    {
        private string _token;
        private string _xuid;
        private const int TIME_SLEEP_REQUEST = 9202;
        private const string REQUEREMENT_ID = "00000000-0000-0000-0000-000000000000";

        public string Token { get => _token; set => _token = value; }
        public string Xuid { get => _xuid; set => _xuid = value; }

        public Compatible(string token,string xuid) 
        {
            _token = token;
            _xuid = xuid;
            Task.Run(async () =>
            {
                await ScanAllAchievementsList(Token, Xuid);
            });            
        }

        private async Task ScanAllAchievementsList(string Token, string Xuid)
        {
            String line;
            try
            {

                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new("GameList.txt");
                //Read the first line of text
                line = sr.ReadLine();

                string txtFile = "[";
                while (line != null)
                {
                    string[] row = line.Split(",");

                    if (row[0] != "" && row[2] == "unknown")
                    {
                        string stats = StatsTrueAchivements(Convert.ToString(row[1]));
                        Thread.Sleep(TIME_SLEEP_REQUEST);
                        RequestXbox rqXbox = new();
                        await rqXbox.Get_Data("achievements", Token, Xuid, row[0]);
                        try
                        {
                            if (rqXbox.JsonResponse != null && rqXbox.JsonResponse.achievements.Count > 0)
                            {
                                dynamic Achievements = rqXbox.JsonResponse.achievements;
                                string TitleName = Achievements[0].titleAssociations[0].name;
                                string TitleId = Achievements[0].titleAssociations[0].id;
                                string isCompible = "true";

                                for (int i = 0; i < Achievements.Count; i++)
                                {
                                    int CountAchievements = Achievements[i].progression.requirements.Count;
                                    string RequirementsId = Achievements[i].progression.requirements[0].id;
                                    isCompible = (CountAchievements != 0 && RequirementsId != REQUEREMENT_ID) ? "false" : "true";

                                    Achievements[i].Remove("titleAssociations");
                                    Achievements[i].Remove("progressState");
                                    Achievements[i].Remove("progression");
                                    Achievements[i].Remove("achievementType");
                                    Achievements[i].Remove("participationType");
                                    Achievements[i].Remove("timeWindow");
                                    Achievements[i].Remove("estimatedTime");
                                    Achievements[i].Remove("deeplink");
                                    Achievements[i].Remove("isRevoked");

                                }

                                txtFile += "[{ " +
                                    "\"id\": " + TitleId + ", " +
                                    "\"name\": \"" + TitleName + "\", " +
                                    "\"isCompatible\": " + isCompible + "," +
                                    "\"timeCompletion\": \"" + stats + "\"," +
                                    "\"achievements\": " + Convert.ToString(Achievements) +
                                    "}],";
                            }
                        }
                        catch (HttpRequestException ex)
                        {
                            Debug.WriteLine(ex.Message);
                            continue;
                        }
                    }
                    line = sr.ReadLine();
                }
                
                txtFile = txtFile.Remove(txtFile.Length - 1);
                txtFile += "]";

                try
                {
                    using (StreamWriter writer = new StreamWriter("JsonGamesAchievements.json"))
                    {
                        writer.WriteLine(txtFile);
                    }
                }
                catch (HttpRequestException ex){}
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Debug.WriteLine("Executing finally block.");
            }
            return;
        }
        private string StatsTrueAchivements(string nameGame)
        {
            try
            {
                string[] scapeCharacter = { "'", "®", "™", "’", ":", "(", ")", "-", "!", "™" };
                foreach (var character in scapeCharacter)
                    nameGame = nameGame.Replace(character, "");

                nameGame = nameGame.Replace(" ", "-");
                HtmlAgilityPack.HtmlWeb web = new();
                HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.trueachievements.com/game/" + nameGame + "/completiontime");
                if (doc.DocumentNode.SelectNodes("//*[@id=\"divInfo\"]/p[1]/strong") != null)
                {
                    foreach (var item in doc.DocumentNode.SelectNodes("//*[@id=\"divInfo\"]/p[1]/strong"))
                    {
                        return item.InnerText.ToString();
                    }
                }
                return "No Data!";
            }
            catch
            {
                return "Error Data!";
                throw;
            }
        }
    }
}
