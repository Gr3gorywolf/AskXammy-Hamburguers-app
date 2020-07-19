using HamburguersApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HamburguersApp.Utils.Controllers
{
   public class HamburguerController
    {
        //Todo: Implementar refit en esta parte
        public async Task<Hamburguer> PostHamburguer(Hamburguer hamburguer)
        {
            await Task.Delay(1000);
            _hamburguers.Add(hamburguer);
            return hamburguer;
        }

        //Todo: Implementar refit en esta parte
        public async Task<List<Hamburguer>> GetHamburguers()
        {
            await Task.Delay(1000);
            return _hamburguers;
        }

        //Solamete para propositos de prueba
        private static List<Hamburguer> _hamburguers = new List<Hamburguer>();

    }
}
