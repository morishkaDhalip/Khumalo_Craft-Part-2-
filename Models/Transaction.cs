﻿using System;
using System.Collections.Generic;

namespace Khumalo_Craft.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int? Quantity { get; set; }

    public int? ProductId { get; set; }

    public int? UserId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
