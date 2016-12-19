using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Learn2Read
{
    public class OxfordDictionaryRequests
    {
        public void GetTranscription(string word)
        {
            string url = $"https://od-api.oxforddictionaries.com:443/api/v1/entries/en/{word}/pronunciations";

            using (var webClient = new WebClient())
            {
                webClient.QueryString.Add("Accept", "application/json");
                webClient.QueryString.Add("app_id", "b9995a56");
                webClient.QueryString.Add("app_key", "113e76a6337da3ba5897246665ecae67");
                var response = webClient.DownloadString(url);
                JObject json = JObject.Parse(response);
                
            }
        }

        
    }
}