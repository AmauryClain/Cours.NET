using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=DESKTOP-GGFRMLI;Initial Catalog=bddc#;Integrated Security=True";

        string query = "SELECT * FROM ani_animal";



        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string ani_name = reader.GetString(0); 
                    string ani_rarity = reader.GetString(1); 
                     
                    Console.WriteLine($"Colonne 1 : {ani_name}, Colonne 2 : {ani_rarity}");
                }
            }
        }

    }
}
