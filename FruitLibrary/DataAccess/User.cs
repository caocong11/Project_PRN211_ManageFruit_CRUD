using System;
using System.Collections.Generic;

namespace FruitLibrary.DataAccess;

public partial class User
{
    public int Id { get; set; }

    public string? Acc { get; set; }

    public string? Pass { get; set; }

    public string? Name { get; set; }

    public DateTime? Dob { get; set; }

    public string? Address { get; set; }

    public bool? Role { get; set; }
}
