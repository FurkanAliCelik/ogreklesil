using System;
using System.Collections.Generic;

namespace ogr.Data.Models;

public partial class Giris
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public class Parameteres
    {
        public class addWithValue
        {
        }
    }
}
