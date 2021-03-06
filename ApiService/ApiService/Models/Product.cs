﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiService.Models
{
  public class Product
  {
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public decimal price { get; set; }
    public DateTime mfcdate { get; set; }
    public int quantity { get; set; }
    public string category { get; set; }
    public int categoryId { get; set; }
  }
}