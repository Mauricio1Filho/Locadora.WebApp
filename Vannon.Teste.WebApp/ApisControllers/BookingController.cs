using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;

namespace Vannon.Teste.WebApp.ApisControllers
{
    [Route("api/[Controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IReservaService _reservaService;
        private readonly ILocacaoService _locacaoService;
        private readonly IFilmeService _filmeService;
        private readonly IClienteService _clienteService;

        public BookingController(IReservaService reservaService, ILocacaoService locacaoService, IFilmeService filmeService, IClienteService clienteService)
        {
            _reservaService = reservaService;
            _locacaoService = locacaoService;
            _filmeService = filmeService;
            _clienteService = clienteService;
        }

        [HttpPost("reserva")]
        public async Task<IActionResult> ReservarFilmeAsync([FromBody] long idFilme, long idLocacao)
        {
            try
            {
               await _reservaService.ReservarFilmeAsync(idFilme, idLocacao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        public async Task<IActionResult> RemoverReservaAsync(long idFilme, long idLocacao)
        {
            try
            {
               await _reservaService.RemoverReservaAsync(idFilme , idLocacao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("locacao")]
        public async Task<IActionResult> CriarLocacaoFilmeAsync([FromBody] long idCliente)
        {
            try
            {
               var result =  await _locacaoService.CriarLocacaoFilmeAsync(idCliente);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        public async Task<IActionResult> BuscarFilmeAsync(long idFilme)
        {
            try
            {
               var result = await _filmeService.BuscarFilmeAsync(idFilme);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet("cpf/{cpf}")]
        public async Task<IActionResult> BuscarClientCpfAsync(string cpf)
        {
            try
            {
                var result = await _clienteService.BuscarClientCpfAsync(cpf);
                if(result != null)
                    return Ok(result);
                return BadRequest("CPF não encontrado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
