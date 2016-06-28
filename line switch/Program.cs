using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_switch
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("How many rows?");  //building the matrix
            string x = Console.ReadLine();
            int row = Convert.ToInt32(x);

            Console.WriteLine("How many columns?");
            string x2 = Console.ReadLine();
            int column = Convert.ToInt32(x2);

            string[,] wordBox = new string[row, column];

            int totalSpace = row * column;
            Console.WriteLine("Enter in {0} charcters", totalSpace); //adding it it

            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < column; k++)
                {                    
                    wordBox[i, k] = Console.ReadLine();
                }
            }

            Console.WriteLine(Environment.NewLine);  

            for (int i = 0; i < row; i++)                   //prints out the original matrix
            {
                for (int k = 0; k < column; k++)
                {
                    Console.Write(wordBox[i, k]);                       
                }
                Console.WriteLine(Environment.NewLine);            
            }

            for (int i = 0; i < column; i++)   //switch the matrix
            {
                for (int k = 0; k < row; k++)
                {
                    Console.Write(wordBox[k, i]);
                }
                Console.WriteLine(Environment.NewLine);
            }

                Console.ReadKey();
        }
    }
}
