using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class TestMethod
    {
        public void Test() { 
        Fakerequest fake = new Fakerequest();
            BusApi target = new BusApi(fake);
            string urlBus = "{\"id\":\"SEM:4602\",\"name\":\"Grenoble, Gustave Rivet\",\"lon\":5.72821,\"lat\":45.1822,\"zone\":\"SEM_GENGUSTRIVE\",\"lines\":[\"SEM:83\"]},{\"id\":\"SEM:4603\",\"name\":\"Grenoble, Gustave Rivet\",\"lon\":5.72795,\"lat\":45.18247,\"zone\":\"SEM_GENGUSTRIVE\",\"lines\":[\"SEM:83\"]},{\"id\":\"C38:12812\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73117,\"lat\":45.18551,\"zone\":\"C38_ST05406\",\"lines\":[\"C38:T83\",\"C38:T84\",\"C38:T86\",\"C38:X01\",\"C38:X02\"]},{\"id\":\"C38:12813\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73149,\"lat\":45.18534,\"zone\":\"C38_ST05406\",\"lines\":[\"C38:T83\",\"C38:T84\",\"C38:T86\",\"C38:X01\",\"C38:X02\"]}]";
            string json = DoRequest(urlBus);
            List<LineData> result = target.Getline();
            return result;
        }
    }
}
