using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_IJunior._01_Basics
{
   internal class Shop
   {
        
       static void Main(string[] args)
       {
           int goldInWallet;
           int priceOneCrystal;
           int crystalsToBuy;
           int remainderOfGold;

           priceOneCrystal = 100;

           Console.WriteLine($"Здравствуйте! Вы попали в магазин кристалов! У нас один кристалл стоит {priceOneCrystal} золотых монет. А сколько у Вас золота?");
           goldInWallet = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Хорошо! И сколько кристаллов Вы хотете купить?");
           crystalsToBuy = Convert.ToInt32(Console.ReadLine());
           remainderOfGold = goldInWallet - priceOneCrystal * crystalsToBuy;
           Console.WriteLine($"Отлично! Вы купили {crystalsToBuy} штуки кристаллов. У Вас осталось {remainderOfGold} золота.");
       }
   }
}
