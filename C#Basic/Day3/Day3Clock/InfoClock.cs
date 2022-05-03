using System;
using System.Threading;

public class InfoClock
{
    public event ClockHandler Clock;
    public EventArgs e = null;
    public delegate void ClockHandler(InfoClock c, EventArgs e);
    public void Start()
    {
        while (!Console.KeyAvailable)
        {
            Thread.Sleep(1000);
            if (Clock != null)
            {
                Clock(this, e);
            }
        }
    }
}