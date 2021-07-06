using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenciaController : ControllerBase
    {
        private readonly IAgenciaRepositorio _agenciaRepositorio;

        public AgenciaController(IAgenciaRepositorio agencia)
        {
            _agenciaRepositorio = agencia;
        }

        // GET: api/<AgenciaController>
        // GET api/<AgenciaController>/5
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int id = 0)
        {
            try
            {
                if(id != 0)
                {
                    return Ok(_agenciaRepositorio.ObterPorId(id));
                }

                return Ok(_agenciaRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST api/<AgenciaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Agencia agencia)
        {
            try
            {
                _agenciaRepositorio.Adicionar(agencia);
                return Ok(agencia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT api/<AgenciaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Agencia agencia)
        {
            try
            {
                if(id != agencia.Id) { throw new Exception("Id diferente do id do cliente"); }
                _agenciaRepositorio.Atualizar(agencia);
                return Ok(agencia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // DELETE api/<AgenciaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, [FromBody] Agencia agencia)
        {
            try
            {
                if(id != agencia.Id) { return NotFound("Id não encontrado!!"); }
                _agenciaRepositorio.Remover(agencia);
                return Ok("Excluído com sucesso!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
