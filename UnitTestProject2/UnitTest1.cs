using System;
using System.Web.Script.Serialization;
using Learn2Read;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var oxfor = new OxfordDictionaryRequests();
            var t = oxfor.GetJSONPronunsiation("candy");

            var objectr = JsonConvert.DeserializeObject<RootObject>(t);

            var s = objectr.results[0].id;
        }
    }
}
