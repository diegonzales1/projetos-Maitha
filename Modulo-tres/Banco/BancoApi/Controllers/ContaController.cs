
using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancoApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {

        private readonly IContaRepositorio _contaRepositorio;

        public ContaController(IContaRepositorio conta)
        {
            _contaRepositorio = conta;
        }

        // GET: api/<ContaController>
        // GET api/<ContaController>/5
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int id = 0)
        {
            try
            {
                if (id != 0) 
                    return Ok(_contaRepositorio.ObterPorId(id)); 

                return Ok(_contaRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST api/<ContaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Conta conta)
        {
            try
            {
                _contaRepositorio.Adicionar(conta);
                return Ok(conta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT api/<ContaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Conta conta)
        {
            try
            {
                if(id != conta.Id) 
                    throw new Exception("Id não encontrado!!"); 

                _contaRepositorio.Atualizar(conta);
                return Ok(conta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // DELETE api/<ContaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, [FromBody] Conta conta)
        {
            try
            {
                if(id != conta.Id) 
                    return NotFound("Id não encontrado!"); 

                _contaRepositorio.Remover(conta);
                return Ok("Excluído com sucesso!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
