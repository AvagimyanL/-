﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Приложение_Автосервис.Controller
{
    class ConnectionString
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Приложение_Автосервис.Properties.Settings.Автосервис_mdb_ConnectionString"].ConnectionString;
                
            }
        }
    }
}
