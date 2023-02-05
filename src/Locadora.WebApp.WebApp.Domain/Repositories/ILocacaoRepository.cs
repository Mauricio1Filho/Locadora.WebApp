namespace Locadora.WebApp.Domain.Repositories
{
    public interface ILocacaoRepository
    {
        bool CriarLocacaoFilme(string cpf, int idFilme);
    }
}
