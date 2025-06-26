namespace MoneyCalculator;

class Program
{
    static int _hourlyCost = 0; 
    
    static void Main(string[] args)
    {
        Conversion("What is the cost each hour? (kr):");
    }

    static void Conversion(string input)
    {
        int maxEntries = 3;
        int output = 0;

        while (maxEntries > 0)
        {
            Console.Write(input);
            string cost = Console.ReadLine();

            try
            {
                output = Int32.Parse(cost);
                break; // success, exit loop
            }
            catch
            {
                maxEntries--;
                Console.WriteLine($"Invalid input. {maxEntries} tries left.");
            }
        }

        if (maxEntries == 0)
        {
            Console.WriteLine("Too many invalid attempts. Exiting...");
            return;
        }

        Console.WriteLine($"You entered: {output}");
    }
}