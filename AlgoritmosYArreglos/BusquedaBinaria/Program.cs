namespace BusquedaBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region vector de prueba
            int[] numeros = { 1, 2, 4, 5, 6, 9 };
            #endregion

            #region valor de prueba para busqueda
            int busqueda = 2;
            //int busqueda = 7;
            #endregion

            #region algoritmo de busqueda
            int idx = -1;

            int inicio = 0;
            int fin = 6;

            int medio = (fin + inicio) / 2;
            while (idx==-1 && medio>0 && medio<fin)
            {
                if (numeros[medio] == busqueda)
                {
                    idx = medio;
                }
                else if (busqueda < numeros[medio])
                {
                    fin = medio - 1;
                }
                else if (busqueda > numeros[medio])
                {
                    inicio = medio + 1;
                }

                medio = (fin + inicio) / 2;
            }
            #endregion

            #region resultado
            Console.WriteLine($"{idx}");
            #endregion
        }
    }
}
