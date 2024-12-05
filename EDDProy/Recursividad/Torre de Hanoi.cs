using System.Text;

namespace EDDemo.Recursividad
{
    internal class Torre_de_Hanoi
    {
        public static string ResolverHanoi(int discos, char origen, char auxiliar, char destino, StringBuilder movimientos)
        {
            if (discos == 1)
            {
                movimientos.AppendLine($"Mover disco 1 de {origen} a {destino}");
            }
            else
            {
                ResolverHanoi(discos - 1, origen, destino, auxiliar, movimientos);
                movimientos.AppendLine($"Mover disco {discos} de {origen} a {destino}");
                ResolverHanoi(discos - 1, auxiliar, origen, destino, movimientos);
            }
            return movimientos.ToString();
        }
    }
}
