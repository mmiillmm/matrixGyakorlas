using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixGyakorlas
{
    class Program
    {

        static void Main(string[] args)
        {
            int matrixMeret;

            Console.WriteLine("Kérem adja meg a mátrix méretét(Pl.: 3 -> 3x3)");
            matrixMeret = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A mátrix mérete: {matrixMeret} x {matrixMeret}");

            Random valt = new Random();

            int[,] matrix = new int[matrixMeret, matrixMeret];

            matrixFeltoltes(matrix, valt, matrixMeret);

            Console.WriteLine();

            matrixKiir(matrix, matrixMeret);

            Console.WriteLine();

            matrixKoz(matrix);

            Console.WriteLine();

            Console.ReadLine();
        }

        private static void matrixKoz(int[,] matrix)
        {
            int hossz0 = matrix.GetLength(0);
            int hossz1 = matrix.GetLength(1);

            int koz = matrix[hossz0 / 2, hossz1 / 2];

            Console.WriteLine(koz);
        }

        private static void matrixKiir(int[,] matrix, int matrixMeret)
        {
            for (int sor = 0; sor < matrixMeret; sor++)
            {
                for (int oszlop = 0; oszlop < matrixMeret; oszlop++)
                {
                    Console.Write($"{matrix[sor, oszlop], 3}");
                }
                Console.WriteLine();
            }
        }

        private static void matrixFeltoltes(int[,] matrix, Random valt, int matrixMeret )
        {
            for (int sor = 0; sor < matrixMeret; sor++)
            {
                for (int oszlop = 0; oszlop < matrixMeret; oszlop++)
                {
                    matrix[oszlop, sor] = valt.Next(20);
                }
            }
        }
    }
}
