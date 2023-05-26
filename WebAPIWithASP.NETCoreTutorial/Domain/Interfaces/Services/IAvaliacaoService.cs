using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Models;

namespace ASP.NETCoreWebAPIwithUnitOfWork.Domain.Interfaces.Services
{
    public interface IAvaliacaoService
    { 


        Task<IEnumerable<Avaliacao>> GetAvaliacaos();
        Task<Avaliacao> GetAvaliacaoById(int id);
        Task AddAvaliacao(Avaliacao avaliacao);
        Task UpdateAvaliacao(Avaliacao avaliacao);
        Task DeleteAvaliacao(int id);
    }
}
