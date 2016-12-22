using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learn2Read
{
    public class LexicalEntry
    {
        public string language { get; set; }
        public string lexicalCategory { get; set; }
        public List<Pronunciation> pronunciations { get; set; }
        public string text { get; set; }
    }
}