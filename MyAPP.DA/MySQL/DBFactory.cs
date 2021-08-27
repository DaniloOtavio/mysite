using System.Data;

namespace MyAPP.DA.MySQL
{
    public class DBFactory
    {
        private string ConnectionString { get; }

        public DBFactory(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public IDbConnection Create()
        {
            var conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

    }
}
