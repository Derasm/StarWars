namespace Web.Models
{
    public class Starship
    {
        public string name { get; set; } // The name of this starship. The common name, such as "Death Star".
        public string model { get; set; } // The model or official name of this starship, such as "T-65 X-wing" or "DS-1 Orbital Battle Station".
        public string starship_class { get; set; } // The class of this starship, such as "Starfighter" or "Deep Space Mobile Battlestation".
        public string manufacturer { get; set; } // The manufacturer of this starship. Comma separated if more than one.
        public string cost_in_credits { get; set; } // The cost of this starship new, in galactic credits.
        public string length { get; set; } // The length of this starship in meters.
        public string crew { get; set; } // The number of personnel needed to run or pilot this starship.
        public string passengers { get; set; } // The number of non-essential people this starship can transport.
        public string max_atmosphering_speed { get; set; } // The maximum speed of this starship in the atmosphere. "N/A" if this starship is incapable of atmospheric flight.
        public string hyperdrive_rating { get; set; } // The class of this starship's hyperdrive.
        public string MGLT { get; set; } // The Maximum number of Megalights this starship can travel in a standard hour.
        public string cargo_capacity { get; set; } // The maximum number of kilograms that this starship can transport.
        public string consumables { get; set; } // The maximum length of time that this starship can provide consumables for its entire crew without having to resupply.
        public List<string> films { get; set; } // An array of Film URL Resources that this starship has appeared in.
        public List<string> pilots { get; set; } // An array of People URL Resources that this starship has been piloted by.
        public string url { get; set; } // The hypermedia URL of this resource.
        public string created { get; set; } // The ISO 8601 date format of the time that this resource was created.
        public string edited { get; set; } // The ISO 8601 date format of the time that this resource was edited.
    }
}
