namespace MoneyCalculator;

class Program
{
    static int _hourlyCost = 0; 
    
    static void Main(string[] args)
    {
        Console.WriteLine("What is the cost each hour?");
        TestConversion();
    }

    static void TestConversion()
    {
        var MaxEntries = 3;
        while (true)
        {
            try
            {
                _hourlyCost = Int32.Parse(Console.ReadLine());
                Console.WriteLine(_hourlyCost);
            }
            catch
            {
                
            }   
        }
    }
}