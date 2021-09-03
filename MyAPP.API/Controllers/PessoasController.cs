using Microsoft.AspNetCore.Mvc;
using MyAPP.LIB.Interfaces.Database;
using System;

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

        [HttpGet]
        [Route("consultar")]
        public IActionResult ConsultarCadastro(Guid id)
        {
            var guid = Guid.NewGuid();
            var pessoa = db.Pessoa.ConsultaPessoa(id);
            if (pessoa == null) return NoContent();

            return Ok(pessoa);
        }

        [HttpPost]
        [Route("cadastro")]
        public IActionResult CadastroPessoa([FromBody] LIB.Models.Entradas.PessoasParametros pessoa)
        {
            if (string.IsNullOrWhiteSpace(pessoa.Nome_Juridico)) return BadRequest("NOME NÃO PREENCHIDO!");

            pessoa.UUId = Guid.NewGuid();

            var row = db.Pessoa.CadastrarPessoa(pessoa);
            return Ok(row);
        }
    }
}
