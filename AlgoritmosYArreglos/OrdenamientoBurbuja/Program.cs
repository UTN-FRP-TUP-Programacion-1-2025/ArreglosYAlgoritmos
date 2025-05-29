namespace OrdenamientoBurbuja
{
    internal class Program
    {
        static void Burbuja(int[] numeros, int inicio, int fin)
        {
            for (int act = inicio; act < fin; act++)
            {
                for (int sig = act+1; sig <= fin; sig++)
                {
                    if (numeros[sig] < numeros[act])
                    {
                        Intercambio(numeros, sig, act);
                    }
                }
            }
        }

        static void Intercambio(int[] numeros, int idxa, int idxb)
        {
            int tmp = numeros[idxa];
            numeros[idxa] = numeros[idxb];
            numeros[idxb] = tmp;
        }

        static void Main(string[] args)
        {
            #region vector de prueba
            int[] numeros = { 7, 4, 2, 2, 4, 5, 1, 6 };
            #endregion

            #region algoritmo de busqueda secuencial
            Burbuja(numeros, 0, 7);
            #endregion

            #region resultado
            for (int n = 0; n < 8; n++)
            {
                Console.Write($"{numeros[n],-3} ");
            }
            #endregion
        }
    }
}
