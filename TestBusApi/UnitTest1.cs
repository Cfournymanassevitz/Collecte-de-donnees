using CollecteDonnees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestProject;

namespace TestBusApi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IRequest request = new FakeRequest();
            BusApi fake = new BusApi(request);
            List<LineData> result = fake.GetLine();
            Assert.AreEqual("Grenoble, Champs-Elysées", result[0].name);
            Assert.AreEqual("SEM:0844", result[0].id);
            Assert.AreEqual("SEM:0844", result[0].id);

        }
        [TestMethod]
        public void TestMethod2()
        {
            IRequest request = new FakeRequest();
            BusApi fake = new BusApi(request);
            List<LineData> result2 = fake.GetLine();
            Assert.AreEqual("25", result2[0].id);
        }
    }
}
