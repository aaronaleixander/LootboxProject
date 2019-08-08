using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBoxProject
{
    static class LootboxDB
    {
        public static List<LootboxClass> GetAllLootboxes()
        {
            // Get connection to the database
            SqlConnection con = DBHelper.GetConnection();



            // Get the query set up

            string query = "SELECT LootboxTheme, LootboxName, LootboxContents, LootboxDescription, LootboxPrice FROM Lootboxes";


            SqlCommand selCmd = new SqlCommand
            {
                Connection = con,
                CommandText = query
            };

            // Open Connection
            con.Open();

            // Execute query
            SqlDataReader rdr = selCmd.ExecuteReader();

            List<LootboxClass> lootboxList = new List<LootboxClass>();

            // Read each row

            while (rdr.Read())
            {
                LootboxClass tempBox = new LootboxClass
                {
                    Theme = Convert.ToString(rdr["LootboxTheme"]),
                    Name = Convert.ToString(rdr["LootboxName"]),
                    Contents = Convert.ToString(rdr["LootboxContents"]),
                    Description = Convert.ToString(rdr["LootboxDescription"]),
                    Price = Convert.ToDouble(rdr["LootboxPrice"])
                };
                lootboxList.Add(tempBox);
            }
            con.Close();
            return lootboxList;
        }

        public static void Add(LootboxClass lb)
        {
            SqlConnection con = DBHelper.GetConnection();
            SqlCommand addCmd = new SqlCommand();
            addCmd.Connection = con;

            addCmd.CommandText = "INSERT INTO Lootboxes (LootboxTheme, LootboxName. LootboxContents, LootboxDescription, LootboxPrice)" +
                                 "VALUES (@theme, @name, @contents, @description, @price)";

            // Add values into the parameters

            addCmd.Parameters.AddWithValue("@theme", lb.Theme);
            addCmd.Parameters.AddWithValue("@name", lb.Name);
            addCmd.Parameters.AddWithValue("@contents", lb.Contents);
            addCmd.Parameters.AddWithValue("@description", lb.Theme);
            addCmd.Parameters.AddWithValue("@theme", lb.Theme);

            try
            {
                con.Open();
                int rows = addCmd.ExecuteNonQuery();
            }
            finally
            {
                con.Dispose();
            }

        }
    }
}
