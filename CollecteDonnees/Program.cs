using System;
using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;
using ClassLibrary; 

namespace CollecteDonnees
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            RequestResponse response = new RequestResponse();
            List<LineData> bus = response.GetLine();
            foreach (LineData lignebus in bus)
            {
                Console.WriteLine($"linedata {lignebus.name} , {lignebus.zone} , {lignebus.lon},{lignebus.id} ,{lignebus.lines}");
            }




        }
    }
}
