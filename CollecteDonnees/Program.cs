using System;
using System.Collections.Generic;
using System.Net;
using System.Xml.Linq; 

namespace CollecteDonnees
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            BusApi response = new BusApi(5.73119705178461, 45.184446886268645, 400);
            List<LineData> bus = response.GetLine();
            foreach (LineData lignebus in bus)
            {
                Console.WriteLine($"{lignebus.Name} , {lignebus.Latitude} , {lignebus.Longitude},{lignebus.Id} ,{lignebus.Lines}");
            }

        }
    }
}
