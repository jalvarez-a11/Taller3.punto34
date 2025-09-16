using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixExample
{
    public class HourglassMatrix : Matrix
    {
        public HourglassMatrix(int n) : base(n) { }

        
        public override void Fill()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Data[i, j] = i + j;   
                }
            }
        }

        
        public void PrintHourglass()
        {
            int mid = N / 2;

            Console.WriteLine("\nRELOJ DE ARENA\n");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    
                    bool topPart = (i <= mid) && (j >= i) && (j < N - i);
                    bool bottomPart = (i >= mid) && (j >= N - i - 1) && (j <= i);

                    if (topPart || bottomPart)
                    {
                        Console.Write($"{Data[i, j],4}");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


