﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.BusinessObjects
{
    public class Sale
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public System.DateTime DateSold { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }

    }
}
