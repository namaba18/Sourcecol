using System;

namespace PruebaTecnica
{
    class Program
    {
        static void Cars(List<Car> cars)
        {
            IEnumerable<Car> element = from d in cars
                                       orderby d.Model
                                       where d.Model > 2017
                                       select d;

            foreach (Car car in element)
            {
                Console.WriteLine("Marca: " + car.Brand + "\tModelo " + car.Model + "\tColor: " + car.Color);
            }
        }

        static string Cadena(string cad)
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

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car() {Brand = "bmw", Model = 2013, Color ="Blanco"},
                new Car() {Brand = "bmw", Model = 2015, Color ="Blanco"},
                new Car() {Brand = "bmw", Model = 2021, Color ="Blanco"},
                new Car() {Brand = "bmw", Model = 2020, Color ="Blanco"}
            };

            Cars(cars);

            Console.WriteLine(Cadena("asdfjj"));

        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }
        
    }
}



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