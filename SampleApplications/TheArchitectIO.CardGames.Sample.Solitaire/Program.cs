using System;
using Newtonsoft.Json;
using TheArchitectIO.CardGames.Core.Solitaire.Basic;

namespace TheArchitectIO.CardGames.Sample.Solitaire
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicSolitaire solitaire = new BasicSolitaire();

            solitaire.Play();

            string output = JsonConvert.SerializeObject(solitaire.Status());

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
