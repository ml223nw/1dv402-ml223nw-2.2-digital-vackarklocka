using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
        public class AlarmClock
        {
        // Fält.
            private int _alarmHour;
            private int _alarmMinute;
            private int _hour;
            private int _minute;
        }

        // Klockans egenskaper valideras.
        public int AlarmHour
        {
            get { return _alarmHour; }
            set
            {
                    if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                else {_alarmHour = value;}
            }

        }


        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                    if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                else {_alarmMinute = value;}
            }

        }

        public int Hour
        {
            get { return _hour; }
            set
            {
                    if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                else {_hour = value;}
            }

        }

        public int Minute
        {
            get { return _minute; }
            set
            {
                    if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                else {_minute = value;}
            }

        }

        // Konstruktorer. Ser till att AlarmClock-objekt blir korrekt initierat.
        public AlarmClock() :this(0, 0)
        {
        
        }

        public AlarmClock (int hour, int minute) :this(Hour, Minute, 0, 0)
        {

        }

        public AlarmClock(int hour, int minute , int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        // Metoden TickTock. Anropas för att få klockan att gå en minut.
        public bool TickTock()
        {
            if (Minute < 59)
            {

                Minute = 0;
                Hour++;
            
            if (Hour > 23)
            {

                Hour = 0;
            }

        }
        // Kontrollerar om den nya tiden överensstämmer med alarmtiden.
            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Metoden ToString kommer här.