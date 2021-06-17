using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using apiDoZeroAoUm.Models;
using apiDoZeroAoUm.Data;

namespace apiDoZeroAoUm.Controllers
{
    [ApiController]
    [Route("v1/profissional")] 
    public class ProfissionalController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Profissional>> Insert([FromServices] DataContext context, [FromBody] Profissional model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var pessoa = new Pessoa();
                    pessoa.Nome = model.Pessoa.Nome;
                    pessoa.Idade = model.Pessoa.Idade;
                    pessoa.Sexo = model.Pessoa.Sexo;

                    var profissional = new Profissional();
                    profissional.Funcao = model.Funcao;
                    profissional.Num_Carteira = model.Num_Carteira;
                    profissional.Pessoa = pessoa;
                    
                    context.Profissionais.Add(model);
                    await context.SaveChangesAsync();
                    return Ok(model);
                }
                else
                {
                    throw new Exception("Não foi possivel inserir os Dados!");
                }
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IList<Profissional>>> GetAll([FromServices] DataContext context)
        {
            return await context.Profissionais.Include(p => p.Pessoa).ToListAsync();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Profissional>> GetById([FromServices] DataContext context, int id)
        {
            return await context.Profissionais.FirstOrDefaultAsync(profissional => profissional.Id == id);
        }

        [HttpPut]
        [Route("")]
        public async Task<ActionResult<Profissional>> Update([FromServices] DataContext context, [FromBody] Profissional model)
        {
            if (ModelState.IsValid)
            {
                var profissional = await context.Profissionais.FirstOrDefaultAsync(profissional => profissional.Id == model.Id);

                if (profissional != null)
                {
                    profissional.Funcao = model.Funcao;
                    profissional.Num_Carteira = model.Num_Carteira;
                   

                    context.Profissionais.Update(profissional);
                    await context.SaveChangesAsync();
                    return Ok(profissional);
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
        public async Task<ActionResult<Profissional>> Delete([FromServices] DataContext context, int id)
        {
            var profissional = await context.Profissionais.FirstOrDefaultAsync(profissional => profissional.Id == id);

            if (profissional != null)
            {
                context.Profissionais.Remove(profissional);
                await context.SaveChangesAsync();
            }

            return Ok(profissional);
        }
    }
}
