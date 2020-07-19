using System;
using System.Collections.Generic;
using System.Text;

namespace HamburguersApp.Utils
{
   public class Constants
    {
        public const Environment Env = Environment.Development;

        public enum Environment
        {
            Development = 0,
            Production = 1,

        } 
    }
}
