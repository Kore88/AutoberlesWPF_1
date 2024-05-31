using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoberles.MySQL
{
    internal class MySQLCommands
    {
        public static string carAll = "SELECT * FROM autoberles.car";
        public static string userAll = "SELECT * FROM autoberles.user";
        public static string reservationAll = "SELECT * FROM autoberles.reservation";
        public static string carAdd = "INSERT INTO autoberles.car (id,brand,type,year,price) VALUES ('null''@brand','@type','@year','@price')";

    }
}
