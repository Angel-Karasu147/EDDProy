using System;

namespace EDDemo.Recursividad
{
    internal class Calculo_de_exponente
    {
        public long CalcularExponente(int baseNum, int exponente)
        {
            if (exponente == 0)
                return 1; 
            return baseNum * CalcularExponente(baseNum, exponente - 1); 
        }
    }
}
