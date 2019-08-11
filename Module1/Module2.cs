using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Module2
    {
        static void Main(string[] args)
        {
            for (int column = 0; column < 8; column++)  // will create 8 row x 8 column pattern
            {
                for (int row = 0; row < 8; row++)
                {
                    if ((row + column) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else if ((row + column) % 2 == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("Neither X nor O");  // Built in unit test if logic for X and O fails
                    }
                }
                Console.WriteLine();
            }
        }

    }
}

   


