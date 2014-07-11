using System.Data.SqlClient;
using System.Diagnostics;

[assembly: DebuggerDisplay("{ConnectionString} is {State}", Target = typeof(SqlConnection))]