using System.Net;
using Web.Interfaces;
using Web.Models;

namespace Web.Controllers
{
    /// <summary>
    /// Controller for API consumption of SWAPI.dev - has get and post functionality. Only Get is to be fleshed out.
    /// </summary>
    public class APIController : ISwapiAPI
    {
        //Client for HTTP requests
        private static readonly HttpClient client;
        private enum HttpMethod
        {
            GET,
            POST
        }
        //initialization of Client here instead of on general object
        static APIController()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("http://swapi.dev/api")
            };
        }

        private async Task<string> Request (string url)
        {
            string result = null;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }
            // this only happens if the call isn't succesful
            else
            {
                result = response.StatusCode.ToString();
            }
            return result;
        }

        public Task<List<Film>> GetFilms(string title)
        {
            throw new NotImplementedException();
        }

        public Task<List<People>> GetPeople(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Starship>> GetStarship(string name, string model)
        {
            throw new NotImplementedException();
        }

        public Task<List<Planet>> GetPlanet(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Species>> GetSpecies(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vehicle>> GetVehicle(string name, string model)
        {
            throw new NotImplementedException();
        }
        // disposal of client to free resources.
        public void Dispose()
        {
            client.Dispose();
        }
    }
}
