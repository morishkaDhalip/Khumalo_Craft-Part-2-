﻿using System;
using System.Collections.Generic;

namespace Khumalo_Craft.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public string? Category { get; set; }

    public bool? Availability { get; set; }
}
