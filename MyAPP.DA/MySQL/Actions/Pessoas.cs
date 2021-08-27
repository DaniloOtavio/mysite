using Dapper;
using MyAPP.LIB.Interfaces.Database;

namespace MyAPP.DA.MySQL.Actions
{
    public class Pessoas : IPessoa
    {
        private readonly DBFactory dBFactory;
        public Pessoas(DBFactory dBFactory)
        {
            this.dBFactory = dBFactory;
        }
        public bool CadastrarPessoa(LIB.Interfaces.ModelsDB.IPessoa pessoa)
        {
            using (var conn = dBFactory.Create())
            {
                var row = conn.Execute(@"INSERT INTO 
pessoas (id, uuid, nome_juridico, cpf, rg, logradouro, numero, complemento, cep, bairro, cidade, uf, email, telefone1, telefone2, nome_social, data_nascimento, data_cadastro, data_contrato, data_desligamento, senha, nivel_acesso) 
values (@id,@uuid,@nome_juridico,@cpf,@rg,@logradouro,@numero,@complemento,@cep,@bairro,@cidade,@uf,@email,@telefone1,@telefone2,@nome_social,@data_nascimento,@data_cadastro,@data_contrato,@data_desligamento,@senha,@nivel_acesso)",
new
{
    pessoa.Id,
    pessoa.UUId,
    pessoa.Nome_Juridico,
    pessoa.Cpf,
    pessoa.Rg,
    pessoa.Logradouro,
    pessoa.Numero,
    pessoa.Complemento,
    pessoa.Cep,
    pessoa.Bairro,
    pessoa.Cidade,
    pessoa.Uf,
    pessoa.Email,
    pessoa.Telefone1,
    pessoa.Telefone2,
    pessoa.Nome_Social,
    pessoa.Data_Nascimento,
    pessoa.Data_Cadastro,
    pessoa.Data_Contrato,
    pessoa.Data_Desligamento,
    pessoa.Senha,
    pessoa.Nivel_Acesso
});
                return row > 0;
            }

        }
    }
}
