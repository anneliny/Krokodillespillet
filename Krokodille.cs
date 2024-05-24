
using System.Security.Cryptography.X509Certificates;

namespace KrokodilleSpillet
{
    internal class Krokodille
    {

        public static void Spillet()
        {
          
            int score = 0;

            while (score <= 10)
            {
                Random number1 = new Random();
                int randomNumber1 = number1.Next(0, 11);

                Random number2 = new Random();
                int randomNumber2 = number2.Next(0, 11);
                
                Console.WriteLine(randomNumber1 + " " + "_" + " " + randomNumber2);
                Console.WriteLine("Poeng:" + " " + score);


                var input = Console.ReadLine();


                if (input == "<" && randomNumber1 < randomNumber2)
                {
                    Console.WriteLine("Riktig, det siste tallet er størst");
                    score++;
                }
                else if (input == "=" && randomNumber1 == randomNumber2)
                {
                    Console.WriteLine("Riktig, tallene er de samme");
                    score++;

                }
                else if (input == ">" && randomNumber1 > randomNumber2)
                {
                    Console.WriteLine("Riktig, det første tallet er størst");
                    score++;
                }
                else 
                {
                    Console.Clear();
                    Spillet();
                }

            }
        }
        }


    }
