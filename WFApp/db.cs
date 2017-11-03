using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_models.Models;
using System.Net;
using MySql.Data.MySqlClient;
using System.IO;
using Newtonsoft.Json;

namespace WFApp
{
    class db
    {
        static void Main(string[] args)
        {
            string connectionString = GetMySQLConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (var context = new MenuContext(connection,false))
                {
                    context.Database.CreateIfNotExists();
                    var ta = from e in context.Table select e;
                    foreach (var t in ta)
                    {
                        Console.WriteLine("Table ID: " + t.TableID + " ~ IsEmpty: " + t.IsEmpty + "\n");
                    }
                }
            }
            Console.ReadLine();
        }

        private static string GetMySQLConnectionString()
        {
            DbConfig config;
            using (StreamReader r = new StreamReader("dbconfig.json"))
            {
                string json = r.ReadToEnd();
                config = JsonConvert.DeserializeObject<DbConfig>(json);
            }
            return "Server=" + config.server + ";database=" + config.database + ";uid=" + config.uid + ";pwd=" + config.password;
        }
    }

    public class DbConfig
    {
        public string server { get; set; }
        public string database { get; set; }
        public string uid { get; set; }
        public string password { get; set; }

    }
}
