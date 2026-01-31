namespace Calculator_CSamu7
{
    public static class ConsoleUtils
    {
        public static double ReadDouble()
        {
            string? input = Console.ReadLine();
            double number;

            while (!double.TryParse(input, out number))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                input = Console.ReadLine();
            }

            return number;
        }
        public static int ReadInt()
        {
            string? input = Console.ReadLine();
            int number;

            while (!int.TryParse(input, out number))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                input = Console.ReadLine();
            }

            return number;
        }
    }
}
