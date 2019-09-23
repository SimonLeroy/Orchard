using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Orchard.ProviderRaven;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       

        [TestMethod]
        public void TestMethod1()
        {
            var p = new RavenProvider();
            var t = p.GetRavensPath();
            Assert.AreEqual(8, t.Count);
            //var p = new RavenProvider();
            //var t = Mock.Of<RavenProvider>();
            //var i = new List<int>();
            //Mock.Get(t).SetupSequence(x => x.GetRavensPath()).Returns(i);

           
        }
    }
}
