using Web.Models;

namespace Web.Interfaces
{/// <summary>
/// Methods for querying the api for the six different endpoints with types for easy remembering
/// </summary>
    public interface ISwapiAPI
    {
        List<Film> GetFilms();
        Film GetFilm(string title);
        List<People> GetPeoples();
        People GetPeople(string name);
        List<Starship> GetStarships();
        Starship GetStarship(string name, string model);
        List<Planet> GetPlanets();
        Planet GetPlanet(string name);
        List<Species> GetSpecies();
        Species GetSpecies(string name);
        List<Vehicle> GetVehicles();
        Vehicle GetVehicle(string name, string model);
    }
}
