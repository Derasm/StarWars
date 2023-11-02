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
        // this makes the request to the API and returns the Result portion of the response. 
        private async Task<JsonElement> Request(string url)
        {
            //for some reason it removes the "api" portion
            HttpResponseMessage response = await client.GetAsync("api/"+url);
            JsonElement resultsElement = default;

            // if the response is succesful, shave off the first portion of it (containing amount, next call and previous call. they are unneeded).
            if (response.IsSuccessStatusCode)
            {

                string jsonResponse = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                JsonDocument document = JsonDocument.Parse(jsonResponse);

                // Extract the 'results' array
                resultsElement = document.RootElement.GetProperty("results");
            }
            // this only happens if the call isn't succesful
            else
            {
                throw new Exception($"Something went wrong in fetching data from: {client.BaseAddress}");
            }
            return resultsElement;
        }


        // disposal of client to free resources.
        public void Dispose()
        {
            client.Dispose();
        }
        // This could easily become a oneliner, but that would sacrifice readability for 2 lines of code. Not worth it
        public List<Film> GetFilms()
        {
            JsonElement apiResult = Request("/films/").Result;
            List<Film> filmList = JsonSerializer.Deserialize<List<Film>>(apiResult)!;
            return filmList;
        }

        public Film GetFilm(string title)
        {
            JsonElement apiResult = Request($"/films/?search={title}").Result;
            string jsonElementType = apiResult.GetRawText();
            List<Film> films = JsonSerializer.Deserialize<List<Film>>(apiResult);
            return films.First();
        }

        public List<People> GetPeoples()
        {
            JsonElement apiResult = Request("/people/").Result;
            List<People> peopleList = JsonSerializer.Deserialize<List<People>>(apiResult)!;
            return peopleList;
        }
        public People GetPerson(string name)
        {
            JsonElement apiResult = Request($"/people/?search={name}").Result;
            List<People> peopleList = JsonSerializer.Deserialize<List<People>>(apiResult)!;
            return peopleList.First();
        }

        public List<Starship> GetStarships()
        {
            JsonElement apiResult = Request("/starships/").Result;
            List<Starship> starshipList = JsonSerializer.Deserialize<List<Starship>>(apiResult)!;
            return starshipList;
        }
        /// <summary>
        /// Get a starship by name or model, or both
        /// </summary>
        /// <param name="name"> string - case sensitive partial match</param>
        /// <param name="model"> string - case sensitive partial match</param>
        /// <returns></returns>
        public Starship GetStarship(string? name, string? model)
        {
            JsonElement apiResult = default;
            //only search on name
            if (model == null)
            {
                apiResult = Request($"/starships/?search={name}").Result;
            }
            //only search on model
            if (name == null)
            {
                apiResult = Request($"/starships/?search={model}").Result;
            }
            //if neither are null
            if (name != null && model != null)
            {
                apiResult = Request($"/starships/?search={name} {model}").Result;
            }
            List<Starship> starshipList = JsonSerializer.Deserialize<List<Starship>>(apiResult)!;
            return starshipList.First();
        }

        public List<Planet> GetPlanets()
        {
            JsonElement apiResult = Request("/planets/").Result;
            List<Planet> planetList = JsonSerializer.Deserialize<List<Planet>>(apiResult)!;
            return planetList;
        }

        public Planet GetPlanet(string name)
        {
            JsonElement apiResult = Request($"/planets/?search={name}").Result;
            List<Planet> planetList = JsonSerializer.Deserialize<List<Planet>>(apiResult)!;
            return planetList.First();
        }

        public List<Species> GetSpecies()
        {
            JsonElement apiResult = Request("/species/").Result;
            List<Species> speciesList = JsonSerializer.Deserialize<List<Species>>(apiResult)!;
            return speciesList;
        }

        public Species GetSpecies(string name)
        {
            JsonElement apiResult = Request($"/species/?search={name}").Result;
            List<Species>speciesList = JsonSerializer.Deserialize<List<Species>>(apiResult)!;
            return speciesList.First();
        }

        public List<Vehicle> GetVehicles()
        {
            JsonElement apiResult = Request("/vehicles/").Result;
            List<Vehicle> vehicleList = JsonSerializer.Deserialize<List<Vehicle>>(apiResult)!;
            return vehicleList;
        }

        public Vehicle GetVehicle(string name, string model)
        {
            JsonElement apiResult = default;
            //only search on name
            if (model == null)
            {
                apiResult = Request($"/vehicles/?search={name}").Result;
            }
            //only search on model
            if (name == null)
            {
                apiResult = Request($"/vehicles/?search={model}").Result;
            }
            //if neither are null
            if (name != null && model != null)
            {
                apiResult = Request($"/vehicles/?search={name} {model}").Result;
            }
            List<Vehicle> vehicleList = JsonSerializer.Deserialize<List<Vehicle>>(apiResult)!;
            return vehicleList.First();
        }
    }
}
