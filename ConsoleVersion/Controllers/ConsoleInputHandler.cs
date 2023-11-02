﻿using ConsoleVersion.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVersion.Controllers
{
    internal class ConsoleInputHandler
    {
        public string GetUserInput()
        {
           
            return Console.ReadLine();
        }
        public OptionEnum UserOptions(string userInput)
        {
            OptionEnum userOption = OptionEnum.None;
            switch (userInput)
            {
                case "exit":
                    Environment.Exit(0);
                    break;
                case "1":
                    userOption = OptionEnum.Films;
                    break;
                case "2":
                    userOption = OptionEnum.People;
                    break;
                case "3":
                    userOption = OptionEnum.Planets;
                    break;
                case "4":
                    userOption = OptionEnum.Species;
                    break;
                case "5":
                    userOption = OptionEnum.Starships;
                    break;
                case "6":
                    userOption = OptionEnum.Vehicles;
                    break;
                default:
                    userOption = OptionEnum.None;
                    break;

            }
            return userOption;
        }
    }
}
