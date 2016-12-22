using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learn2Read
{
    public class Pronunciation
    {
        public string audioFile { get; set; }
        public List<string> dialects { get; set; }
        public string phoneticNotation { get; set; }
        public string phoneticSpelling { get; set; }
    }
}