namespace CalculatorLibrary
{
    public class Calculator
    {
        public double Calculate(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                case "sq":
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    break;
            }

            return result;
        }
        public double Calculate(double num, string op)
        {
            if (op == "sqrt")
                return Math.Sqrt(num);

            num = double.DegreesToRadians(num);

            double result = op switch
            {
                "cos" => Math.Cos(num),
                "sin" => Math.Sin(num),
                "tan" => Math.Tan(num),
                "csc" => Math.Asin(num),
                "sec" => Math.Acos(num),
                "cot" => Math.Atan(num),
                _ => Double.NaN
            };

            return result;
        }
    }
}
