﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HamburguersApp.Models
{
   public class Hamburguer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
