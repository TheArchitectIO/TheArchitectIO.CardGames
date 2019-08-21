using System.Threading.Tasks;

namespace TheArchitectIO.CardGames.Core.Solitaire
{
    public interface ISolitaire<TResponse>
    {
        Task PlayAsync();
        void Play();
        TResponse Status();
        Task<TResponse> StatusAsync();
    }
}
