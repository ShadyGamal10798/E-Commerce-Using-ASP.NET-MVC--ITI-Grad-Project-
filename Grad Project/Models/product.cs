﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Grad_Project.Models
{
    public partial class product
    {
        public product()
        {
            carts = new HashSet<cart>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal? price { get; set; }
        public int? cat_id { get; set; }
        public string photo { get; set; }

        public virtual category cat { get; set; }
        public virtual ICollection<cart> carts { get; set; }
    }
}