using System;
using System.Collections.Generic;
using System.Text;

namespace HamburguersApp.Utils
{
   public class Constants
    {
        public const Environment Env = Environment.Production;

        public static string BaseUrl
        {
            get
            {
                if(Env == Environment.Production)
                {
                    return "http://hamburguersapp.azurewebsites.net/api/";
                }
                else
                {
                    return "localhost:44355";
                }
            }
        }
        public enum Environment
        {
            Development = 0,
            Production = 1,

        } 
    }
}
