using Microsoft.AspNetCore.Mvc;
using MyAPP.LIB.Interfaces.Database;

namespace MyAPP.API.Controllers
{
    [ApiController]
    [Route("v1/pessoas")]
    public class PessoasController : Controller
    {
        private readonly IDatabase db;

        public PessoasController(IDatabase db)
        {
            this.db = db;
        }

        [HttpPost]
        [Route("cadastro")]
        public IActionResult CadastroPessoa(LIB.Models.Entradas.PessoasParametros pessoa)
        {
            string erro = verificaErrosPessoa(pessoa);

            if (!string.IsNullOrEmpty(erro)) return BadRequest(erro);

            var row = db.Pessoa.CadastrarPessoa(pessoa);
            return Ok(row);
        }

        private static string verificaErrosPessoa(LIB.Models.Entradas.PessoasParametros pessoa)
        {
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Cpf)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return Validations.Constantes.NOME_JURIDICO_VAZIO;

            return string.Empty;
        }
    }
}
