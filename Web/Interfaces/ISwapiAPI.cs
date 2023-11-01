using Web.Models;

namespace Web.Interfaces
{/// <summary>
/// Methods for querying the api for the six different endpoints with types for easy remembering
/// </summary>
    public interface ISwapiAPI
    {
        Task<List<Film>> GetFilms(string title);
        Task<List<People>> GetPeople(string name);
        Task<List<Starship>> GetStarship(string name, string model);
        Task<List<Planet>> GetPlanet(string name);
        Task<List<Species>> GetSpecies(string name);
        Task<List<Vehicle>> GetVehicle(string name, string model);
    }
}
