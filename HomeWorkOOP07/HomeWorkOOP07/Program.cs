namespace HomeWorkOOP07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero lion = new Lion("Lion", 25, 50, 100);
            lion.Display();
            lion.Run();
            Console.WriteLine();
            Hero murlock = new Murlock("Murlock", 20, 50, 80);
            murlock.Display();
            murlock.Run();
            murlock.Attack();
            
        }
    }
}