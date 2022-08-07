using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Infrastructure.Contexts;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.WebApp.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly MainContext _mainContext;

        public ClienteRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public bool AtualizarClient(ClienteModel clienteModel)
        {
            Task.FromResult(_mainContext.Clientes.Update(clienteModel));
            return true;
        }

        public ClienteModel BuscarClient(long idCliente)
        {
            return _mainContext.Clientes.FirstOrDefault(o => o.IdCliente == idCliente);
        }

        public ClienteModel BuscarClientCpf(string cpf)
        {
            var data = _mainContext.Clientes
                .Join(
                 _mainContext.Contatos,
                 cliente => cliente.IdCliente,
                 contato => contato.Cliente.ClienteIdContato,
                (cliente, contato) => new { cliente, contato })
                .Join(
                 _mainContext.Enderecos,
                 o => o.cliente.ClienteIdEndereco,
                 endereco => endereco.IdEndereco,
                (cliente, endereco) => new { cliente, endereco })
                .Where(r => r.cliente.cliente.Cpf == cpf)
                .Select(z => new ClienteModel
                {
                    IdCliente = z.cliente.cliente.IdCliente,
                    Nome = z.cliente.cliente.Nome,
                    Contato = new ContactModel 
                    {
                        Email = z.cliente.contato.Email,
                        Celular = z.cliente.contato.Celular                    
                    },
                    Endereco = new AddressModel 
                    {
                        Endereco = z.endereco.Endereco,
                        Cidade = z.endereco.Cidade,
                        Bairro = z.endereco.Bairro,
                        CEP = z.endereco.CEP,
                        Numero = z.endereco.Numero
                    }
                }).FirstOrDefault();
            return data;
        }

        public bool CadastrarClient(ClienteModel clienteModel)
        {
            _mainContext.Clientes.Add(clienteModel);
            _mainContext.SaveChanges();
            return true;
        }

        public bool RemoverClient(long idCliente)
        {
            var result = _mainContext.Clientes.Find(idCliente);
            _mainContext.Remove(result);
            return true;
        }
    }
}
