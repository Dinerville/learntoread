using Learn2Read;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetho()
        {
            var z = 0;
            var oxford = new OxfordDictionaryRequests();
            var s = oxford.GetTranscription("hello");
        }
    }
}
