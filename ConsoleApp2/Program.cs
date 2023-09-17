using System;
using static ConsoleApp2.Address;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("12345", "Україна", "Київ", "Головна", "42", "10");

            Console.WriteLine("Індекс: " + address.Index);
            Console.WriteLine("Країна: " + address.Country);
            Console.WriteLine("Місто: " + address.City);
            Console.WriteLine("Вулиця: " + address.Street);
            Console.WriteLine("Будинок: " + address.House);
            Console.WriteLine("Квартира: " + address.Apartment);

            Console.ReadKey();
        }
    }
}
