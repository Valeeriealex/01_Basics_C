using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_IJunior._01_Basics
{
   internal class Rearrangement
   {

       static void Main(string[] args)
       {
           string firstName;
           string surName;

           firstName = "Фамилия";
           surName = "Имя";
           Console.WriteLine($"Ваши имя: {firstName} и фамилия: {surName}");

           string clipboard;

           clipboard = firstName;
           firstName = surName;
           surName = clipboard;
           Console.WriteLine($"Ваше имя: {firstName} и фамилия: {surName}");
       }
   }
}
