namespace Locadora.WebApp.Domain.Interfaces
{
    public interface ILocacaoService
    {
        bool CriarLocacaoFilme(string cpf, int idFilme);
    }
}
