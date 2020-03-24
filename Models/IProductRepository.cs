﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAuthority.Models
{
    public class IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
