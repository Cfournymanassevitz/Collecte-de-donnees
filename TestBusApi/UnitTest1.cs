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

        }
    }
}
