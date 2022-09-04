using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Exercise_01_Answers;
public class MotorcyclePart : Part
{
    public MotorcyclePart(int iD, string name, decimal price) : base(iD, name, price) // calling the base class's constructor
    {
        ID = iD;
        Name = name;
        Price = price;   
    }

    public override int ID { get; set; }
    public override string Name { get; set; }
    public override decimal Price { get; set; }

    public override void PrintPartInfo()
    {
        Console.WriteLine($"Part Name: {Name} " +
                          $"Part ID: {ID} " +
                          $"Part Price: {Price} ");
    }
}
