using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CardShuffle;

namespace CardShuffle
{
    class Program
    {
        

        public static int Num_Cards { get; private set; }

        public const int CardNum = 52;
        static void Main(string[] args)
        {
            

                Console.WriteLine("Enter the shuffle Riffle(1) FisherYates(2) NoShuffle(3) would you like to use:");

            


                if (ShuffleType == 1)
                {
                    return FisherYates();
                }
                if (ShuffleType == 2)
                {
                    return Riffle();
                }

                if (ShuffleType == 3)
                {
                    return NoShuffle();
                }

                Console.WriteLine("You have selected " + ShuffleType);



            }
        }
    } 
}