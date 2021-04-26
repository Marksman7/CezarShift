using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Mark created this with help from
//THe atticle writen by Vikram Chaudhary · Categorized: C# · Tagged: Add, C#, concatenate, string (marked with 1 //1 location of where it helped
//Tiago Mussi Correct someone's mistake online of subtracting sting (marked with a //2 location of where it helped
namespace CezarShiftFinal1
{
    class Coder
    {
        private string[] Real = new string[31]
          {
                "?", ",", "!", ".", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " "
          };

        private string[] Fake = new string[31]
            {
                ",", "?", ".", "!", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "a", "b", "c", " "
            };

        public void Play()//I did this so You only see the creator's name once
        {
            Console.WriteLine("Created by that kid named Mark .P");
            Plays();
        }

        public void Plays()
        {
            
            Console.WriteLine("Type enter to make a messge into secret code and type ,uncode, to uncode something");
            string Choice = Console.ReadLine().ToLower();

            if (Choice == "uncode")
            {
                UnSecretCode();
            }
            else
            {
                SecretCode();
            }
            Console.WriteLine("");
            Plays();
            Console.ReadKey();
        }


        public void UnSecretCode()
        {
            Console.WriteLine("Type the secret you want uncoded");

            string Classified = Console.ReadLine().ToLower();
            Console.ReadKey();
            string Stuff = string.Concat(Classified + " ");
            var Next = "i";
            string Poop = "";

            for (int i = 0; i <= Classified.Length - 1; i++)
            {
                Next = Stuff.Remove(1);
                Stuff = Stuff.Remove(0, 1);//2
                for (int t = 0; t <= 30; t++)
                {
                    if (this.Fake[t] == Next)
                    {
                        Next = Next.Replace(this.Fake[t], this.Real[t]);
                        t = 100;

                    }


                }
                Poop = string.Concat(Poop + Next);//1


            }

            Console.WriteLine(Poop);
            Console.ReadKey();

        }

        public void SecretCode()//makes into secret code
        {
            Console.WriteLine("Type the secret you want coded");
            string Classified = Console.ReadLine().ToLower();
            Console.ReadKey();
            string Stuff = string.Concat(Classified + " ");
            var Next = "i";
            string Poop = "";

            for (int i = 0; i <= Classified.Length - 1; i++)
            {
                Next = Stuff.Remove(1);
                Stuff = Stuff.Remove(0, 1);//2
                for (int t = 0; t <= 30; t++)
                {
                    if (this.Real[t] == Next)
                    {
                        Next = Next.Replace(this.Real[t], this.Fake[t]);
                        t = 100;

                    }


                }
                Poop = string.Concat(Poop + Next);//1


            }

            Console.WriteLine(Poop);
            Console.ReadKey();

        }
    }
}
