
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionSimulation
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            
        }

        public override void Open()
        {
            Console.WriteLine("Open Oracle connection");
        }

        public override void Close()
        {
            Console.WriteLine("Close Oracle connection");
        }
    }
}
