using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystals = 0;
            int price = 7;

            Console.WriteLine("Скажите, сколько у вас есть золота?");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы можете купить " + (gold / price) + " кристаллов");
            
            while(crystals == 0)
            {
                int crystalsAmount = Convert.ToInt32(Console.ReadLine());
                if(crystalsAmount*price>gold)
                {
                    Console.WriteLine("У вас недостаточно денег. Выберите меньшее количество кристаллов.");
                }
                else
                {
                    crystals = crystalsAmount;
                    gold = gold - (price* crystalsAmount);
                }
            }

            Console.WriteLine("Gold = " + gold + "\ncrystals = " + crystals);
            Console.ReadKey();
        }
    }
}
