using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HamburguersApp.Models;

namespace HamburguersApp.Services
{
    interface IUserApi
    {
        [Get("/v1/users/getuserdetails/{Id}")]
        Task<User> GetDetails(int Id);
        [Post("/v1/users/login")]
        Task<User> Login([Body] UserLogin credentials);
        [Post("/v1/users/register")]
        Task<User> Register([Body] User user);
    }
}
