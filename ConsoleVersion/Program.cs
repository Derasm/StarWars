using ConsoleVersion.Controllers;
using ConsoleVersion.Enums;
// This is going to be a simple console app that renders information depending on the searched API from the backend. 
class Program
{

    static void Main()
    {
        ConsoleInputHandler inputHandler = new ConsoleInputHandler();
        ConsoleOutputHandler outputHandler = new ConsoleOutputHandler();
        Boolean flag = true;
        outputHandler.StartScreen();
        while (flag == true)
        {
            // get input from the user
            string userInput = inputHandler.GetUserInput();
            //handle the input from the user
            OptionEnum userOption = inputHandler.UserOptions(userInput);

            // handle the user options - breaking up the flow for now
            HandleOptions(userOption);
        }
    }
    static void HandleOptions(OptionEnum userOption)
    {
        ConsoleOutputHandler outputHandler = new ConsoleOutputHandler();
        switch (userOption)
        {
            case OptionEnum.Films:
                outputHandler.DisplayFilms();
                break;
            case OptionEnum.People:
                outputHandler.DisplayPeople();

                break;
            case OptionEnum.Planets:
                outputHandler.DisplayPlanets();
                break;
            case OptionEnum.Species:
                outputHandler.DisplaySpecies();
                break;
            case OptionEnum.Starships:
                outputHandler.DisplayStarships();
                break;
            case OptionEnum.Vehicles:
                outputHandler.DisplayVehicles();
                break;
            default:
                Console.WriteLine("Please enter a valid option.");
                break;
        }

    }
}

