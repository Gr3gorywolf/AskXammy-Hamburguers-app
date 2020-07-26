using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HamburguersApp.Models
{
    interface IHamburguerApi
    {
        [Get("/v1/hamburguers/gethamburguers")]
        Task<List<Hamburguer>> GetAll();

        [Get("/v1/hamburguers/gethamburguer/{Id}")]
        Task<Hamburguer> GetById(int Id);

        [Post("/v1/hamburguers/createhamburguer")]
        Task<Hamburguer> Create([Body] Hamburguer hamburguer);
        

    }
}
