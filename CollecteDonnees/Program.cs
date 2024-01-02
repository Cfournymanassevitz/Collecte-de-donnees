using System;

https://www.newtonsoft.com/jsonschemausing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollecteDonnees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
SecurityProtocolType.Tls;
            Webesponse metroApi = new Webesponse();
            Console.WriteLine(GetLine());

        }
    }
}
