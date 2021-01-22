using System;
using System.Collections.Generic;
namespace En_prod
{
    class Program
    {
        static void Main(string[] args)
        {
            int q1 = 0;
            int q2 = 0;
            int q3 = 0;
            int q4 = 0;
            int q5 = 0;
            int q6 = 0;
            int q7 = 0;
            int q8 = 0;
            int q9 = 0;
            int q10 = 0;
            Console.WriteLine("Bienvenue sur le quizz (appuyez sur une lettre)");
            Console.WriteLine("Veuillez mettre votre nom et prénom ici (ou un pseudonyme)");
            string name = Console.ReadLine();
            Console.WriteLine("Bonjour, \r\n vous allez participer à un quiz portant sur le langage C#, \r\n Il comporte 10 questions. \r\n A chaque questions vous aurez le choix entre 4 réponses... \r\n 1 seul est correcte \r\n Bonne Chance..");
            // faire un décompte si on a le temps
            Console.WriteLine("Tapez 'GNEU' pour commencer");
            string gneu = Console.ReadLine();
            if (q1 == Convert.ToInt32("réponse"))
            {
                q1 = 1; 
            } else { 
                q1 = 0;
            } 
              if (q2 == Convert.ToInt32("réponse"))
                {
                q2 = 1;
            } else
            {
                q2 = 0;
            }
            if (q3 == Convert.ToInt32("réponse"))
            {
                q3 = 1;
            }
            else
            {
                q3 = 0;
            }
            if (q4 == Convert.ToInt32("réponse"))
            {
                q4 = 1;
            }
            else
            {
                q5 = 0;
                if (q5 == Convert.ToInt32("réponse"))
                {
                    q5 = 1;
                }
                else
                {
                    q5 = 0;
                }
            }
            if (q6 == Convert.ToInt32("réponse"))
            {
                q6 = 1;
            }
            else
            {
                q6 = 0;
            }
            if (q7 == Convert.ToInt32("réponse"))
            {
                q7 = 1;
            }
            else
            {
                q7 = 0;
            }
            if (q8 == Convert.ToInt32("réponse"))
            {
                q8 = 1;
            }
            else
            {
                q8 = 0;
            }
            if (q9 == Convert.ToInt32("réponse"))
            {
                q9 = 1;
            }
            else
            {
                q9 = 0;
            }
            if (q10 == Convert.ToInt32("réponse"))
            {
                q10 = 1;
            }
            else
            {
                q10 = 0;
            }
        
    //   int[] intAnswer = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
         string[,] answers = {
           { "Q1" , "bonne réponse" },
             { "Q2" , "bonne réponse" },
               {"Q3" , "bonne réponse" },
                {"Q4" , "bonne réponse" },
                {"Q5" , "bonne réponse"} ,
                { "Q6" , "bonne réponse" },
                {"Q7" , "bonne réponse" },
                {"Q8" , "bonne réponse" },
                {"Q9" , "bonne réponse"} ,
                {"Q10" , "bonne réponse" }
            };

            //foreach(int total in intAnswer)
            //{
               /*  Console.WriteLine(total);
                if(Convert.ToBoolean(total)  )
            }
          
            switch ()
                {
                    case "good":
                        Q1 == "";
                        break;
                    default:
                        Console.WriteLine("donner l'explication");
                        break;        
                }
            switch (Q2)
                {
                    case "good 2":

                        break;
                    default:
                        Console.WriteLine("donner l'explication");
                        break;

                }
                switch (Q3)
                {
                    case "good 3":

                        break;
                    default:
                        Console.WriteLine("donner l'explication");
                        break;

                }
                switch (Q4)
                {
                    case "good 4":

                        break;
                    default:
                        Console.WriteLine("donner l'explication");
                        break;

                }
                switch (Q5)
                {
                    case "good 5":

                        break;
                    default:
                        Console.WriteLine("donner l'explication");
                        break;

                }
                switch (Q6)
                {
                    case "good 6":

                        break;
                    default:
                        Console.WriteLine("donner l'explication");
                        break;

                }
                switch (Q7)
                {
                    case "good 7":

                        break;
                    default:
                        Console.WriteLine("donner l'explication");
                        break;

                }
                switch (Q8)
                {
                    case "good 8":

                        break;
                    default:
                        Console.WriteLine("donner l'explication");
                        break;

                }
                switch (Q9)
                {
                    case "good 9":

                        break;
                    default:
                        Console.WriteLine("donner l'explication");
                        break;

                }
                switch (Q10)
                {
                    case "good 10":

                        break;
                    default:
                        Console.WriteLine("donner l'explication");
                        break;

                }
                Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Qu'est-ce que enum ?");
            Console.WriteLine("Si mon client me demande de faire une boucle for pour afficher toutes les valeurs d'un tableau ?");
            Console.WriteLine("C# est un langage de :");
            Console.WriteLine("La place du c# c'est où ?");

            Console.WriteLine("Question 1"); 
            Console.WriteLine("En quelle année C# est apparue ?"); 
            Console.WriteLine("1961"); 
            Console.WriteLine("1981"); 
            Console.WriteLine("2001"); 
            Console.WriteLine("2021"); 
            Console.WriteLine("Parmi ces langages lequel en est le dérivé ?")
            Console.WriteLine("PHP"); 
            Console.WriteLine("C"); 
            Console.WriteLine("LUA"); 
            Console.WriteLine("PYTHON"); 
            Console.WriteLine("Avec quel type de données peut-on crée une variable contenant du texte ?"); 
            Console.WriteLine("myString"); 
            Console.WriteLine("string"); 
            Console.WriteLine("str"); 
            Console.WriteLine("Txt"); 
            Console.WriteLine("Comment créer une variable numérique avec une valeur de 5 ?"); 
            Console.WriteLine("x = 5"); 
            Console.WriteLine("num x = 5"); 
            Console.WriteLine("int X = 5"); 
            Console.WriteLine("double x = 5"); 
            Console.WriteLine("Comment créer un variable avec un nombre à virgule ?"); 
            Console.WriteLine("double x = 2.8D"); 
            Console.WriteLine("int x = 2.8"); 
            Console.WriteLine("int x = 2.8D"); */
        }
    }
}
    