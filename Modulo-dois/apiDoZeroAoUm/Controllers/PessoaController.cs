using apiDoZeroAoUm.Data;
using apiDoZeroAoUm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiDoZeroAoUm.Controllers
{
 
    [ApiController]
    [Route("v1/pessoas")] //Mesma função do RequestMapping("/v1/pessoas")
    public class PessoaController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Pessoa>> Insert([FromServices] DataContext context, [FromBody] Pessoa model)
        {
            if (ModelState.IsValid)
            {
                context.Pessoas.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IList<Pessoa>>> GetAll([FromServices] DataContext context)
        {
	         return await context.Pessoas.ToListAsync();
        }


        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Pessoa>> GetById([FromServices] DataContext context, int id)
        {
            return await context.Pessoas.FirstOrDefaultAsync( pessoa => pessoa.Id == id);
        }

        [HttpPut]
        [Route("")]
        public async Task<ActionResult<Pessoa>> Update([FromServices] DataContext context, [FromBody] Pessoa model)
        {
            if (ModelState.IsValid)
            {
                var pessoa = await context.Pessoas.FirstOrDefaultAsync(pessoa => pessoa.Id == model.Id);

                if (pessoa != null)
                {
                    pessoa.Nome = model.Nome;
                    pessoa.Idade = model.Idade;
                    pessoa.Sexo = model.Sexo;

                    context.Pessoas.Update(pessoa);
                    await context.SaveChangesAsync();
                    return Ok(pessoa);
                }
                else
                {
                    return BadRequest($"Não foi possivel localizar o registro de ID: {model.Id}");
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Pessoa>> Delete([FromServices] DataContext context, int id)
        {
            var pessoa = await context.Pessoas.FirstOrDefaultAsync(pessoa => pessoa.Id == id);

            if (pessoa != null)
            {
                context.Pessoas.Remove(pessoa);
                await context.SaveChangesAsync();
            }

            return Ok(pessoa);
        }
    }
}
