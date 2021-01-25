using System;
using System.Collections.Generic;
namespace test_unitaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     OO       OOOOOOO           O       O     OOOOOOO     OO    OO     OO   OO ");
            Console.WriteLine("     OO       OO   OO           OOO   OOO     OO   OO     OOO   OO     OO   OO ");
            Console.WriteLine("     OO       OO   OO           OOO   OOO     OO   OO     OOO   OO     OO   OO ");
            Console.WriteLine("     OO       OOOOOOO           OO  O  OO     OOOOOOO     OO OO OO     OO   OO ");
            Console.WriteLine("     OO       OO   OO           OO     OO     OO   OO     OO   OOO     OO   OO ");
            Console.WriteLine("     OO       OO   OO           OO     OO     OO   OO     OO    OO     OO   OO ");
            Console.WriteLine("     OOOOOOO  OO   OO           OO     OO     OO   OO     OO    OO     OOOOOOO ");
            Console.WriteLine("\r\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================================================================");
            Console.WriteLine("|                                BIENVENUE                                         |");
            Console.WriteLine("====================================================================================");
            Console.WriteLine("\r\n");

            Console.WriteLine("         Bonjour, vous allez participer à un quiz portant sur le langage C#,\r\n " +
                "                       Il comporte 10 questions. \r\n" +
                "           A chaque questions vous aurez le choix entre 4 réponses.\r\n" +
                "                                          \r\n" +
                "\r\n" +
                "                                 ...Bonne CHANCE...");
            int score = 0;
            int Nbquestion = 0;

            List<string> QuestionContent = new List<string>()
             {
                "Question 1 : En quelle année C# est apparue ?\r\n 1/1961 2/1981 3/2001 4/2021",
                "Question 2 : Parmi ces langages lequel en est le dérivé ?\r\n 1/PHP 2/LUA 3/C 4/PYTHON",
                "Question 3 : Avec quel type de données peut-on crée une variable contenant du texte ?\r\n 1/myString 2/string 3/str 4/Txt",
                "Question 4 : Comment créer une variable numérique avec une valeur de 5 ?\r\n 1/x = 5 2/num x = 5 3/int X = 5 4/double x = 5",
                "Question 5 : Qu'est-ce qu'un nombre à virgule ?\r\n 1/un double 2/un float 3/un string 4/un bool",
                "Question 6 : Sur quelles versions travaillons nous actuellement ?\r\n 1/1.1 2/3.5 3/7.0 4/9.0",
                "Question 7 : Qu'est-ce qu'un enum\r\n 1/un ensemble de constante 2/un ensemble de variable 3/un e numéro 4/toi non plus tu ne sais pas !",
                "Question 8 : Le dogecoin est-il fait en C# ?\r\n 1/oui 2/non 3/je donne ma langue au chat 4/Demander à Maxime",
                "Question 9 : Si mon client me demande de faire une boucle for pour afficher toutes les valeurs d'un tableau ?\r\n 1/for (initialisation; condition; incrementation) 2/for (condition; initialisation; incrementation) 3/for (initialisation; incrementation; condition) 4/for (incrementation; condition; initialisation)",
                "Question 10 : Qui a conçu C# ?\r\n 1/Moi 2/Toi 3/Bill Gates 4/Microsoft"
            };

            List<int> responseList = new List<int>()
            {
                3,3,2,3,2,4,1,1,2,3,4
            };

            if (Nbquestion <= QuestionContent.Count)
            {

                foreach (string Question in QuestionContent)
                {
                    Console.WriteLine(Question);

                    int responseUser = int.Parse(Console.ReadLine());

                    if (responseUser == responseList[Nbquestion])
                    {
                        Console.WriteLine("bonne reponse!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("mauvaise réponse ");
                    }

                    Nbquestion++;

                }
            }

            Console.WriteLine(" \r\n \r\n Vous avez eu: " + score + " bonne réponse ");
            if (score <= 3)
            {
                Console.WriteLine("Vous êtes très nul quand même");
            } else if (score > 3 && score <= 5)
            {
                Console.WriteLine("C'est pas grave, vous faites du C# depuis une semaine et demie !");
            } else  if (score > 5 && score <= 7)
            {
                Console.WriteLine("là on discute !");
            } else if (score > 7 && score <= 9)
            {
                Console.WriteLine("Félicitations vous êtes admis");
            } else if (score == 10)
            {
                Console.WriteLine("La base virale VPS a été mise à jour.");
            }
        }
    }
}