namespace BusquedaSecuencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region vector de prueba
            int[] numeros = { 1, 2, 4, 5, 6, 9 };
            #endregion

            #region valor de prueba para busqueda
            //int busqueda = 2;
            int busqueda = 7;
            #endregion

            #region algoritmo de busqueda secuencial
            int idx = -1;

            int cantidad = 6;

            int n = 0;
            while( n<cantidad )
            {
                if (busqueda == numeros[n])
                {
                    idx = n;
                }
                n++;
            }
            #endregion

            #region resultado
            Console.WriteLine($"{idx}");
            #endregion
        }
    }
}
