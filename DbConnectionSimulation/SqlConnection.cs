using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionSimulation
{
    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open SQL connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close SQL connection");
        }

    }
}
