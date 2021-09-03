using System;

namespace MyAPP.LIB.Interfaces.Database
{
    public interface IPessoa
    {
        bool CadastrarPessoa(ModelsDB.IPessoa pessoa);
        ModelsDB.IPessoa ConsultaPessoa(Guid id);
    }
}
