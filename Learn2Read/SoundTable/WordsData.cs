using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learn2Read
{
    public static class WordsData
    {
        public static List<WordModel> GetIWordsModels()
        {
            var win = new WordModel();
            win.WordEnglish = "Win";
            win.Transcription = "[wɪn]";
            win.WordRussian = "победа";
            var listI = new List<WordModel>();
            listI.Add(win);
            /*
            listI.Add("Win [wɪn] победа");
            listI.Add("Big [bɪg] большой");
            listI.Add("Dig [dɪg] копать");
            listI.Add("Wig [wɪg] парик");
            listI.Add("Flip [flɪp] кувырок");
            listI.Add("Dip [dɪp] окунать");
            listI.Add("Pin [pɪn] булавка");
            listI.Add("Sick [sɪk] больной");
            listI.Add("Gift [gɪft] подарок");
            listI.Add("Six [sɪks] шесть");
            */
            return listI;
        }
    }
}