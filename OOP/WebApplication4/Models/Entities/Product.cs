﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
        public string Category { get; set; }
    }
}