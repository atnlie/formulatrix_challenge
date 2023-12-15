namespace Fomulatrix
{
    class App_Coding_Competency
    {
        static void Main()
        {
            Console.Write("Enter a value for n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                NumberPrinter.PrintNumbers(n);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

}