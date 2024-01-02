using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollecteDonnees
{
    internal class Webesponse
    {
       public String GetLine()
        {
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create("https://data.mobilites-m.fr/api/linesNear/json?x=5.73119705178461&y=45.184446886268645&dist=400&details=true");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            return responseFromServer;

        }
    }
}






   