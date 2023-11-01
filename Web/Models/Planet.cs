namespace Web.Models
{
    public class Planet
    {
        public string name { get; set; } // The name of this planet.
        public string diameter { get; set; } // The diameter of this planet in kilometers.
        public string rotation_period { get; set; } // The number of standard hours it takes for this planet to complete a single rotation on its axis.
        public string orbital_period { get; set; } // The number of standard days it takes for this planet to complete a single orbit of its local star.
        public string gravity { get; set; } // A number denoting the gravity of this planet, where "1" is normal or 1 standard G. "2" is twice or 2 standard Gs. "0.5" is half or 0.5 standard Gs.
        public string population { get; set; } // The average population of sentient beings inhabiting this planet.
        public string climate { get; set; } // The climate of this planet. Comma separated if diverse.
        public string terrain { get; set; } // The terrain of this planet. Comma separated if diverse.
        public string surface_water { get; set; } // The percentage of the planet surface that is naturally occurring water or bodies of water.
        public List<string> residents { get; set; } // An array of People URL Resources that live on this planet.
        public List<string> films { get; set; } // An array of Film URL Resources that this planet has appeared in.
        public string url { get; set; } // The hypermedia URL of this resource.
        public string created { get; set; } // The ISO 8601 date format of the time that this resource was created.
        public string edited { get; set; } // The ISO 8601 date format of the time that this resource was edited.
    }
}
