using System;
using System.Net;

namespace CollecteDonnees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            Webesponse metroApi = new Webesponse();
            Console.WriteLine(metroApi.GetLine());
        }
    }
}
