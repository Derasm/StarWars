using ConsoleVersion.Controllers;
using ConsoleVersion.Enums;
// This is going to be a simple console app that renders information depending on the searched API from the backend. 
class Program
{
    // This should in theory handle the flow, which is:
    // 1. Get input from the user
    // 2. Handle the input from the user
    // 3. display the option based on the input
    // 3.5 - if the option has an additional option (like say looking into an individual person, then display that option)
    // 4. return to the start screen if the user pressed "start"
    static void Main()
    {
        ConsoleInputHandler inputHandler = new ConsoleInputHandler();
        ConsoleOutputHandler outputHandler = new ConsoleOutputHandler();
        outputHandler.StartScreen();
        while (true)
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
        Console.Clear();

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
            case OptionEnum.Start:
                outputHandler.StartScreen();
                break;
            default:
                Console.WriteLine("Please enter a valid option.");
                break;
        }

    }
}

