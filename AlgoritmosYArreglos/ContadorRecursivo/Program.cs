namespace ContadorRecursivo
{
    internal class Program
    {

        public static void ImprimirContador(int contador)
        {
            if (contador < 10) //condición de corte
            {
                Console.Write($"{contador,3} ");
                ImprimirContador(contador + 1);
            }
        }

        static void Main(string[] args)
        {
            //imprimir 1 2 3 4 5 6 7 8 9
            int contador = 0;
            ImprimirContador(contador);
        }
    }
}
