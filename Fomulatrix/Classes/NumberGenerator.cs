namespace Fomulatrix
{
    public class NumberGenerator
    {
        private readonly List<IRule> rules = new List<IRule>();

        public void AddRule(int divisor, string output)
        {
            rules.Add(new DivisibilityRule(divisor, output));
        }

        public void GenerateNumbers(int n)
        {
            RuleProcessor processor = new RuleProcessor(rules);

            for (int i = 1; i <= n; i++)
            {
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
}

