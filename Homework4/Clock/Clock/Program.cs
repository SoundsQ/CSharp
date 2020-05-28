using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int alarmTime;
            Console.WriteLine("set your alarmtime.");
            alarmTime=int.Parse(Console.ReadLine());
            Alarm alarm = new Alarm();
            alarm.c.AlarmTime = alarmTime;


            alarm.c.GoTime();
        }
    }
}
