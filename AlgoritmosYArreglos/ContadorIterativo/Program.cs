namespace ContadorIterativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprimir 1 2 3 4 5 6 7 8 9
            for (int contador = 0; contador < 10; contador++)
            {
                Console.Write($"{contador,3} ");
            }
        }
    }
}
