using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CollecteDonnees;
using Newtonsoft.Json;

namespace ClassLibrary
{
    public class RequestResponse
    {

        public string DoRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            return responseFromServer;
        }
        public List<LineData> GetLine()
        {
            string urlBus = "https://data.mobilites-m.fr/api/linesNear/json?x=5.73119705178461&y=45.184446886268645&dist=400&details=true";
            string json = DoRequest(urlBus);
            List<LineData> line = JsonConvert.DeserializeObject<List<LineData>>(json);
            return line;

        }

    }
}