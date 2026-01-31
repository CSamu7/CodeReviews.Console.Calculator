namespace Calculator_CSamu7
{
    public class OperationUI
    {
        public string GetOperator()
        {
            DisplayOperationsList();
            Console.Write("Your option? ");
            string op = Console.ReadLine() ?? "";

            while (op == null || !Constants.AllOperations.ContainsKey(op))
            {
                Console.WriteLine("Error: Unrecognized input.");
                Console.Write("Your option? ");
                op = Console.ReadLine() ?? "";
            }

            return op;
        }
        private void DisplayOperationsList()
        {
            Console.WriteLine("Choose an operator from the following list:");

            foreach (var item in Constants.AllOperations)
            {
                Console.WriteLine($"\t {item.Key} - {item.Value}");
            }
        }
        public double GetFirstNumber(List<double> lastCalculations)
        {
            Console.WriteLine("Do you want to use the last result? {0:0.####} (y/n)", lastCalculations.Last());
            bool useLastCalculation = IsLastCalculationUsed();
            double cleanNum1 = useLastCalculation ? lastCalculations.Last() : 0;

            if (!useLastCalculation)
            {
                Console.Write("Type a number, and then press Enter: ");
                cleanNum1 = ConsoleUtils.ReadDouble();
            }

            return cleanNum1;
        }
        public double? GetSecondNumber(string? op)
        {
            double? cleanNum2 = null;

            if (op is not null && Constants.TwoNumbersOperations.ContainsKey(op))
            {
                Console.Write("Type another number, and then press Enter: ");
                cleanNum2 = ConsoleUtils.ReadDouble();
            }

            return cleanNum2;
        }
        private bool IsLastCalculationUsed()
        {
            bool useLastResult = false;

            string? lastResultInput = Console.ReadLine();

            if (lastResultInput == "y")
                useLastResult = true;

            return useLastResult;
        }
        public static void DisplayResult(double result)
        {
            if (double.IsNaN(result))
            {
                Console.WriteLine("This operation will result in a mathematical error.\n");
            } else
            {
                Console.WriteLine("Your result: {0:0.####}\n", result);
            }
        }
    }
}
