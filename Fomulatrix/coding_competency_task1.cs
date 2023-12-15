using System;

class NumberPrinter
{
    public static void PrintNumbers(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            RuleProcessor processor = new RuleProcessor();

            processor.AddRule(new DivisibilityRule(3, "foo"));
            processor.AddRule(new DivisibilityRule(5, "bar"));

            // Process the rules for the current number
            string result = processor.ProcessRules(i);

            // Print the result
            Console.Write(result);

            // Add a comma and space for separation, except for the last number
            if (i < n)
            {
                Console.Write(", ");
            }
        }
    }
}

class RuleProcessor
{
    private readonly List<IRule> rules = new List<IRule>();

    public void AddRule(IRule rule)
    {
        rules.Add(rule);
    }

    public string ProcessRules(int number)
    {
        string result = string.Empty;

        foreach (var rule in rules)
        {
            if (rule.IsSatisfied(number))
            {
                result += rule.GetOutput();
            }
        }

        // If no rule is satisfied, print the number itself
        if (string.IsNullOrEmpty(result))
        {
            result = number.ToString();
        }

        return result;
    }
}

interface IRule
{
    bool IsSatisfied(int number);
    string GetOutput();
}

class DivisibilityRule : IRule
{
    private readonly int divisor;
    private readonly string output;

    public DivisibilityRule(int divisor, string output)
    {
        this.divisor = divisor;
        this.output = output;
    }

    public bool IsSatisfied(int number)
    {
        return number % divisor == 0;
    }

    public string GetOutput()
    {
        return output;
    }
}

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
