﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_IJunior._01_Basics
{
   internal class Images
   {
       //Картинки
       //На экране, в специальной зоне, выводятся картинки, по 3 в ряд (условно, ничего рисовать не надо).
       //Всего у пользователя в альбоме 52 картинки. Код должен вывести, сколько полностью заполненных рядов
       //можно будет вывести, и сколько картинок будет сверх меры. 

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
