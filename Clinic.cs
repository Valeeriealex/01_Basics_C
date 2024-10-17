using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_IJunior._01_Basics
{
   internal class Clinic
   {
       //Вы заходите в поликлинику и видите огромную очередь, вам нужно рассчитать время ожидания в очереди.  

       static void Main(string[] args)
       {
           int numberPeopleInLine;
           int timeForOnePatient;
           int waitingTime;
           int minutesInHour;
           int hoursOfWaiting;
           int minutesOfWaiting;

           timeForOnePatient = 10;
           minutesInHour = 60;

           Console.WriteLine($"Вы пришли в поликлинику. Время приема одного человека - {timeForOnePatient} минут. Сколько людей перед Вами?");
           numberPeopleInLine = Convert.ToInt32(Console.ReadLine());
//            waitingTime = numberPeopleInLine * timeForOnePatient;
//            hoursOfWaiting = waitingTime / minutesInHour;
//            minutesOfWaiting = waitingTime % minutesInHour;
//            Console.WriteLine($"Время Вашего ожидания в очереди {hoursOfWaiting} часа {minutesOfWaiting} минут.");
//        }
//    }
//}
