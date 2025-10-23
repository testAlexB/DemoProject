using System;
using System.Collections.Generic;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace DemoLib.Models.Clients
{
    public class MySQLClientsModel : IClientsModel
    {
        private const string connStr = "server=localhost;user=root;database=clients_db;password=1234567;port=3307;";
        public int GetClientsCount()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string sql = "SELECT COUNT(id) FROM clientsinfo";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    int result = Convert.ToInt32(command.ExecuteScalar().ToString());

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Client> ReadAllClients()
        {
            List<Client> clients = new List<Client>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string sql = "SELECT id, clientName, phone, mail, description, imagePath FROM clientsinfo";
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client client = new Client(reader.GetInt32(0));

                            client.Name = reader.GetString(1);
                            client.Phone = reader.GetString(2);
                            client.Mail = reader.GetString(3);
                            client.Description = reader.GetString(4);
                            client.ImagePath = reader.GetString(5);

                            clients.Add(client);
                        }
                    }

                    return clients;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
