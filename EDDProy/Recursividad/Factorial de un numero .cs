using System;

namespace EDDemo.Recursividad
{
    internal class Factorialcal
    {
        /// <summary>
        /// Calcula el factorial de un número dado de forma recursiva.
        /// </summary>
        /// <param name="numero">Número para calcular el factorial.</param>
        /// <returns>El factorial del número.</returns>
        /// <exception cref="ArgumentException">Si el número es menor que 0.</exception>
        public static long Calcular(int numero)
        {
            if (numero < 0)
                throw new ArgumentException("El número debe ser mayor o igual a 0.");

            if (numero == 0 || numero == 1)
                return 1;

            return numero * Calcular(numero - 1);
        }
    }
}
