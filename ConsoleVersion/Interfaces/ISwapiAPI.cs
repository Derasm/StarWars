using ConsoleVersion.Models;

namespace ConsoleVersion.Interfaces
{/// <summary>
/// Methods for querying the api for the six different endpoints with types for easy remembering
/// </summary>
    public interface ISwapiAPI
    {
        List<Film> GetFilms();
        Film GetFilm(string title);
        List<People> GetPeople();
        People GetPerson(string name);
        List<Starship> GetStarships();
        Starship GetStarship(string name, string model);
        List<Planet> GetPlanets();
        Planet GetPlanet(string name);
        List<Species> GetSpecies();
        List<Species> GetSpecies(string name);
        List<Vehicle> GetVehicles();
        List<Vehicle> GetVehicle(string name, string model);
    }
}
