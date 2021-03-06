using BancoApi.Request;
using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
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
        private readonly IContatoRepositorio _contatoRepositorio;

        public ClienteController(IClienteRepositorio cliente, IContatoRepositorio contato)
        {
            _clienteRepository = cliente;
            _contatoRepositorio = contato;
        }

        // {id?} Verifica se a busca é pelo ID ou NÂO... Get e Get por ID
        // GET: api/<ClienteController>
        // GET api/<ClienteController>/5
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int id = 0)
        {
            try
            {
                if (id != 0)
                    return Ok(_clienteRepository.ObterPorId(id));

                return Ok(_clienteRepository.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST api/<ClienteController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cliente cliente)
        {
            try
            {
                _clienteRepository.Adicionar(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Cliente cliente)
        {
            try
            {
                if (id != cliente.Id)  
                    return BadRequest($"O id {id} é diferente do id do cliente"); 

                _clienteRepository.Atualizar(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, [FromBody] Cliente cliente)
        {
            try
            {
                if (id != cliente.Id) 
                    return NotFound("Id não encontrado!!"); 

                _clienteRepository.Remover(cliente);
                return Ok("Excluído com sucesso!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("ClientePorDocumento")]
        public async Task<IActionResult> ClientePorDocumento(ClienteRequest cliente)
        {
            return Ok(new Cliente());
        }

        [HttpGet("Contato/ClienteId/{id}")]
        public async Task<IActionResult> GetContatoClienteId(int id)
        {
            try
            {
                if (id == 0)
                    return NotFound("Id do cliente não informado!");
                else
                    return Ok(_contatoRepositorio.ObterTodos().Where(contato => contato.ClienteId == id).FirstOrDefault());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet("Contato/{id?}")]
        public async Task<IActionResult> GetContato(int id = 0)
        {
            try
            {
                if (id != 0)
                    return Ok(_contatoRepositorio.ObterPorId(id));

                return Ok(_contatoRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("Contato")]
        public async Task<IActionResult> NovoContato([FromBody] Contato contato)
        {
            try
            {
                _contatoRepositorio.Adicionar(contato);
                return Ok(contato);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }

  
}
