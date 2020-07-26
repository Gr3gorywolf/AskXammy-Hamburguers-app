using HamburguersApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HamburguersApp.Utils.Controllers
{
   public class HamburguerController
    {
       
        public async Task<Hamburguer> PostHamburguer(Hamburguer hamburguer)
        {
            return await RestService.For<IHamburguerApi>(Constants.BaseUrl).Create(hamburguer);
        }
        public async Task<List<Hamburguer>> GetHamburguers()
        {
            return await RestService.For<IHamburguerApi>(Constants.BaseUrl).GetAll();
        }

    }
}
