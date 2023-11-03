using ConsoleVersion.Models;

namespace ConsoleVersion.Controllers
{
    /// <summary>
    /// This class handles the output to the console.
    /// </summary>
    internal class ConsoleOutputHandler
    {
        //api for the star wars data
        APIController APIController = new APIController();
        // startscreen has the massive logo and the welcome.
        public void StartScreen()
        {
            Console.WriteLine("    .                          .                              .\r\n .             o88888888888888  d88b  .  8888888b.  .                   .\r\n       .  .    Y88<\"\"\"\"888\"\"\"\" j8PY8i    888   )88               .\r\n                Y8b.   888    ,8P  Y8,   88888888'         .\r\n_________________>88b  888    88888888   888  Y8b___________________________\r\n:::::::::88888888888P  888   d8P    Y8b  888   Y888888::::::::::::::::::::::\r\n:::::::::(                                           )::::::::::::::::::::::\r\n:::::::::Y8b  d88b  d8P  d88b   . 8888888b.  o88888888::::::::::::::::::::::\r\n\"\"\"\"\"\"\"\"\"\"88ij8888ij88' j8PY8i    888   )88  Y88<\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\r\n          \"8888PY8888' ,8P  Y8,   88888888'   Y8b.   .          .\r\n    .      Y88P  Y88P  88888888   888  Y8b_____>88b           .           LS\r\n  .      .  Y8'  \"8P  d8P    Y8b  888   Y888888888P                       .\r\n\r\n------------------------------------------------\r\nThank you for visiting https://asciiart.website/\r\nThis ASCII pic can be found at\r\nhttps://www.asciiart.website/index.php?art=movies/star%20wars\r\n");
            Console.WriteLine("Welcome to the Star Wars Console Wiki - you now have the following options. type 'exit' to close this terminal");
            OptionsScreen();
        }
        // Optionsscreen - used to display the options to the user and as a "return here" kinda deal. Doesn't have logi.
        public void OptionsScreen()
        {
            Console.WriteLine("Type the number you would like to access.");
            Console.WriteLine("1. films");
            Console.WriteLine("2. people");
            Console.WriteLine("3. planets");
            Console.WriteLine("4. species");
            Console.WriteLine("5. starships");
            Console.WriteLine("6. vehicles");
        }
        // to avoid writing Console.WriteLine("Loading...") a bunch of times.
        public void Loading()
        {
            Console.WriteLine("Loading...");
        }
        public void DisplayFilms()
        {
            Loading();
            List<Film> filmList = APIController.GetFilms();
            foreach (Film film in filmList)
            {
                Console.WriteLine($"{film.EpisodeId} - {film.Title}");
            }
            Console.WriteLine("\n do you want information about one of the specific films or to return to the startscreen?");
            Console.WriteLine("\n To return to the startscreen, type 'start'. To find information about an individual film, type the title without spaces.");
            string userInput = Console.ReadLine();
            if (userInput == "start")
            {
                return;
            }
            else
            {
                DisplayIndividualFilm(userInput);
            }
        } 
        /// <summary>
        /// this is called after DisplayFilms with a number - that number is used to get the film from the list and display it.
        /// </summary>
        public void DisplayIndividualFilm(string input)
        {
            Loading();
            Film film = APIController.GetFilm(input);
            Console.WriteLine($"Title: {film.Title}");
            Console.WriteLine($"Released: { film.Created}");
            Console.WriteLine($"Director: {film.Director}");
            Console.WriteLine("\n Would you like to return to the startscreen? ");
            Console.WriteLine("You now have the following options: Type 'start' to return. Type 'exit' to exit. Type 'films' to see the list of films again");
            string userInput = Console.ReadLine();
            if (userInput == "start")
            {
                StartScreen();
            }
            if (userInput == "films")
            {
                DisplayFilms();
            }
            else if (userInput == "exit")
            {
                Environment.Exit(0);
            }

        }
        public void DisplayPeople()
        {
            Loading();

            List<People> peopleList = APIController.GetPeople();
            Console.WriteLine("There are a ton of people in Star Wars - do you want all or just the first 10? - type 'all' for all.");
            string userInput = Console.ReadLine();
            if (userInput == "all")
            {
                for (int i = 0; i < peopleList.Count; i++)
                {
                    Console.WriteLine($"{i} - " + peopleList[i].Name);

                }
                foreach (People person in peopleList)
                {
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i} -" + peopleList[i].Name);
                }
            }
            Console.WriteLine("\n do you want information about one of the specific individuals or to return to the startscreen?");
            Console.WriteLine("\n To return to the startscreen, type 'start'. To find information about an individual person, type their name.");
            userInput = Console.ReadLine();
            if (userInput == "start")
            {
                return;
            }
            else
            {
                DisplayIndividualPerson(userInput);
            }

        }
        public void DisplayIndividualPerson(string name)
        {
            Loading();
            People person = APIController.GetPerson(name);
            
            Console.WriteLine("\n" +person.Name);
            Console.WriteLine(person.Gender);
            Console.WriteLine(person.BirthYear);
            Console.WriteLine("\n do you want information about one of the specific individuals or to return to the startscreen?");
            Console.WriteLine("\n To return to the startscreen, type 'start'. To return to the list of people, type 'people'. To search for a different person, type their name");
            string userInput = Console.ReadLine();
            if (userInput == "start")
            {
                return;
            }
            else if (userInput == "people")
            {
                DisplayPeople();
            }
            else
            {
                DisplayIndividualPerson(userInput);
            }
        }
        public void DisplayPlanets()
        {
            Loading();

            List<Planet> planetList = APIController.GetPlanets();
            foreach (Planet planet in planetList)
            {
                Console.WriteLine(planet.Name);
            }
        }
        public void DisplaySpecies()
        {
            Loading();

            List<Species> speciesList = APIController.GetSpecies();
            foreach (Species species in speciesList)
            {
                Console.WriteLine(species.Name);
            }
        }
        public void DisplayStarships()
        {
            Loading();

            List<Starship> starshipList = APIController.GetStarships();
            foreach (Starship starship in starshipList)
            {
                Console.WriteLine(starship.Name);
            }
        }
        public void DisplayVehicles()
        {
            Loading();

            List<Vehicle> vehicleList = APIController.GetVehicles();
            foreach (Vehicle vehicle in vehicleList)
            {
                Console.WriteLine(vehicle.Name);
            }
        }
    }
}
