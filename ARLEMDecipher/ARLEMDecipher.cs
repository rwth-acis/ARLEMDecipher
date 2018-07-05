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
        public Workplace Workplace;
        Activity Activity;

        public ARLEMDecipher(string url)
        {
            ServerUrl = url;
            ApiManager = new RESTManager("http://127.0.0.1:8080/");
        }

        public bool LoadWorkplace(int id)
        {
            Workplace = ApiManager.GET<Workplace>("workplace/json/" + id.ToString()); 
            if(Workplace == null)
            {
                Console.WriteLine("Workplace not found");
                return false;
            }
            return true;
        }

        public void LoadActivity(int id)
        {
            Activity = ApiManager.GET<Activity>("activity/json/" + id.ToString());
        }

        public int[] AvailableActivites()
        {
            List<int> Ids = new List<int>();
            Workplace.Activities.ForEach(x => Ids.Add(x.InertnalID));
            if(Ids.Count == 0)
            {
                Console.WriteLine("No activites found");
            }
            return Ids.ToArray();
        }

        public List<string> AvailableSensors()
        {
            List<string> Sensors = new List<string>(); 
            Workplace.Sensors.ForEach(sensor =>
            {
                Sensors.Add(sensor.URI);
            });
            return Sensors;
        }

        public List<string> RequiredModules()
        {
            List<string> Modules = new List<string>();

            Activity.Actions.ForEach(action =>
            {
                action.Triggers.ForEach(trigger =>
                {
                    if(trigger.Mode.Name == "detect" && trigger.Type != "")
                    {
                        Modules.Add(trigger.Type);
                    }
                });
            });

            return Modules;
        }
    }
}
