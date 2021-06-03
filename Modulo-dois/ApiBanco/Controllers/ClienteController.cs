using ApiBanco.Data;
using ApiBanco.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBanco.Controllers
{
    [ApiController]
    [Route("v1/clientes")]
    public class ClienteController : ControllerBase
    {
        // Mostra todos os Clientes
       [HttpGet]
       [Route("")]
       public async Task<ActionResult<IList<Cliente>>> GetAll([FromServices] DataContext context)
        {
            return await context.Clientes.Include(cc => cc.ContaCorrente).Include(t => t.ContaCorrente.Transacao).ToListAsync();
        }

        // Mostra um cliente pelo código
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Cliente>> GetById([FromServices] DataContext context, int id)
        {
            return await context.Clientes.FirstOrDefaultAsync(cliente => cliente.Id == id);
        }

        // Adiciona um novo Cliente
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Cliente>> Insert([FromServices] DataContext context, [FromBody] Cliente model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var cliente = new Cliente();
                    cliente.Nome = model.Nome;
                    cliente.Data_Nascimento = model.Data_Nascimento;
                    cliente.Data_Nascimento = model.Cpf;
                    cliente.Telefone = model.Telefone;

                    var cc = new ContaCorrente();
                    cc.Saldo = model.ContaCorrente.Saldo;

                    context.Clientes.Add(model);
                    await context.SaveChangesAsync();
                    return Ok(model);
                }
                else
                {
                    throw new Exception("Não foi possivel inserir os Dados!");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
