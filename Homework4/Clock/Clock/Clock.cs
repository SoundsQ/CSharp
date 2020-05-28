using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace Clock
{
    public delegate void TickClock(Object sender,int time);
    public delegate void AlarmClock(Object sender, int alarmTime);
    class Clock
    {
        public int AlarmTime{ get; set; }
        public int Time { get; set; }
        public event TickClock onTick;
        public event AlarmClock onAlarm;

       public Clock(int t)
        {
            Time = t;
        }

        public void GoTime()
        {
            for (; Time >= 0; Time++)
            {
                if (Time == AlarmTime)
                {
                    AlarmWork();
                    break;
                }
                onTick(this,Time);
                Thread.Sleep(1000);
            }
        }

        public void AlarmWork()
        {
            onAlarm(this, AlarmTime);
        }
    }

    class Tick
    {

        public Clock c = new Clock(0);
        public Tick()
        {
            c.onTick += new TickClock(ticking);
        }
        public void ticking(Object sender, int time)
        {
            Console.WriteLine($"It is {DateTime.Now.ToString("T")}  Tick! It has gone {c.Time} seconds.");
        }
        
    }

    class Alarm:Tick
    {
        
        public Alarm ()
        {
            c.onAlarm += new AlarmClock(Alarming);
        }
        public void Alarming(Object sender, int time)
        {
            Console.WriteLine($"It is {DateTime.Now.ToString("T")}  Alarm! It has been {c.AlarmTime} seconds.");
        }

    }
}


