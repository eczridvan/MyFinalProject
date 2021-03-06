﻿using System;
using System.Collections.Generic;
using System.Text;
using Corem.Entities;


namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
