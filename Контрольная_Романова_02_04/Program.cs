using System;

namespace Контрольная_Романова_02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            City cityNew = new City(city);
            cityNew.Show();
            Console.WriteLine("Введите количество районов в городе");
            cityNew.Area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество магазинов в одном районе города");
            cityNew.Amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В городе {cityNew.CountShop()} магазинов 'Пятерочка'");
            Console.WriteLine("Введите количество детских больниц в районе города");
            cityNew.Child = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество взрослых больниц в районе города");
            cityNew.Adult = Convert.ToInt32(Console.ReadLine());
            cityNew.CountHospital();
            Console.WriteLine("Введите название деревни");
            string village = Console.ReadLine();
            Village villageNew = new Village(village, city);
            villageNew.Show();
            Console.WriteLine("Введите население деревни в этом году");
            villageNew.ResidentsNew = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите население деревни в прошлом году");
            villageNew.ResidentsOld = Convert.ToInt32(Console.ReadLine());
            villageNew.ShowPopulation();
            Console.WriteLine("Введите количество детских больниц в деревне");
            villageNew.Child = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество взрослых больниц города");
            villageNew.Adult = Convert.ToInt32(Console.ReadLine());
            villageNew.CountHospital();
        }
    }
}
