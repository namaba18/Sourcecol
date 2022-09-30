
int[] vect = { 1, 1, 2, 3, 6, 8, 10 };

Console.WriteLine(Pares(vect));

string Pares(int[] serie)
{
    List<int> pares = new List<int>();
    int[] arreglo;
    string text = "El arreglo de números pares ordenados de mayor a menor es: [";
    foreach (int i in serie)
    {
        if (i % 2 == 0)
        {
            pares.Add(i);
        }
    }
    arreglo = pares.ToArray();
    for (int i = 0; i < arreglo.Length; i++)
    {
        for (int j = i + 1; j < (arreglo.Length); j++)
        {
            if (arreglo[i] < arreglo[j])
            {
                int temp = arreglo[i];
                arreglo[i] = arreglo[j];
                arreglo[j] = temp;
            }
        }
    }
    for (int i = 0; i < arreglo.Length; i++)
    {
        text += arreglo[i];
        if (i < arreglo.Length - 1)
        {
            text += ", ";
        }
    }
    text += "] y tiene " + arreglo.Length + " elementos";

    return text;
}