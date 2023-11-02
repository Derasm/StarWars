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
        List<Planet> planets = null;
        public string initialFilm = "new hope";
        private readonly ILogger<IndexModel> _logger;
        // this should in theory be the constructor for the page.
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            List<Film> films = api.GetFilms();
            Console.WriteLine(films);

        }
        //This is called on page load.
        public void OnGet()
        {

        }
        public void TestMethod()
        {
            initialFilm = "test - after method call";
        }
        public List<Film> GetFilms()
        {
            return api.GetFilms();
        }
        public List<Planet> GetPlanets()
        {
            return api.GetPlanets();
        }

    }
}