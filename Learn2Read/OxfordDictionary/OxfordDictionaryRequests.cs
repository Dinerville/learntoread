﻿using System;
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
        public string GetJSONPronunsiation(string word)
        {
            string site = $"https://od-api.oxforddictionaries.com:443/api/v1/entries/en/{word}/pronunciations";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(site);

            request.Method = "GET";
            request.Accept = "application/json";
            request.Headers.Add("app_id:b9995a56");
            request.Headers.Add("app_key:113e76a6337da3ba5897246665ecae67");


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            StringBuilder output = new StringBuilder();
            var outp = output.Append(reader.ReadToEnd());

            response.Close();
            return $"{outp}";

        }

        public RootObject Parser(string word)
        {
            var oxforPronunciation = new OxfordDictionaryRequests();
            try
            {
                var t = oxforPronunciation.GetJSONPronunsiation(word);


                var objectr = JsonConvert.DeserializeObject<RootObject>(t);

                return objectr;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<RootObject> ParseArrayOfWords(List<string> words)
        {
            var list = new List<RootObject>();
            for (int i = 0; i < words.Count; i++)
            {
                list.Add(Parser(words[i]));
            }
            return list;
        }


    }
}