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
            
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }
        
    }
}

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