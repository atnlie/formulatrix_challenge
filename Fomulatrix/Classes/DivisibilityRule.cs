namespace Fomulatrix
{
    public class DivisibilityRule : IRule
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
}

