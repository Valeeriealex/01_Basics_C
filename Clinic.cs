using System;

namespace Tasks_IJunior._01_Basics
{
   internal class Clinic
   {

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
