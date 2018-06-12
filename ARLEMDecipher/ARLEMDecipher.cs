using ARLEMDecipher.Models.Activities;
using ARLEMDecipher.Models.Workplaces;
using ARLEMDecipher.Models.Workplaces.Sensors;
using ARLEMDecipher.Utilities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher
{
    public class ARLEMDecipher
    {
        
        string ServerUrl;
        RESTManager ApiManager;
        Workplace Workplace;
        Activity Activity;

        public ARLEMDecipher(string url)
        {
            ServerUrl = url;
            ApiManager = new RESTManager("http://127.0.0.1:8080/");
        }

        public void LoadWorkplace(int id)
        {
            Workplace = ApiManager.GET<Workplace>("workplace/json/" + id.ToString());           
        }

        public void LoadActivity(int id)
        {
            Activity = ApiManager.GET<Activity>("activity/json/" + id.ToString());
        }

        public int[] AvailableActivites()
        {
            List<int> Ids = new List<int>();
            Workplace.Activities.ForEach(x => Ids.Add(x.InertnalID));
            return Ids.ToArray();
        }

        public List<VirtualSensor> RequiredSensor()
        {
            List<VirtualSensor> VirtualSensors = new List<VirtualSensor>();

            Activity.Actions.ForEach(action =>
            {
                action.Triggers.ForEach(trigger =>
                {
                    trigger.Operations.ForEach(operation =>
                    {
                        if(operation.Sensor != null)
                        {
                            VirtualSensors.Add(operation.Sensor);
                        }
                    });
                });
            });

            return VirtualSensors;
        }

        public List<string> RequiredModules()
        {
            return new List<string>(new string[]{ "HAR", "HGR"});
        }
    }
}
