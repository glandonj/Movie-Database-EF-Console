using System;
using System.Collections.Generic;

namespace Movie_Database_EF_Console;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Genre { get; set; }

    public double? Runtime { get; set; }
}
