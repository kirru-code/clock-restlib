using System;
using System.Collections.Generic;
using System.Text;
using Rest_Service_1_1;
using RestSharp;
using Newtonsoft.Json;
using CLock.RestLib;

namespace Rest_Service_1_1
{
    public class RestCall
    {
        /// <summary>
        /// Obtain the door list
        /// </summary>
        /// <returns></returns>
        public List<Door> GetDoorList()
        {
            RestClient clientToCall =
                    new RestClient("https://clockdbapi.azurewebsites.net/api/Door");

            RestRequest requestToCall =
                new RestRequest("", Method.GET);

            IRestResponse responseToCall =
                clientToCall.Execute(requestToCall);

            return
                JsonConvert.DeserializeObject<List<Door>>(responseToCall.Content);
        }

        /// <summary>
        /// Initiate a call to open a door
        /// </summary>
        /// <param name="doorToChange"></param>
        public void OpenDoor(string doorToChange)
        {
            RestClient clientToCall =
                new RestClient("https://clockdbapi.azurewebsites.net/api/Door");

            IRestRequest requestToCall =
                new RestRequest("/OpenDoor/", Method.POST)
                { RequestFormat = DataFormat.Json }
                .AddJsonBody(doorToChange);

            clientToCall
                .Execute(requestToCall);
        }

        /// <summary>
        /// Initiate a call to close a door
        /// </summary>
        /// <param name="doorToChange"></param>
        public void CloseDoor(string doorToChange)
        {
            RestClient clientToCall =
                new RestClient("https://clockdbapi.azurewebsites.net/api/Door");

            IRestRequest requestToCall =
                new RestRequest("/CloseDoor/", Method.POST)
                { RequestFormat = DataFormat.Json }
                .AddJsonBody(doorToChange);

            clientToCall
                .Execute(requestToCall);
        }

        /// <summary>
        /// Initiate a call to add a door
        /// </summary>
        /// <param name="doorToChange"></param>
        /// <param name="doorValues"></param>
        public void AddDoor(string doorToChange, Door doorValues)
        {
            RestClient clientToCall =
                new RestClient("https://clockdbapi.azurewebsites.net/api/Door");

            IRestRequest requestToCall =
                new RestRequest("/" + doorToChange, Method.POST)
                { RequestFormat = DataFormat.Json }
                .AddJsonBody(doorToChange);
            //Which values to include?

            clientToCall
                .Execute(requestToCall);
        }

        /// <summary>
        /// Initiate a call to delete a door
        /// </summary>
        /// <param name="doorToChange"></param>
        public void DeleteDoor(string doorToChange)
        {
            RestClient clientToCall =
                new RestClient("https://clockdbapi.azurewebsites.net/api/Door");

            IRestRequest requestToCall =
                new RestRequest("/" + doorToChange, Method.POST)
                { RequestFormat = DataFormat.Json }
                .AddJsonBody(doorToChange);
            //.AddJsonBody obsolete?

            clientToCall
                .Execute(requestToCall);
        }
    }
}
