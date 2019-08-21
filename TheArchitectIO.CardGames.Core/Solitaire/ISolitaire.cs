using System.Threading.Tasks;

namespace TheArchitectIO.CardGames.Core.Solitaire
{
    public interface ISolitaire<TResponse>
    {
        /// <summary>
        /// Plays this game instance asynchronous.
        /// </summary>
        /// <returns>Task.</returns>
        Task PlayAsync();

        /// <summary>
        /// Plays this game instance.
        /// </summary>
        void Play();

        /// <summary>
        /// Gets the game's status.
        /// </summary>
        /// <returns>TResponse.</returns>
        TResponse Status();

        /// <summary>
        /// Gets the game's status asynchronous.
        /// </summary>
        /// <returns>Task&lt;TResponse&gt;.</returns>
        Task<TResponse> StatusAsync();
    }
}
