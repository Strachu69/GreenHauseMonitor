﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cmms.Entities
{
    public class Restaurant : EntityBase
    {        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool HasDelivery { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public virtual User CreatedBy { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual List<Dish> Dishes { get; set; }

    }
}
