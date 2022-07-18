using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClienteService _clienteService;
        public ClientController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarClientAsync([FromBody] ClienteModel clienteModel)
        {
            try
            {
                _clienteService.CadastrarClientAsync(clienteModel);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete("{idCliente}")]
        public async Task<IActionResult> RemoverClientAsync(long idCliente)
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
        public async Task<IActionResult> AtualizarClientAsync([FromBody] ClienteModel clienteModel)
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
