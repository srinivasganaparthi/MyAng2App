﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiService.Models
{
  public class Category
  {
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int parentid { get; set; }
  }
}