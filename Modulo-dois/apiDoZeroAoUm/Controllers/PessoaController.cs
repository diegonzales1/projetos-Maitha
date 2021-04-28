using apiDoZeroAoUm.Data;
using apiDoZeroAoUm.Models;
using Microsoft.AspNetCore.Mvc;
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
    }
}
