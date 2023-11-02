using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Controllers;
using Web.Models;

namespace Web.Pages
{
    // In theory, this should run on the first page - index. So anything put here should run on startup.
    public class IndexModel : PageModel
    {
        // API reference. 
        APIController api = new APIController();
        public List<Film> films = null;
        public List<Planet> planets = null;
        public List<Vehicle> vehicles = null;
        public List<People> peoples = null;
        public List<Species> species = null;
        public List<Starship> starships = null;


        private readonly ILogger<IndexModel> _logger;
        // this should in theory be the constructor for the page.
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            List<Film> films = api.GetFilms();
            Console.WriteLine(films);

        }
        /// <summary>
        /// Called on pageload
        /// This is going to be ugly, and is basically me being angry at Razorpages and binding methods to html.
        /// </summary>
        public void OnGet()
        {
            //get films, planets, vehicles, species, starships, peoples.
            films = GetFilms();
            planets = GetPlanets();
            vehicles = GetVehicles();
            peoples = GetPeoples();
            species = GetSpecies();
            starships = GetStarships();

        }

        private List<Film> GetFilms()
        {
            return api.GetFilms();
        }
        private List<Planet> GetPlanets()
        {
            return api.GetPlanets();
        }
        private List<Vehicle> GetVehicles() {
            return api.GetVehicles();
        }
        private List<People> GetPeoples()
        {
            return api.GetPeoples();
        }
        private List<Species> GetSpecies()
        {
            return api.GetSpecies();
        }
        private List<Starship> GetStarships()
        {
            return api.GetStarships();
        }

    }
}