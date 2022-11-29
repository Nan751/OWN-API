using System;
using System.Collections.Generic;

namespace Movieapi.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Year { get; set; }

    public string? Images { get; set; }
}
