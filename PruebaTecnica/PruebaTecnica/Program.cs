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

        static string Fibonacci(int[] serie)
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
        static string Pares(int[] serie)
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

            int[] vect = { 1, 1, 2, 3, 5, 8, 13 };

            Console.WriteLine(Fibonacci(vect));

            Console.WriteLine(Pares(vect));
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }
        
    }
}







