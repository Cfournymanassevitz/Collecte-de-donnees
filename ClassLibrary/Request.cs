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
using TestProject;


namespace ClassLibrary
{
    public class Request : IRequest

    {

        public string DoRequest(string url)
        {
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            // Crée une requête pour une URL
            WebRequest request = WebRequest.Create(url);
            // Si requis par le serveur, initialise les informations d'identification
            request.Credentials = CredentialCache.DefaultCredentials;

            // Réponse http
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Récupère le flux ontenant le contenu renvoyé par le serveur
            Stream dataStream = response.GetResponseStream();

            // Ouvre le flux à l'aide de StreamReader pour un accès facile
            StreamReader reader = new StreamReader(dataStream);

            // Lit le contenu 
            string result = reader.ReadToEnd();
            return result;
        }
      
    }
    
}