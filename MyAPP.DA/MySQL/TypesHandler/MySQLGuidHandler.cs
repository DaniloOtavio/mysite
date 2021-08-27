using Dapper;
using System;
using System.Data;

namespace Customer.DA.TypesHandler
{
    public class MySqlGuidHandler : SqlMapper.TypeHandler<Guid>
    {
        public override Guid Parse(object value)
        {
            var cassete = new Guid((byte[])value);
            return cassete;
        }

        public override void SetValue(IDbDataParameter parameter, Guid value)
        {
            parameter.Value = value.ToByteArray();
        }
    }
}