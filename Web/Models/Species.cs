namespace Web.Models
{
    public class Species
    {
        public string name { get; set; } // The name of this species.
        public string classification { get; set; } // The classification of this species, such as "mammal" or "reptile".
        public string designation { get; set; } // The designation of this species, such as "sentient".
        public string average_height { get; set; } // The average height of this species in centimeters.
        public string average_lifespan { get; set; } // The average lifespan of this species in years.
        public string eye_colors { get; set; } // A comma-separated string of common eye colors for this species, "none" if this species does not typically have eyes.
        public string hair_colors { get; set; } // A comma-separated string of common hair colors for this species, "none" if this species does not typically have hair.
        public string skin_colors { get; set; } // A comma-separated string of common skin colors for this species, "none" if this species does not typically have skin.
        public string language { get; set; } // The language commonly spoken by this species.
        public string homeworld { get; set; } // The URL of a planet resource, a planet that this species originates from.
        public List<string> people { get; set; } // An array of People URL Resources that are a part of this species.
        public List<string> films { get; set; } // An array of Film URL Resources that this species has appeared in.
        public string url { get; set; } // The hypermedia URL of this resource.
        public string created { get; set; } // The ISO 8601 date format of the time that this resource was created.
        public string edited { get; set; } // The ISO 8601 date format of the time that this resource was edited.
    }
}
