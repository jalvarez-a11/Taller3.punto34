using System;

namespace MatrixExample
{
    public abstract class Matrix
    {
        public int N { get; protected set; }
        public int[,] Data { get; protected set; }

        protected Matrix(int n)
        {
            if (n <= 0) throw new ArgumentException("N debe ser positivo.");
            // Si quieres forzar impar: if (n % 2 == 0) n++;
            N = n;
            Data = new int[N, N];
        }

        // Cada subclase define cómo se llena la matriz
        public abstract void Fill();

        // Mostrar matriz completa
        public virtual void Print()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{Data[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}

