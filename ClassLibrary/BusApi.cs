using ClassLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestProject;


namespace CollecteDonnees
{

    

    public class BusApi
    {
        private IRequest _request {  get; set; }

        public BusApi() : this(new Request())
        {
        }

        public BusApi(IRequest request)
        {
            _request = request;
        }

        public List<LineData> GetLine()
        {
            string urlBus = "https://data.mobilites-m.fr/api/linesNear/json?x=5.73119705178461&y=45.184446886268645&dist=400&details=true";
            string json = _request.DoRequest(urlBus);
            List<LineData> line = JsonConvert.DeserializeObject<List<LineData>>(json);
            return line;

        }

    }
}
