using ClassLibraryUnit;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestexample
{
    [TestClass]
    public class UnitTestexample
    {
        [TestMethod]
        public void Calcolo1Test()
        {
            bool resp =ClassExample.Calcolo1();
            Assert.AreEqual(true, resp);
        }
    }
}
