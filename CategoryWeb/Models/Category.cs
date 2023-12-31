﻿using System.ComponentModel.DataAnnotations;

namespace CategoryWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public int DisplayOrder { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
