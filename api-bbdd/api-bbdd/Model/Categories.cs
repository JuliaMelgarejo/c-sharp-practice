﻿using System.ComponentModel.DataAnnotations;

namespace api_bbdd.Model
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
 
    }
}
