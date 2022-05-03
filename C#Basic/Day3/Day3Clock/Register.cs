using System;

public class Register
{
    public void Subscribe(InfoClock clock)
    {
        clock.Clock += new InfoClock.ClockHandler(GetTime);
    }

    private void GetTime(InfoClock clock, EventArgs e)
    {
        Console.WriteLine("Clock: " + DateTime.Now.ToString("H:mm:ss"));
    }
}