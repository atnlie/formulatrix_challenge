namespace Fomulatrix
{
    class App_Coding_Competency
    {
        static void Main()
        {
            NumberGenerator myGenerator = new NumberGenerator();

            // rules
            myGenerator.AddRule(3, "foo");
            myGenerator.AddRule(4, "baz");
            myGenerator.AddRule(5, "bar");
            myGenerator.AddRule(7, "jazz");
            myGenerator.AddRule(9, "huzz");


            Console.Write("Enter a value for n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                //NumberPrinter.PrintNumbers(n); // deprecated
                myGenerator.GenerateNumbers(n);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

}