using System;

namespace Distinct_occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            while (Exit == false)
            {

                Console.WriteLine("Enter the height of the martix: ");
                int h = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the width of the martix: ");
                int w = Convert.ToInt32(Console.ReadLine());

                char[,] puzzle = new char[h, w];
                Console.WriteLine("Enter the martix as a one string: ");

                for (int i = 0; i < h; ++i)
                {
                    for (int j = 0; j < w; ++j)
                    {
                        puzzle[i, j] = Convert.ToChar(Console.Read());
                    }
                }

                int TotalOcc = FindWords(puzzle, h, w);
                Console.WriteLine("Total occurrences is :-" + TotalOcc);

                string InPut = Console.ReadLine();
                if (InPut == "e")
                {
                    Exit = true;
                }
            }
        }

        public static int FindWords(char[,] puzzle,int h, int w)
        {
         
            int H = WordBulider.horizontalBulider(puzzle, h, w);
            int V = WordBulider.verticalBulider(puzzle, h, w);
            int D = WordBulider.diagonalBulider(puzzle, h, w);

            return H+V+D;
        }
    }
}
