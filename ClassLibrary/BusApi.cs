using ClassLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TestProject;


namespace CollecteDonnees
{



    public class BusApi
    {
        private IRequest Request;
        private double Latitude { get; set; } 
        private double Longitude { get; set; }
        private int Rayon {  get; set; }

        public BusApi(IRequest request)
        {  
            Request = request;
        }
  
        public BusApi(double x , double y ,int  rayon)
        {
            Latitude = x;
            Longitude = y;
            Rayon = rayon;
            Request = new Request();
        }


        public List<LineData> GetLine()
        {
            String urlBus =($"http://data.mobilites-m.fr/api/linesNear/json?x={Latitude.ToString(CultureInfo.InvariantCulture)}&y={Longitude.ToString(CultureInfo.InvariantCulture)}&dist={Rayon}&details=true");
            string json = Request.DoRequest(urlBus);
            Console.WriteLine(json);
            List<LineData> line = JsonConvert.DeserializeObject<List<LineData>>(json);
            return line;

        }

    }
}
