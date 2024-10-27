﻿using System;
using System.Collections.Generic;

namespace GitAPI1.Models;

public partial class Brand1
{
    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public virtual ICollection<Product1> Product1s { get; set; } = new List<Product1>();
}
