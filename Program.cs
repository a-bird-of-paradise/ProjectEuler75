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

        static void Main(string[] args)
        {
            int[] Fundamental = { 3, 4, 5 };

            int[,] A = { { -1, 2, 2 }, { -2, 1, 2 }, { -2, 2, 3 } };
            int[,] B = { { 1, 2, 2 }, { 2, 1, 2 }, { 2, 2, 3 } };
            int[,] C = { { 1, -2, 2 }, { 2, -1, 2 }, { 2, -2, 3 } };

            int[] ans;
            ans = MV(A, Fundamental);
            Console.WriteLine(ans[0] + " " + ans[1] + " " + ans[2]);
            ans = MV(B, Fundamental);
            Console.WriteLine(ans[0] + " " + ans[1] + " " + ans[2]);
            ans = MV(C, Fundamental);
            Console.WriteLine(ans[0] + " " + ans[1] + " " + ans[2]);
        }
    }
}
