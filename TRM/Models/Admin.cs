﻿using System.ComponentModel.DataAnnotations;

namespace TRM.Models
{
    public class Admin
    {
        [Key]public int AdminId { get; set; }
        public string ?UserName { get; set; }
        public string? Password { get; set; }
    }
}
