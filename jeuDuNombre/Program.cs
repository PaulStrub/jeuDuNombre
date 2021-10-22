using System;

namespace jeuDuNombre
{
    class Program
    {



        static void lvlA() {
            Console.WriteLine("D'accord pour ce premier niveau tu devras deviner le bon nombre parmis 20 tu as 4 vies pour cela.\n Vas y donne moi ton numéro");
            Random rand = new Random();
            int Pv = 5;
            int min = 0;
            int max = 20;
            int win = rand.Next(min, max + 1);
            int te = 0;
            try
            {
                while (te != win && Pv != 0)
                {
                    Console.WriteLine("Points de vie restants" + Pv);
                    te = int.Parse(Console.ReadLine());
                    if (te < min && te >= max)
                    {
                        Console.WriteLine("Mais il est débile ou quoi... ENTRE 1 ET 20 CEST PAS DUR A COMPRENDRE");


                    }
                    else if (te > win)
                    {
                        Console.WriteLine("plus petit et ce sera parfait ! ma femme m'a toujours dis que cetait mieux avec une petite ya pas de honte");
                        Pv = Pv - 1;
                    }
                    else
                    {
                        Console.WriteLine("Plus grandddddd met lui de la soupe dans le gosier à ton nombre ! ");
                        Pv = Pv - 1;
                    }


                }
                if (te==win)
                {
                    Console.WriteLine("Bravo choubidouuu t'as gagné mais quel exploit dis donc on est tous très fier de toi");

                }
                else if (Pv == 0)
                {
                    Console.WriteLine("J'ai honte mais j'ai honte mais un oden ne serait pas un oden s'il n'était pas bouillit allé hop à la marmite " + win);
                }
                
            }
            catch
            {
                Console.WriteLine("ok sortez le moi d'ici ce gignole la c'est fou un amateur il sait pas écrire un nombre c'est insupportable caaaa");
            }


        }




        static void lvlB()
        {
            Console.WriteLine("D'accord pour ce second niveau tu devras deviner le bon nombre parmis 100 tu as 10 vies pour cela.\n Vas y donne moi ton numéro");
            Random rand = new Random();
            int Pv = 10;
            int min = 0;
            int max = 100;
            int win = rand.Next(min, max + 1);
            int te = 0;
            try
            {
                while (te != win && Pv != 0)
                {
                    Console.WriteLine("Points de vie restants" + Pv);
                    te = int.Parse(Console.ReadLine());
                    if (te < min && te >= max)
                    {
                        Console.WriteLine("Mais il est débile ou quoi... ENTRE 1 ET 100 CEST FOU DE RIEN COMPRENDRE A CE POINT LAAAAA");


                    }
                    else if (te > win)
                    {
                        Console.WriteLine("aller mon mignon tu te rapproche c'est bien encore un peu plus petit et ce sera bon");
                        Pv = Pv - 1;
                    }
                    else
                    {
                        Console.WriteLine("Il faut viser plus grand tu sais on arrive a rien sans viser le sommet regarde moi par exemple je me retrouve la a presenter une emission pas ouf avec ma vie pas ouf et un monospace pas ouf... ressaisis toi vite mon enfant je te le dis ");
                        Pv = Pv - 1;
                    }


                }
                if (te == win)
                {
                    Console.WriteLine("Bravo choubidouuu t'as gagné mais quel exploit dis donc on est tous très fier de toi");

                }
                else if (Pv == 0)
                {
                    Console.WriteLine("J'ai honte mais j'ai honte mais un oden ne serait pas un oden s'il n'était pas bouillit allé hop à la marmite " + win);
                }
            }
            catch
            {
                Console.WriteLine("ok sortez le moi d'ici ce gignole la c'est fou un amateur il sait pas écrire un nombre c'est insupportable caaaa");
            }

        }





        static void lvlC()
        {
            Console.WriteLine("D'accord pour cet ultime niveau tu devras deviner le bon nombre parmis 1 000 000 tu as 5 vies pour cela.\n Vas y donne moi ton numéro");
            Random rand = new Random();
            int Pv = 5;
            int min = 0;
            int max = 1000000;
            int win = rand.Next(min, max + 1);
            int te = 0;
            try
            {
                while (te != win && Pv != 0)
                {
                    Console.WriteLine("Points de vie restants" + Pv);
                    te = int.Parse(Console.ReadLine());
                    if (te < min && te >= max)
                    {
                        Console.WriteLine("Mais il est débile ou quoi... ENTRE 1 ET 1 000 000 ENFIN MERDE QUOI FAIS UN EFFORT C4EST PAS COMME SI TAVAIS PAS LE CHOIX DES NOMBRES YEN A UN PAQUET LA QUAND MEME");


                    }
                    else if (te > win)
                    {
                        Console.WriteLine("C'est fou comme tu persiste aller petit indice c'est en dessous ");
                        Pv = Pv - 1;
                    }
                    else
                    {
                        Console.WriteLine("Oulaaa t'es très loin du compte c'est au dessus de ce petit nombre tout nul laaa");
                        Pv = Pv - 1;
                    }
                }
                if (te == win)
                {
                    Console.WriteLine("Bravo choubidouuu t'as gagné mais quel exploit dis donc on est tous très fier de toi");

                }
                else if (Pv == 0)
                {
                    Console.WriteLine("J'ai honte mais j'ai honte mais un oden ne serait pas un oden s'il n'était pas bouillit allé hop à la marmite " + win);
                }
            }
            catch
            {
                Console.WriteLine("ok sortez le moi d'ici ce gignole la c'est fou un amateur il sait pas écrire un nombre c'est insupportable caaaa");
            }

    }
        static void Main(string[] args)
        {
            Console.WriteLine("heyyyy ! \n Bienvenue au juste prixxx aujourd'hui notre concurent se prénomeeeeee :");
            string name = Console.ReadLine();
            Console.WriteLine("OKAYYY " + name + " Aujourd'hui c'est ton premier passage dans le juste nombreeee, à la clé ce soir une banane et une paire de crocs !\n Mais si tu échoue ce soir brulé vif dans l'Oden ! Alors fais le bon choix quelle difficultée veux tu : 1 2 ou 3");
            try
            {
                int lvl = int.Parse(Console.ReadLine());
                while(lvl!=1 ^ lvl!=2 ^ lvl != 3)
                {
                    Console.WriteLine("essaye encore");
                    lvl = int.Parse(Console.ReadLine());
                }
                if (lvl == 1)
                {
                    lvlA();
                }
                else if (lvl == 2)
                {
                    lvlB();
                }
                else
                {
                    lvlC();
                }
                

            }
            catch
            {
                Console.WriteLine("bon il est (caca debile) 1 2 ou 3");
            }
        }
    }
}
