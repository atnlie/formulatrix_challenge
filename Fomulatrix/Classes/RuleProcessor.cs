namespace Fomulatrix
{
    public class RuleProcessor
    {
        private readonly List<IRule> rules;

        public RuleProcessor(List<IRule> rules)
        {
            this.rules = rules;
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
}

