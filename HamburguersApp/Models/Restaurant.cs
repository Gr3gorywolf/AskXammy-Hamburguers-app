using System;
using System.Collections.Generic;
using System.Text;

namespace HamburguersApp.Models
{
   public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public  List<Hamburguer> Hamburguers { get; set; }
    }
}
