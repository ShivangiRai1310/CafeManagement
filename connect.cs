using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CafeManagement
{
    class connect
    {
        public MySqlConnection con;

        public void connection()
        {
            con = new MySqlConnection("datasource=localhost; database=cafe; port=3306;username = root; password=12345");
            con.Open();
        }

    }
}
