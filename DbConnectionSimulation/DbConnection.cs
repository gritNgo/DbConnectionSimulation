﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionSimulation
{
    internal abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string connectionString)
        {
            if (connectionString == null || connectionString == "")
            {
                throw new ArgumentNullException("connectionString");
            }

            ConnectionString = connectionString;            
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
