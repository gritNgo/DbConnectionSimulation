using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionSimulation
{
    internal class DbCommand
    {
        private readonly DbConnection _dbConnection;
        public string Instruction { get; set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
            {
                throw new ArgumentNullException("dbConnection");
            }
            _dbConnection = dbConnection;

            if (instruction == null || instruction == "")
            {
                throw new ArgumentNullException("instruction");
            }
            Instruction = instruction;
        }


        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(Instruction);
            _dbConnection.CloseConnection();
        }
    }
}
