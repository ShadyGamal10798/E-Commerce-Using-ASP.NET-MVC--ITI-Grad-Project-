﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Grad_Project.Models
{
    public partial class cart
    {
        public int id { get; set; }
        public int? userID { get; set; }
        public int? productID { get; set; }
        public int Qty { get; set; }
        public decimal? ttlPrice { get; set; }

        public virtual product product { get; set; }
        public virtual user user { get; set; }
    }
}