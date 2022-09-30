int[] vect = { 1, 1, 2, 3, 5, 8, 13 };

Console.WriteLine(Fibonacci(vect));


string Fibonacci(int[] serie)
{
    string temp = "Cumple con la sucesión de Fibonacci";
    for (int i = 0; i < (serie.Length - 2); i++)
    {
        if (serie[i] != serie[i + 2] - serie[i + 1])
        {
            temp = "No cumple con la suceción de Fibonacci";
        }
    }

    return temp;
}