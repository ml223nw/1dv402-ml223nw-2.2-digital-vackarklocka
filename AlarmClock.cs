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

    // Inkaplsade fält.
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


    // Konstruktorn kommer här.


    // Metoden TickTock kommer här.


    // Metoden ToString kommer här.