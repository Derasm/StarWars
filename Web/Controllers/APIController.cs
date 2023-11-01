using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Net;
using System.Text.Json;
using System.Xml.Linq;
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
        //initialization of Client here instead of on general object
        static APIController()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://swapi.dev/api")
            };
        }

        private async Task<string> Request(string url)
        {
            string result = "";
            string requestURl = client.BaseAddress.ToString();
            HttpResponseMessage response = await client.GetAsync("api"+url);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }
            // this only happens if the call isn't succesful
            else
            {
                throw new Exception($"Something went wrong in fetching data from: {client.BaseAddress}");
            }
            return result;
        }


        // disposal of client to free resources.
        public void Dispose()
        {
            client.Dispose();
        }
        // This could easily become a oneliner, but that would sacrifice readability for 2 lines of code. Not worth it
        public List<Film> GetFilms()
        {
            string apiResult = Request("/films/").Result;
            List<Film> filmList = JsonSerializer.Deserialize<List<Film>>(apiResult)!;
            return filmList;
        }

        public Film GetFilm(string title)
        {
            string apiResult = Request($"/films/?{title}?").Result;
            Film filmList = JsonSerializer.Deserialize<Film>(apiResult)!;
            return filmList;
        }

        public List<People> GetPeoples()
        {
            string apiResult = Request("/people/").Result;
            List<People> peopleList = JsonSerializer.Deserialize<List<People>>(apiResult)!;
            return peopleList;
        }
        public People GetPeople(string name)
        {
            string apiResult = Request($"/people/?{name}?").Result;
            People peopleList = JsonSerializer.Deserialize<People>(apiResult)!;
            return peopleList;
        }

        public List<Starship> GetStarships()
        {
            string apiResult = Request("/starships/").Result;
            List<Starship> starshipList = JsonSerializer.Deserialize<List<Starship>>(apiResult)!;
            return starshipList;
        }
        /// <summary>
        /// Get a starship by name or model, or both
        /// </summary>
        /// <param name="name"> string - case sensitive partial match</param>
        /// <param name="model"> string - case sensitive partial match</param>
        /// <returns></returns>
        public Starship GetStarship(string name, string model)
        {
            string apiResult = "";
            //only search on name
            if (model == null)
            {
                apiResult = Request($"/starships/?{name}?").Result;
            }
            //only search on model
            if (name == null)
            {
                apiResult = Request($"/starships/?{model}?").Result;
            }
            //if neither are null
            if (name != null && model != null)
            {
                apiResult = Request($"/starships/?{name}?/?{model}?").Result;
            }
            Starship starshipList = JsonSerializer.Deserialize<Starship>(apiResult)!;
            return starshipList;
        }

        public List<Planet> GetPlanets()
        {
            string apiResult = Request("/planets/").Result;
            List<Planet> planetList = JsonSerializer.Deserialize<List<Planet>>(apiResult)!;
            return planetList;
        }

        public Planet GetPlanet(string name)
        {
            string apiResult = Request($"/planets/?{name}?").Result;
            Planet planetList = JsonSerializer.Deserialize<Planet>(apiResult)!;
            return planetList;
        }

        public List<Species> GetSpecies()
        {
            string apiResult = Request("/species/").Result;
            List<Species> speciesList = JsonSerializer.Deserialize<List<Species>>(apiResult)!;
            return speciesList;
        }

        public Species GetSpecies(string name)
        {
            string apiResult = Request($"/species/?{name}?").Result;
            Species speciesList = JsonSerializer.Deserialize<Species>(apiResult)!;
            return speciesList;
        }

        public List<Vehicle> GetVehicles()
        {
            string apiResult = Request("/vehicles/").Result;
            List<Vehicle> vehicleList = JsonSerializer.Deserialize<List<Vehicle>>(apiResult)!;
            return vehicleList;
        }

        public Vehicle GetVehicle(string name, string model)
        {
            string apiResult = "";
            //only search on name
            if (model == null)
            {
                apiResult = Request($"/vehicles/?{name}?").Result;
            }
            //only search on model
            if (name == null)
            {
                apiResult = Request($"/vehicles/?{model}?").Result;
            }
            //if neither are null
            if (name != null && model != null)
            {
                apiResult = Request($"/vehicles/?{name}?/?{model}?").Result;
            }
            Vehicle vehicleList = JsonSerializer.Deserialize<Vehicle>(apiResult)!;
            return vehicleList;
        }
    }
}
