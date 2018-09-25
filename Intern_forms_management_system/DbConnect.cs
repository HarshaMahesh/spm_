using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Intern_forms_management_system
{
    class DbConnect
    {
        
        public MySqlConnection con;

        public void Connection()
        {
            try
            {
                con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='ifms';username=root;password=;Convert Zero Datetime=True;SslMode=none");
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
    }
}
