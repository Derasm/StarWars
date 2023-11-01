namespace Web.Models
{
    public class Film
    {
        public string title { get; set; } // The title of this film
        public int episode_id { get; set; } // The episode number of this film.
        public string opening_crawl { get; set; } // The opening paragraphs at the beginning of this film.
        public string director { get; set; } // The name of the director of this film.
        public string producer { get; set; } // The name(s) of the producer(s) of this film. Comma separated.
        public DateTime release_date { get; set; } // The ISO 8601 date format of film release at the original creator country.
        public List<string> species { get; set; } // An array of species resource URLs that are in this film.
        public List<string> starships { get; set; } // An array of starship resource URLs that are in this film.
        public List<string> vehicles { get; set; } // An array of vehicle resource URLs that are in this film.
        public List<string> characters { get; set; } // An array of people resource URLs that are in this film.
        public List<string> planets { get; set; } // An array of planet resource URLs that are in this film.
        public string url { get; set; } // The hypermedia URL of this resource.
        public string created { get; set; } // The ISO 8601 date format of the time that this resource was created.
        public string edited { get; set; } // The ISO 8601 date format of the time that this resource was edited.
    }
}
