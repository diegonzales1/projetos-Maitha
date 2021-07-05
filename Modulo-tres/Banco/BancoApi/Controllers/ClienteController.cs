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
    public class ClienteController : ControllerBase
    {

        private readonly IClienteRepositorio _clienteRepository;

        public ClienteController(IClienteRepositorio cliente)
        {
            _clienteRepository = cliente;
        }

        // {id?} Verifica se a busca é pelo ID ou NÂO... Get e Get por ID
        // GET: api/<ClienteController>
        // GET api/<ClienteController>/5
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                if (id != 0)
                {
                    return Ok(_clienteRepository.ObterPorId(id));
                }
                else
                {
                    return Ok(_clienteRepository.ObterTodos());
                }
            }catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
          
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    internal interface IClienteRepository
    {
    }
}
