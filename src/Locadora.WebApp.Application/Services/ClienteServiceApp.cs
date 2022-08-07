using AutoMapper;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Services;
using Locadora.WebApp.ViewModel;

namespace Locadora.WebApp.Application.Services
{
    public class ClienteServiceApp
    {
        private readonly IMapper _mapper;

        private readonly ClienteService _clienteService;
        public ClienteServiceApp(ClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        public bool AtualizarClient(ClientViewModel clienteModel)
        {
            return _clienteService.AtualizarClient(_mapper.Map<ClienteModel>(clienteModel));
        }

        public ClientViewModel BuscarClient(long idCliente)
        {
            return _mapper.Map<ClientViewModel>(_clienteService.BuscarClient(idCliente));
        }

        public ClientViewModel BuscarClientCpf(string cpf)
        {
            return _mapper.Map<ClientViewModel>(_clienteService.BuscarClientCpf(cpf));
        }

        public bool CadastrarClient(ClientViewModel clienteModel)
        {
            return _clienteService.CadastrarClient(_mapper.Map<ClienteModel>(clienteModel));
        }

        public bool RemoverClient(long idCliente)
        {
            return _mapper.Map<bool>(_clienteService.RemoverClient(idCliente));
        }
    }
}
