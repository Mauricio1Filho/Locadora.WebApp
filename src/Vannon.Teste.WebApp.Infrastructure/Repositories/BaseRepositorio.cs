using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Infrastructure.Contexts;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
{
    public class BaseRepositorio
    {
        private MainContext MainContext;

        public BaseRepositorio(MainContext mainContext)
        {
            MainContext = mainContext;
        }

        public async Task<ClienteModel> BuscarClientAsync(long idCliente)
        {
            return await MainContext.Set<ClienteModel>().FindAsync(idCliente);
        }

        public async Task<bool> RemoverClientAsync(long idCliente)
        {
            MainContext.Remove(idCliente);
            await MainContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AtualizarClientAsync(ClienteModel clienteModel)
        {
            MainContext.Set<ClienteModel>().Update(clienteModel);
            await MainContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CadastrarClientAsync(ClienteModel clienteModel)
        {
            MainContext.Set<ClienteModel>().Add(clienteModel);
            await MainContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ReservarFilmeAsync(long idFilme, long idUsuario)
        {
            MainContext.Set<ReservaModel>().AddAsync(idFilme, idUsuario);
            await MainContext.SaveChangesAsync();
            return true;
        }

        Task<bool> RemoverReservaAsync(long idReserva);
    }
}
