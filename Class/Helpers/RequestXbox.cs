using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xbox_Achievement_Unlocker.Class.Helpers
{
    internal class RequestXbox
    {
        public dynamic JsonResponse;
        public Dictionary<string, Dictionary<string, string>> QueryParameter = new Dictionary<string, Dictionary<string, string>>()
        {
            { 
                "profile" , new Dictionary<string, string>(){
                    { "host", "profile.xboxlive.com" },
                    { "ContractVersion","2" },
                    { "url", "https://profile.xboxlive.com/users/me/profile/settings?settings=Gamertag,Gamerscore,GameDisplayPicRaw" }
                }
            },
            {
                "titles" , new Dictionary<string, string>(){
                    { "host", "titlehub.xboxlive.com" },
                    { "ContractVersion","2" },
                    { "url", "https://titlehub.xboxlive.com/users/xuid(#XUID#)/titles/titleHistory/decoration/Achievement,scid" }
                }
            },
            {
                "achievements" , new Dictionary<string, string>(){
                    { "host", "achievements.xboxlive.com" },
                    { "ContractVersion","4" },
                    { "url", "https://achievements.xboxlive.com/users/xuid(#XUID#)/achievements?titleId=#TITLE_ID#&maxItems=1000" }
                }
            },
            {
                "unlock" , new Dictionary<string, string>(){
                    { "host", "achievements.xboxlive.com" },
                    { "ContractVersion","2" },
                    { "url", "https://achievements.xboxlive.com/users/xuid(#XUID#)/achievements/#SCID#/update" }
                }
            },
            {
                "spoof" , new Dictionary<string, string>(){
                    { "host", "achievements.xboxlive.com" },
                    { "ContractVersion","3" },
                    { "url", "https://presence-heartbeat.xboxlive.com/users/xuid(#XUID#)/devices/current" }
                }
            }
        };

        public async Task Get_Data(string UrlProfile, string Token, string Xuid = "", string TitleID = "",string Lang = "en-US")
        {

            try
            {
                HttpClientHandler handler = new()
                {
                    AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
                };
                HttpClient client = new(handler);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("x-xbl-contract-version", QueryParameter[UrlProfile]["ContractVersion"]);
                client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
                client.DefaultRequestHeaders.Add("accept", "application/json");
                client.DefaultRequestHeaders.Add("accept-language", Lang);
                client.DefaultRequestHeaders.Add("Authorization", Token);
                client.DefaultRequestHeaders.Add("Host", QueryParameter[UrlProfile]["host"]);
                client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
                string Url = QueryParameter[UrlProfile]["url"].Replace("#XUID#", Xuid).Replace("#TITLE_ID#", TitleID);

                var responseString = await client.GetStringAsync(Url);
                JsonResponse = (dynamic)JObject.Parse(responseString);
            }
            catch (HttpRequestException ex)
            {
                switch ((int)ex.StatusCode)
                {
                    case 401:
                        MessageBox.Show("Xauth is not correct. Click the Reload Xbox App button until the error goes away", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 404:
                        MessageBox.Show("Not Found!. How did you get here?", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 500:
                        MessageBox.Show("Error Server Xbox !Nothing to do!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("something did a fucky wucky and I dont have a specific message for the error code", "fucky wucky", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error In RequestXbox", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void Set_Data(string UrlProfile, string Token, string Body, string Xuid = "", string TitleID = "", string Scid = "", string Lang = "en-US")
        {
            try
            {
                string requestBody = "{\"action\":\"progressUpdate\",\"serviceConfigId\":\"" +
                    Scid + "\",\"titleId\":\"" +
                    TitleID + "\",\"userId\":\"" +
                    Xuid + "\",\"achievements\":[" +
                    Body.TrimEnd(',') + "]}";

                StringContent Bodyconverted = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpClientHandler handler = new()
                {
                    AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
                };
                HttpClient client = new(handler);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Add("x-xbl-contract-version", QueryParameter[UrlProfile]["ContractVersion"]);
                client.DefaultRequestHeaders.Add("Authorization", Token);
                client.DefaultRequestHeaders.Add("accept", "application/json");
                if (UrlProfile == "unlock")
                {
                    client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
                    client.DefaultRequestHeaders.Add("accept-language", Lang);
                    client.DefaultRequestHeaders.Add("Host", QueryParameter[UrlProfile]["host"]);
                    client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
                    client.DefaultRequestHeaders.Add("User-Agent", "XboxServicesAPI/2021.10.20211005.0 c");
                    client.DefaultRequestHeaders.Add("Signature", "RGFtbklHb3R0YU1ha2VUaGlzU3RyaW5nU3VwZXJMb25nSHVoLkRvbnRFdmVuS25vd1doYXRTaG91bGRCZUhlcmVEcmFmZlN0cmluZw==");
                }

                string Url = QueryParameter[UrlProfile]["url"].Replace("#XUID#", Xuid).Replace("#SCID#", Scid);

                client.PostAsync(Url, Bodyconverted);
            }
            catch (HttpRequestException ex)
            {
                switch ((int)ex.StatusCode)
                {
                    case 401:
                        MessageBox.Show("Xauth is not correct. Click the Reload Xbox App button until the error goes away", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 404:
                        MessageBox.Show("Not Found!. How did you get here?", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 500:
                        MessageBox.Show("Error Server Xbox !Nothing to do!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("something did a fucky wucky and I dont have a specific message for the error code", "fucky wucky", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                throw;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error In RequestXbox", MessageBoxButtons.OK, MessageBoxIcon.Error); throw; }
        }
    }
}
