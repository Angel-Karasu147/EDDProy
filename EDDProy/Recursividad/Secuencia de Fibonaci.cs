using System;

namespace EDDemo.Recursividad
{
    internal class fibo
    {
        public static long CalcularFibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentException("El número debe ser mayor o igual a 0.");
            if (n == 0) return 0;
            if (n == 1) return 1;

            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }

        public static long[] GenerarSecuencia(int n)
        {
            long[] secuencia = new long[n];
            for (int i = 0; i < n; i++)
            {
                secuencia[i] = CalcularFibonacci(i);
            }
            return secuencia;
        }
    }
}
