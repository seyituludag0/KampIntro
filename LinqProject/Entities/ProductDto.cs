﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProject.Entities
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
