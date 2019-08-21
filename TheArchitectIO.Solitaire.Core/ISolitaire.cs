using System;
using System.Threading.Tasks;

namespace TheArchitectIO.Solitaire.Core
{
    public interface ISolitaire<TResponse>
    {
        Task PlayAsync();
        void Play();
        TResponse Status();
        Task<TResponse> StatusAsync();
    }
}
