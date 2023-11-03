using ConsoleVersion.Controllers;
using ConsoleVersion.Models;

namespace Test_Suite
{
    /// <summary>
    /// Technically this would be better to use a fake / mock API result instead,
    /// however given i have 10.000 daily calls on the API, it should be good.
    /// </summary>
    public class APIControllerTest
    {
        //test the individual functions in the controller
        [Test]
        public void GetFilms()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            List<Film> filmList = controller.GetFilms();
            //Assert
            Assert.IsNotNull(filmList);
        }
        [Test]
        public void GetFilm()
        {
            //Arrange
            APIController controller = new APIController();
            //Act - this gets the first film in the list, which is a new hope, and gets it in an async task
            Film filmList = controller.GetFilm("new");
            //Assert
            Assert.IsNotNull(filmList);
        }
        [Test]
        public void GetPeople()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            List<People> personList = controller.GetPeople();
            //Assert
            Assert.IsNotNull(personList);
        }
        [Test]
        public void GetPerson()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            People personList = controller.GetPerson("luke");
            //Assert
            Assert.IsNotNull(personList);
        }
        [Test]
        public void GetStarships()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            List<Starship> starshipList = controller.GetStarships();
            //Assert
            Assert.IsNotNull(starshipList);
        }
        [Test]
        public void GetStarshipWithName()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            Starship starshipList = controller.GetStarship("x-wing", null);
            //Assert
            Assert.IsNotNull(starshipList);
        }
        [Test]
        public void GetStarshipWithModel()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            Starship starshipList = controller.GetStarship(null, "x-wing");
            //Assert
            Assert.IsNotNull(starshipList);
        }
        [Test]
        public void GetStarshipWithNameAndModel()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            Starship starshipList = controller.GetStarship("x-wing", "x-wing");
            //Assert
            Assert.IsNotNull(starshipList);
        }
        [Test]
        public void GetPlanets()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            List<Planet> planetList = controller.GetPlanets();
            //Assert
            Assert.IsNotNull(planetList);
        }
        [Test]
        public void GetPlanet()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            Planet planetList = controller.GetPlanet("tatooine");
            //Assert
            Assert.IsNotNull(planetList);
        }
        [Test]
        public void GetSpecies()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            List<Species> speciesList = controller.GetSpecies();
            //Assert
            Assert.IsNotNull(speciesList);
        }
        [Test]
        public void GetSpeciesWithName()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            List<Species> speciesList = controller.GetSpecies("human");
            //Assert
            Assert.IsNotNull(speciesList);
        }
        [Test]
        public void GetVehicles()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            List<Vehicle> vehicleList = controller.GetVehicles();
            //Assert
            Assert.IsNotNull(vehicleList);
        }
        [Test]
        public void GetVehicleWithName()
        {
            //Arrange
            APIController controller = new APIController();
            //Act
            List<Vehicle> vehicleList = controller.GetVehicle("x-wing", null);
            //Assert
            Assert.IsNotNull(vehicleList);
        }
    }
}