using MyAPP.LIB.Helpers;
using MyAPP.LIB.Interfaces.ModelsDB;
using System;

namespace MyAPP.DA.MySQL.Models
{
    public class Pessoas : IPessoa
    {
        public int Id { get; set; }
        public Guid UUId { get; set; }
        public string Nome_Juridico { get; set; }
        //public int Cpf { get; set; }
        //public string Rg { get; set; }
        //public string Logradouro { get; set; }
        //public int Numero { get; set; }
        //public string Complemento { get; set; }
        //public int Cep { get; set; }
        //public string Bairro { get; set; }
        //public string Cidade { get; set; }
        //public EstadosBrasil Uf { get; set; }
        //public string Email { get; set; }
        //public string Telefone1 { get; set; }
        //public string Telefone2 { get; set; }
        //public string Nome_Social { get; set; }
        //public DateTime Data_Nascimento { get; set; }
        //public DateTime Data_Cadastro { get; set; }
        //public DateTime Data_Contrato { get; set; }
        //public DateTime Data_Desligamento { get; set; }
        //public string Senha { get; set; }
        //public Nivel_Acesso Nivel_Acesso { get; set; }
    }
}
