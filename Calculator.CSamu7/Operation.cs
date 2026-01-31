using CalculatorLibrary;

namespace Calculator_CSamu7
{
    public class Operation
    {
        public double Calculate(List<double> lastCalculations)
        {
            try
            {
                double result = BuildOperation(lastCalculations);
                OperationUI.DisplayResult(result);

                return result;
            } catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                return Double.NaN;
            }
        }
        private double BuildOperation(List<double> lastCalculations)
        {
            OperationUI operationUI = new OperationUI();
            string op = operationUI.GetOperator();
            double cleanNum1 = operationUI.GetFirstNumber(lastCalculations);
            double? cleanNum2 = operationUI.GetSecondNumber(op);

            Calculator calculator = new Calculator();

            double result = cleanNum2 is not null
                ? calculator.Calculate(cleanNum1, cleanNum2.Value, op)
                : calculator.Calculate(cleanNum1, op);

            return result;
        }
    }
}
