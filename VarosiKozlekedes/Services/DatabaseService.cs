using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarosiKozlekedes.Models;
using MySql.Data.MySqlClient;

namespace VarosiKozlekedes.Services
{
    internal class DatabaseService
    {
        public static List<Jegyrendszer> jegyek = new List<Jegyrendszer>();
        public static List<Jegyrendszer> GetJegyek()
        {
            try
            {
                string connectionString = "SERVER = localhost; DATABASE = varosikozlekedes; user=root; PASSWORD =";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT alapdij, tavolsag, jegytipus FROM jegyrendszer;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int alapdij = reader.GetInt32("alapdij");
                            int tavolsag = reader.GetInt32("tavolsag");
                            string tipus = reader.GetString("jegytipus");

                            Jegyrendszer ujJegy = null;
                            switch (tipus)
                            {
                                case "Vonalbusz":
                                    ujJegy = new Vonalbusz { Alapdij = alapdij, Tavolsag = tavolsag };
                                    break;
                                case "Gyorsvasut":
                                    ujJegy = new Gyorsvasut { Alapdij = alapdij, Tavolsag = tavolsag };
                                    break;
                                case "ElektromosRoller":
                                    ujJegy = new ElektromosRoller { Alapdij = alapdij, Tavolsag = tavolsag };
                                    break;
                            }
                            jegyek.Add(ujJegy);
                        }
                    }
                }
                return jegyek;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return jegyek;
            }
        }
    }
}
