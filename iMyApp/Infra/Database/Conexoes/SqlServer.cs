﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexoes
{
    internal class SqlServer
    {
        internal static string StrConexao()
        {
            return "Server=localhost;Database=iMyApp;User Id=sa;Password=sql2022;";
        }
               
    }

}
