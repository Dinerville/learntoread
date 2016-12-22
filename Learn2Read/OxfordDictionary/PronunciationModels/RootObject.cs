using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learn2Read
{
    public class RootObject
    {
        public Metadata metadata { get; set; }
        public List<Result> results { get; set; }
    }
}