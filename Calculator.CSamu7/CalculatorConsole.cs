namespace Calculator_CSamu7
{
    public class CalculatorConsole
    {
        private readonly List<double> _lastCalculations = [];
        private readonly Operation _operation = new Operation();
        private bool _endApp = false;
        private int _timesUsed = 0;
        public void Start()
        {
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!_endApp)
            {
                Console.WriteLine("Choose the operation: ");
                Console.WriteLine("\t1. Make an operation");
                Console.WriteLine("\t2. Reset");

                int option = ConsoleUtils.ReadInt();
                ExecuteOption(option);

                Console.WriteLine("------------------------\n");
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") _endApp = true;

                Console.WriteLine("\n");
            }

            Console.WriteLine($"The calculator was used {_timesUsed} times");
            return;
        }
        private void ExecuteOption(int option)
        {
            switch (option)
            {
                case 1:
                    double result = _operation.Calculate(_lastCalculations);

                    if (!double.IsNaN(result))
                    {
                        _lastCalculations.Add(result);
                        _timesUsed++;
                    }
                    break;
                case 2:
                    _lastCalculations.Clear();
                    Console.WriteLine("History cleaned.");
                    break;
                default:
                    Console.WriteLine("Unknown option");
                    break;
            }
        }
    }
}
