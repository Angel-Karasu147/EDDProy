using System;

namespace EDDemo.Recursividad
{
    public static class Calculadora
    {
        public static (int resultado, TimeSpan tiempo) Sumar(int valor1, int valor2)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            int resultado = valor1 + valor2;

            stopwatch.Stop();
            TimeSpan tiempo = stopwatch.Elapsed;

            return (resultado, tiempo);
        }
    }
}
