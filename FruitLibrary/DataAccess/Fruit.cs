using System;
using System.Collections.Generic;

namespace FruitLibrary.DataAccess;

public partial class Fruit
{
    public int Id { get; set; }

    public string? FruitName { get; set; }

    public string? From { get; set; }

    public string? Price { get; set; }
}
