using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBoxProject
{
    class DBHelper
    {
        /// <summary>
        /// This method will get a connection to the book registration database.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=LootboxDB; Integrated Security=True");
        }
    }
}
