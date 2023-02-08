using Movie_Database_EF_Console;

//PopulateMovies();

MovieDbContext dbcontext = new MovieDbContext();

foreach (Movie m in dbcontext)
{

}




static void PopulateMovies()
{
    MovieDbContext dbcontext = new MovieDbContext();
    List<Movie> movies = new List<Movie>()
{
    new Movie(){Title = "Shawshank Redemption", Genre ="drama", Runtime = 202},
    new Movie(){Title = "The Dark Knight", Genre = "action", Runtime = 212 },
    new Movie(){Title = "Run Hide Fight", Genre = "action", Runtime = 169 },
    new Movie(){Title = "Zootopia", Genre = "animated", Runtime = 168 },
    new Movie(){Title = "How to Train Your Dragon", Genre = "animated", Runtime = 158 },
    new Movie(){Title = "The Terminal List", Genre = "action", Runtime = 480 },
    new Movie(){Title = "Instant Family", Genre = "drama", Runtime = 179 },
    new Movie(){Title = "La Misma Luna", Genre = "drama", Runtime = 169 },
    new Movie(){Title = "Pilgrim's Progress", Genre = "animated", Runtime = 113 },
    new Movie(){Title = "Insanity of God", Genre = "historical", Runtime = 90 },
    new Movie(){Title = "Swiss Family Robinson", Genre = "adventure", Runtime = 126 },
    new Movie(){Title = "Harriet", Genre = "historical", Runtime = 125 },
    new Movie(){Title = "The Green Book", Genre = "historical", Runtime = 130 },
    new Movie(){Title = "News of the World", Genre = "drama", Runtime = 119 },
    new Movie(){Title = "Fellowship of the Ring", Genre = "adventure", Runtime = 178 },
    new Movie(){Title = "The Princess Bride", Genre = "adventure", Runtime = 98 },
    new Movie(){Title = "Big Hero 6", Genre = "animated", Runtime = 102 },
    new Movie(){Title = "Little Women", Genre = "historical", Runtime = 135 },
    new Movie(){Title = "Avengers: Infinity War", Genre = "adventure", Runtime = 149 },
    new Movie(){Title = "Avengers: Endgame", Genre = "adventure", Runtime = 182 },
    new Movie(){Title = "Grease", Genre = "historical", Runtime = 110 },
    new Movie(){Title = "Carter", Genre = "action", Runtime = 132 },
    new Movie(){Title = "White Noise", Genre = "drama", Runtime = 136 },
    new Movie(){Title = "Spiderhead", Genre = "sci-fi", Runtime = 107 },
    new Movie(){Title = "Pacific Rim", Genre = "sci-fi", Runtime = 132 },
    new Movie(){Title = "Star Wars", Genre = "sci-fi", Runtime = 121 }
};
    dbcontext.Movies.AddRange(movies);
    dbcontext.SaveChanges();
}