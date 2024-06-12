using DbConnectionSimulation;

var sqlConnection = new SqlConnection("SQL connection string");


var sqlCommand = new DbCommand(sqlConnection, "Run SQL connection");

sqlCommand.Execute();

Console.WriteLine("__________________________________");
Console.WriteLine();

var oracleConnection = new OracleConnection("Oracle connection string");

var oracleCommand = new DbCommand(oracleConnection, "Run Oracle connection");

oracleCommand.Execute();