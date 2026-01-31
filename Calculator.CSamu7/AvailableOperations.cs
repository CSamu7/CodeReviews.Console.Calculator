namespace Calculator_CSamu7
{
    public static class Constants
    {

        public static IReadOnlyDictionary<string, string> TwoNumbersOperations = new Dictionary<string, string>()
        {
            {"a", "Add"},
            {"s" , "Substract"},
            {"m", "Multiply" },
            {"d", "Divide" },
            {"sq", "Exponentitation"}
        };
        public static IReadOnlyDictionary<string, string> OneNumberOperations = new Dictionary<string, string>()
        {
            {"sqrt", "Square Root" },
            {"cos", "Cos" },
            {"tan", "Tan" },
            {"csc", "Csc" },
            {"sec", "Sec" },
            {"cot", "Cot" }
        };

        public static IReadOnlyDictionary<string, string> AllOperations =
            TwoNumbersOperations.Concat(OneNumberOperations).ToDictionary();
    }
}
