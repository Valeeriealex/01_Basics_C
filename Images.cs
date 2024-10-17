using System;

namespace Tasks_IJunior._01_Basics
{
   internal class Images
   {

       static void Main(string[] args)
       {
           int allPictures;
           int rowPictures;
           int allInRow;
           int extraPictures;

           allPictures = 53;
           rowPictures = 3;

           allInRow = allPictures / rowPictures;
           extraPictures = allPictures % rowPictures;

           Console.WriteLine($"Если в ряд может быть выведено {rowPictures} картинки, а всего их {allPictures}, то в одном ряду будет {allInRow} картинок.");
//            Console.WriteLine($"Лишними будет {extraPictures} картинки.");
//        }
//    }
//}
