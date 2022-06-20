using System;
class Program
{
    static void Main(string[] args)
    {
        int nbAllumettes;
        Console.WriteLine("Hey ! Avec combien d'allumettes souhaites-tu jouer ?");
        nbAllumettes = int.Parse(Console.ReadLine());
        int nbAllumettesRestantes = nbAllumettes;
        Console.WriteLine(string.Concat(Enumerable.Repeat("|", nbAllumettes)));
        Console.Write('\n');
        while (nbAllumettesRestantes > 0)
        {
            int choixJoueur;
            Console.WriteLine("Okay, et maintenant entre 1, 2 ou 3 allumettes ?");
            choixJoueur = int.Parse(Console.ReadLine());
            if (choixJoueur > 0 && choixJoueur < 4 && choixJoueur <= nbAllumettesRestantes)
            {
                nbAllumettesRestantes -= choixJoueur;
                Console.WriteLine("Tu as retiré {0} allumette(s).", choixJoueur);
                Console.WriteLine(string.Concat(Enumerable.Repeat(" ", choixJoueur)));
                Console.WriteLine(string.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));
            }
            else
            {
                Console.WriteLine("Hey oh ! Tu dois choisir un nombre valide d'allumettes voyons ! (x");
                continue;
            }
            if (nbAllumettesRestantes == 0)
            {
                Console.WriteLine("Tu n'as plus d'allumettes ! :( GAME OVER");
                break;
            }
            int choixOrdinateur;
            if (nbAllumettesRestantes <= 4 && nbAllumettesRestantes > 1)
            {
                choixOrdinateur = nbAllumettesRestantes - 1;
                nbAllumettesRestantes -= choixOrdinateur;
                Console.WriteLine("L'ordinateur à retiré {0} allumette(s) !", choixOrdinateur);
                Console.WriteLine(string.Concat(Enumerable.Repeat(" ", choixOrdinateur)));
                Console.WriteLine(string.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));
            }
            else
            {
                if (nbAllumettesRestantes == 1)
                {
                    choixOrdinateur = 1;
                    nbAllumettesRestantes -= choixOrdinateur;
                    Console.WriteLine("L'ordinateur à retiré {0} allumette(s) !", choixOrdinateur);
                    Console.WriteLine(string.Concat(Enumerable.Repeat(" ", choixOrdinateur)));
                    Console.WriteLine(string.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));
                }
                if (nbAllumettesRestantes == 0)
                {
                    Console.WriteLine("Congrats ! L'ordinateur à retiré la dernière allumettes, tu as gagné !");
                    break;
                }
                Random rnd = new Random();
                choixOrdinateur = rnd.Next(1, 3);
                nbAllumettesRestantes -= choixOrdinateur;
                Console.WriteLine("L'ordinateur à retiré {0} allumette(s) !", choixOrdinateur);
                Console.WriteLine(string.Concat(Enumerable.Repeat(" ", choixOrdinateur)));
                Console.WriteLine(string.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));
            }

        }
    }
}