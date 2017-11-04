using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_models;
using data_models.Models;
using System.Net;
using MySql.Data.MySqlClient;
using System.IO;

namespace playground
{
    class playground
    {
        static void Main(string[] args)
        {
                using (var context = NetFrameworkMenuContext.GetContext())
                {
                    context.Database.CreateIfNotExists();
                    var ta = from e in context.Table select e;
                    foreach (var t in ta)
                    {
                        Console.WriteLine("Table ID: " + t.TableID + " ~ IsEmpty: " + t.IsEmpty + "\n");
                    }
                }
            
            Console.ReadLine();
        }

    }

}
