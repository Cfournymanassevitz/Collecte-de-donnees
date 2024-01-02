using System;
using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;

namespace CollecteDonnees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            List<LineData> busTramEtc = new List<LineData>();
            Webesponse metroApi = new Webesponse();
           List<LineData> bus = metroApi.GetLine();

            foreach ( LineData lignebus in bus)
            {
                Console.WriteLine($"linedata {lignebus.name} , {lignebus.zone} , {lignebus.lon},{lignebus.id} ,{lignebus.lines}" );
            }
         
        }
    }
}
