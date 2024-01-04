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
            BusApi response = new BusApi();
            List<LineData> bus = response.GetLine();
            foreach (LineData lignebus in bus)
            {
                Console.WriteLine($"linedata {lignebus.name} , {lignebus.zone} , {lignebus.lon},{lignebus.id} ,{lignebus.lines}");
            }

        }
    }
}
