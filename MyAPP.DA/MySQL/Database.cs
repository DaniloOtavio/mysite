using Dapper;
using MyAPP.LIB.Interfaces.Database;
using System;

namespace MyAPP.DA.MySQL
{
    public class Database : IDatabase
    {
        private readonly DBFactory dBFactory;

        public Database(string connectionString)
        {
            dBFactory = new DBFactory(connectionString);
        }

        public IPessoa Pessoa { get; private set; }

        public void Config()
        {
            SqlMapper.AddTypeHandler(new Customer.DA.TypesHandler.MySqlGuidHandler());
            SqlMapper.RemoveTypeMap(typeof(Guid));
            SqlMapper.RemoveTypeMap(typeof(Guid?));

            Pessoa = new Actions.Pessoas(dBFactory);
        }
    }
}
