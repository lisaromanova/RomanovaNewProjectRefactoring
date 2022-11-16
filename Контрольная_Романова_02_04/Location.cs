using System;
using System.Collections.Generic;
using System.Text;

namespace Контрольная_Романова_02_04
{
    interface Location
    {
        void Show();
        int CountShop();
        void CountHospital();
    }

    class City : Location
    {
        /// <summary>
        /// Название города
        /// </summary>
        private string _city;
        /// <summary>
        /// Количество магазинов в одном районе
        /// </summary>
        public int Amount;
        /// <summary>
        /// Количество районов в городе
        /// </summary>
        public int Area;
        /// <summary>
        /// Количество детских больниц в районе
        /// </summary>
        public int Child;
        /// <summary>
        /// Количество взрослых больниц в районе
        /// </summary>
        public int Adult;

        public City(string city)
        {
            _city = city;
        }
        /// <summary>
        /// Вывод города в котором живете
        /// </summary>
        public virtual void Show() 
        {
            Console.WriteLine("Вы живете в городе " + _city);
        }
        /// <summary>
        /// Подсчет количества магазинов в городе по количеству магазинов в одном районе
        /// </summary>
        /// <returns>Количество магазинов в городе</returns>
        public int CountShop() //
        {
            return Area * Amount;
        }
        /// <summary>
        /// Количество детских и взрослых больниц в городе
        /// </summary>
        public void CountHospital()
        {
            Console.WriteLine($"В городе {Child*Area} детских больниц и {Adult*Area} взрослых");
        }
    }

    class Village: City
    {
        /// <summary>
        /// Название деревни
        /// </summary>
        private string _village;
        /// <summary>
        /// Население деревни этого года
        /// </summary>
        public int ResidentsNew;
        /// <summary>
        /// Население деревни прошлого года
        /// </summary>
        public int ResidentsOld;

        public Village(string village, string city):base(city)
        {
            _village = village;
        }
        /// <summary>
        /// Вывод города и деревни обитания
        /// </summary>
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Вы живете в деревне "+ _village);
        }
        /// <summary>
        /// Вывод прибыли и убыли населения
        /// </summary>
        public void ShowPopulation()
        {
            if (ResidentsNew > ResidentsOld)
            {
                Console.WriteLine($"Прибыль населения на {ResidentsNew-ResidentsOld} человека");
            }
            else
            {
                if(ResidentsNew < ResidentsOld)
                {
                    Console.WriteLine($"Убыль населения на {ResidentsOld - ResidentsNew} человека");
                }
                else
                {
                    Console.WriteLine("Численность населения не изменилась");
                }
            }
            
        }
        /// <summary>
        /// Вывод количества больниц в деревне
        /// </summary>
        new public void CountHospital()
        {
            Console.WriteLine($"В деревне всего {Child + Adult} больниц");
        }
    }
}
