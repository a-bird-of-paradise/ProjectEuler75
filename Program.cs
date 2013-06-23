using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler75
{
    class Program
    {
        static int[] MV(int[,] M, int[] V)
        {
            int[] ans = new int[3];
            ans[0] = M[0, 0] * V[0] + M[0, 1] * V[1] + M[0, 2] * V[2];
            ans[1] = M[1, 0] * V[0] + M[1, 1] * V[1] + M[1, 2] * V[2];
            ans[2] = M[2, 0] * V[0] + M[2, 1] * V[1] + M[2, 2] * V[2];
            return ans;
        }

        static void MakeChildren(int Limit, int[] LengthArray, int[] Triple)
        {
            int[,] A = { { -1, 2, 2 }, { -2, 1, 2 }, { -2, 2, 3 } };
            int[,] B = { { 1, 2, 2 }, { 2, 1, 2 }, { 2, 2, 3 } };
            int[,] C = { { 1, -2, 2 }, { 2, -1, 2 }, { 2, -2, 3 } };

            int[] a = MV(A, Triple);

            if (a[0] + a[1] + a[2] <= Limit)
            {
                LengthArray[a[0] + a[1] + a[2]]++;
                MakeChildren(Limit, LengthArray, a);
            }

            a = MV(B, Triple);

            if (a[0] + a[1] + a[2] <= Limit)
            {
                LengthArray[a[0] + a[1] + a[2]]++;
                MakeChildren(Limit, LengthArray, a);
            }

            a = MV(C, Triple);

            if (a[0] + a[1] + a[2] <= Limit)
            {
                LengthArray[a[0] + a[1] + a[2]]++;
                MakeChildren(Limit, LengthArray, a);
            }
        }

        static void Main(string[] args)
        {
            const int Max = 1500000;
            int[] Lengths = new int[Max + 1];
            int[] WaysToMake = new int[Max + 1];
            int[] Fundamental = { 3, 4, 5 };
            Lengths[3 + 4 + 5] = 1;
            MakeChildren(Max, Lengths, Fundamental);
            int j;
            for (int i = 1; i <= Max; i++)
            {
                if (Lengths[i] == 0) continue;
                j = 1;
                while (j * i <= Max)
                {
                    WaysToMake[i * j]++;
                    j++;
                }
            }
            Console.WriteLine(WaysToMake.Where(x => x == 1).Count());
        }
    }
}
