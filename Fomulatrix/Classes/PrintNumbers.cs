// This class deprecated after change logic using NumberGenerator class

//namespace Fomulatrix
//{
//    public class NumberPrinter
//    {
//        public static void PrintNumbers(int n)
//        {
//            for (int i = 1; i <= n; i++)
//            {
//                RuleProcessor processor = new RuleProcessor();

//                processor.AddRule(new DivisibilityRule(3, "foo"));
//                processor.AddRule(new DivisibilityRule(4, "baz"));
//                processor.AddRule(new DivisibilityRule(5, "bar"));
//                processor.AddRule(new DivisibilityRule(7, "jazz"));
//                processor.AddRule(new DivisibilityRule(9, "huzz"));

//                // Process the rules for the current number
//                string result = processor.ProcessRules(i);

//                // Print the result
//                Console.Write(result);

//                // Add a comma and space for separation, except for the last number
//                if (i < n)
//                {
//                    Console.Write(", ");
//                }
//            }
//        }
//    }
//}