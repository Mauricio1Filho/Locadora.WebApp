using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.ApisControllers
{
    [Route("api/[Controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<IActionResult> ClientePost([FromBody] ClienteModel clienteModel)
        {
            try
            {
                await _clienteService.CadastrarClientAsync(clienteModel);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete("{idCliente}")]
        public async Task<IActionResult> ClienteDelete(long idCliente)
        {
            try
            {
                await _clienteService.RemoverClientAsync(idCliente);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        public async Task<IActionResult> ClienteUpdate([FromBody] ClienteModel clienteModel)
        {
            try
            {
                await _clienteService.AtualizarClientAsync(clienteModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        
    }
}
