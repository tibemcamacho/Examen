﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapateria.Model
{
    public class article
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int total_in_shelf { get; set; }
        public int total_in_vault { get; set; }
        public int store_id { get; set; }
        public object stores { get; set; }
    }
}
