namespace Abstract_Classes_Exercise_01_Answers;
public abstract class Part
{
    private static ulong _partCount;

    public Part(int iD, string name, decimal price)
    {
        ID = iD;
        Name = name;
        Price = price;
        _partCount++; // this is why we must call the base class constructor in each concrete class 
    }

    public abstract int ID { get; set; }
    public abstract string Name { get; set; }
    public abstract decimal Price { get; set; }

    public abstract void PrintPartInfo();
    public static void PrintTotalPartCount()
    {        
        Console.WriteLine($"TOTAL CREATED PARTS: {_partCount}");
    }
}
