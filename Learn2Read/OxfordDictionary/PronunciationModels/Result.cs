using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learn2Read
{
    public class Result
    {
        public string id { get; set; }
        public string language { get; set; }
        public List<LexicalEntry> lexicalEntries { get; set; }
        public string type { get; set; }
        public string word { get; set; }
    }
}