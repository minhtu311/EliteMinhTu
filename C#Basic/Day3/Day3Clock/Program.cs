namespace Day3Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoClock clock = new InfoClock();
            Register register = new Register();
            register.Subscribe(clock);
            clock.Start();
        }
    }
}
