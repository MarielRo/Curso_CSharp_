using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Capas
{
    class Configuracion
    {
        public static string getConnectionString
        {
            get
            {
            return Properties.Settings.Default.ConnectionString;
            }
        }   
    }
        
}
