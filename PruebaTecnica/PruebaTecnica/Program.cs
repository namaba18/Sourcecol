Console.WriteLine(Cadena("asdfjj"));

string Cadena(string cad)
{
    string cad2 = "";
    if (cad.Length <= 20)
    {
        for (int i = 0; i < cad.Length; i++)
        {
            cad2 += cad[i];
        }
    }
    else
    {
        for (int i = 0; i < 20; i++)
        {
            cad2 += cad[i];
        }
        cad2 += "...";
    }
    return cad2;
}