using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace data_models
{
    public class DbConfig
    {
        public string server { get; set; }
        public string database { get; set; }
        public string uid { get; set; }
        public string password { get; set; }

        public static string GetMySQLConnectionString()
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
}
