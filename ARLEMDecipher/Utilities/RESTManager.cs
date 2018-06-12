using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ARLEMDecipher.Models.Workplaces;
using Newtonsoft.Json;

namespace ARLEMDecipher.Utilities
{
    class RESTManager
    {
        RestClient Client;
        string ServerURL;
        public RESTManager(string url)
        {
            ServerURL = url;
            Client = new RestClient(ServerURL);                    
        }

        public T GET<T>(string path)
        {
            var Request = new RestRequest(path, Method.GET);
            IRestResponse response = Client.Execute(Request);
            var Item  = JsonConvert.DeserializeObject<T>(response.Content);
            return Item;
        }


    }
}
