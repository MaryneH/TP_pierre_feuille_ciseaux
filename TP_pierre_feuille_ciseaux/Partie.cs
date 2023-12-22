using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_pierre_feuille_ciseaux
{
    public enum Signe
    {
        Pierre,
        Feuille,
        Ciseaux
    }

    public class Partie
    {
        private static readonly Random Random = new Random();

        public static Signe GetRandomSign()
        {
            Array values = Enum.GetValues(typeof(Signe));
            return (Signe)values.GetValue(Random.Next(values.Length));
        }

        public static string PlayRound(Signe joueurUn, Signe joueurDeux)
        {
            Console.WriteLine($"Le joueur 1 joue {joueurUn}");
            Console.WriteLine($"Je joueur 2 joue {joueurDeux}");

            if (joueurUn == joueurDeux)
                return "Egalité";

            if ((joueurUn == Signe.Pierre && joueurDeux == Signe.Ciseaux) ||
                (joueurUn == Signe.Feuille && joueurDeux == Signe.Pierre) ||
                (joueurUn == Signe.Ciseaux && joueurDeux == Signe.Feuille))
            {
                return "Le joueur 1 gagne";
            }

            return "Le joueur 2 gagne";
        }
    }

}
