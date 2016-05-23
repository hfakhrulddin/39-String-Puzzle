using System;

namespace Distinct_occurrences
{
    public class WordBulider
    {
        public static int totalHoccurrences;
        public static string HWordStr;
        public static string HWordStrR = null;
        public static char[] HWordStrA = null;

        public static int horizontalBulider(char[,] puzzle, int h, int w)
        {
            totalHoccurrences = 0;
            HWordStr = null;

            for (int z = 0; z < h; z++)
            {
                for (int x = 0; x < w; x++)
                {
                    for (int l = x; l < w; l++)
                    {
                        HWordStr = HWordStr + (puzzle[z, l]).ToString();
                        HWordStrA = HWordStr.ToCharArray();
                        Array.Reverse(HWordStrA);
                        HWordStrR = String.Join("",HWordStrA);

                        if (PuzzleSolver.IsWord(HWordStr) == true)
                        { totalHoccurrences += 1; }

                        else if (PuzzleSolver.IsWord(HWordStrR) == true && (HWordStr != HWordStrR))
                        { totalHoccurrences += 1; }
                    }
                    HWordStr = null;
                }
            }
           return totalHoccurrences;
        }

        public static int verticalBulider(char[,] puzzle, int h, int w)
        {
            totalHoccurrences = 0;
            HWordStr = null;
            for (int z = 0; z < w; z++)
            {
                for (int x = 0; x < h; x++)
                {
                    for (int l = x; l < h; l++)
                    {

                        HWordStr = HWordStr + (puzzle[l, z]).ToString();
                        if (HWordStr.Length == 1) { continue; }
                        HWordStrA = HWordStr.ToCharArray();
                        Array.Reverse(HWordStrA);
                        HWordStrR = String.Join("", HWordStrA);

                        if (PuzzleSolver.IsWord(HWordStr) == true)
                        { totalHoccurrences += 1; }

                        else if (PuzzleSolver.IsWord(HWordStrR) == true && (HWordStr != HWordStrR))
                        { totalHoccurrences += 1; }
                    }
                    HWordStr = null;
                }
            }
            return totalHoccurrences;
        }

        public static int diagonalBulider(char[,] puzzle, int h, int w)
        {
            totalHoccurrences = 0;
            HWordStr = null;
            int zr = 0;
            int lr = 0;

            for (int z = 0; z < h; z++)
            {
                for (int x = 0; x < w; x++)
                {
                    for (int l = x; l < w - z; l++)
                    {
                        if (z + zr >= h) { continue; };
                        if ((z == 0 || l == 0) && (lr == 0)) { HWordStr = HWordStr + (puzzle[z, l]).ToString(); }
                        else { HWordStr = HWordStr + (puzzle[z + zr, l]).ToString(); }
                        if (HWordStr.Length == 1)
                        {
                            zr++;
                            lr++;
                            continue;
                        }
                        HWordStrA = HWordStr.ToCharArray();
                        Array.Reverse(HWordStrA);
                        HWordStrR = String.Join("", HWordStrA);

                        if (PuzzleSolver.IsWord(HWordStr) == true)
                        { totalHoccurrences += 1; }

                        else if (PuzzleSolver.IsWord(HWordStrR) == true && (HWordStr != HWordStrR))
                        { totalHoccurrences += 1; }
                        zr++;
                        lr++;
                    }
                    zr = 0;
                    HWordStr = null;
                }
                zr = lr = 0;
            }
            return totalHoccurrences;
        }


    }
}
