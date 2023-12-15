namespace Fomulatrix
{
    public class RuleProcessor
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
}

