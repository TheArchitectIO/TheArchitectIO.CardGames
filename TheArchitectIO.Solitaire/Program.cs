using System;
using Newtonsoft.Json;
using TheArchitectIO.Solitaire.Core.Basic;

namespace TheArchitectIO.Solitaire
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
