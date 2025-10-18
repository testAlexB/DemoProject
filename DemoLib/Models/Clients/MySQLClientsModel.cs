using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DemoLib.Models.Clients
{
    public class MySQLClientsModel : IClientsModel
    {
        public int GetClientsCount()
        {
            string connStr = "server=localhost;user=root;database=clients_db;password=1234567;port=3307;";

            try
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();

                string sql = "SELECT COUNT(id) FROM clientsinfo";
                MySqlCommand command = new MySqlCommand(sql, connection);
                int result = Convert.ToInt32(command.ExecuteScalar().ToString());
                connection.Close();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Client> ReadAllClients()
        {
            return new List<Client>();
        }
    }
}
