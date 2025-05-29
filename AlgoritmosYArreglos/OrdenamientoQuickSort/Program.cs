namespace OrdenamientoQuickSort
{
    internal class Program
    {
        static void QuickSort(int[] numeros, int inicio, int fin)
        {
            int referencia = numeros[inicio];

            int izq=inicio+1;
            int der=fin;

            //ordena de tal forma que queden los menos al pivote a la izq, y los mayores a la der
            while (izq>der==false)
            {
                while (izq<=fin && referencia > numeros[izq]) izq++;
                while (der>inicio && referencia <= numeros[der]) der--;
                if (izq < der)
                    Intercambio(numeros, izq, der);
            }
            int idxPivote = der;
            Intercambio(numeros, inicio, idxPivote);

            if (idxPivote-1>inicio)
                QuickSort(numeros, inicio, idxPivote-1);
            if (idxPivote + 1 < fin)
                QuickSort(numeros, idxPivote + 1, fin);
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
            QuickSort(numeros, 0, 7);
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
