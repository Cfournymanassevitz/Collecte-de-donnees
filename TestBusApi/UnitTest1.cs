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
        // important sert a crée un test 
        [TestMethod]

        public void TestMethod1()
        {
            //on instencie via l'interface le fakerequest puis on instancie la bonne class avec la methode
            IRequest request = new FakeRequest();
            BusApi fake = new BusApi(request);
            List<LineData> result = fake.GetLine();
            Assert.AreEqual("Grenoble, Champs-Elysées", result[0].name);
            Assert.AreEqual("SEM:0844", result[0].id);
            Assert.AreEqual("SEM:0844", result[0].id);

        }
        [TestMethod]
        //Test qui sera faux 
        public void TestMethodEchec()
        {
            IRequest request = new FakeRequest();
            BusApi fake = new BusApi(request);
            List<LineData> result2 = fake.GetLine();
            Assert.AreEqual("25", result2[0].id);
        }
    }
}
