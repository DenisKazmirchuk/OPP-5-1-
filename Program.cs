class Program
{
    static void Main(string[] args)
    {
        IWorker robitnyk = new Robitnyk("Іван", 5, 100);
        IWorker inzhener = new Inzhener("Олександр", 10, 3000);

        Console.WriteLine($"{robitnyk.Role()} {robitnyk.Zarplata()}");
        Console.WriteLine($"{inzhener.Role()} {inzhener.Zarplata()}");
    }
}
