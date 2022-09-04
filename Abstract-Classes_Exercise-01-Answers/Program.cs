// TODO: Create an abstract class called Part 
// TODO:  Inside of the abstract Part class, Create 3 abstract properties called ID, Name, and Price 
// TODO:  Inside of the abstract Part class, Create 1 abstract void method called PrintPartInfo() 
// TODO:  Inside of the abstract Part class, Create 1 private static field of type ulong called _partCount;
// TODO:  Inside of the abstract Part class, Create 1 parameterized constructor foreach of the 4 properties and also increment the _partCount field
// BONUS: Inside of the abstract Part class, Create 1 static void method called PrintTotalPartCount() 

// TODO: Create 3 concrete classes that inherit from the abstract Part class
// TODO: Implement the abstract class and add any extra functionality to your concrete class

// TODO: Instantiate all 3 concrete classes and give their members values 

// TODO: Creat a list of type Part and add the instances to the list

// TODO: Using a loop, execute each part's method Console.WriteLine() the result if the method isn't void

AddSpaces(1);

// Bonus: Call the PrintTotalPartCount() method

void AddSpaces(int numberOfSpaces)
{
	while (numberOfSpaces > 0)
	{
		Console.WriteLine();
		numberOfSpaces--;
	}
}