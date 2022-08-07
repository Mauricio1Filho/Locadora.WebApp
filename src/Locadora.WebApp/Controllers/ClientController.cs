using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.ViewModel;

namespace Locadora.WebApp.Controllers
{
    public class ClientController : Controller
    {
        #region Views
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region Injections
        private readonly IClienteService _clienteService;
        public ClientController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        #endregion        

        #region Endpoints
        [HttpPost]
        public IActionResult RegisterClient([FromBody] ClientViewModel clienteModel)
        {
            try
            {
                var result = _clienteService.CadastrarClient(ClientViewModel.MapClientDTOToModel(clienteModel));
                if (result == true)
                {
                    return Ok();
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            return BadRequest();
        }

        [HttpDelete("{idCliente}")]
        public IActionResult RemoverClient(long idCliente)
        {
            try
            {
                _clienteService.RemoverClient(idCliente);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        public IActionResult AtualizarClient([FromBody] ClienteModel clienteModel)
        {
            try
            {
                _clienteService.AtualizarClient(clienteModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
