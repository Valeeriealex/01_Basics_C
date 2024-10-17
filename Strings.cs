using System;

namespace Tasks_IJunior._01_Basics
{
   internal class Strings
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Как Вас зовут?");
           string name = Console.ReadLine();
           Console.WriteLine("Сколько Вам лет?");
           string age = Console.ReadLine();
           Console.WriteLine("Какой у вас знак зодиака?");
           string sign = Console.ReadLine();
           Console.WriteLine("Где вы работаете?");
           string work = Console.ReadLine();
           Console.WriteLine($"Вас зовут {name}, вам {age} лет, вы {sign}, вы работаете {work}");
       }
   }
}
