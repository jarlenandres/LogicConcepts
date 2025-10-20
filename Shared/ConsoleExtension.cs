namespace Shared
{
    public class ConsoleExtension
    {
        public static int GetInt(string message)
        {
            Console.WriteLine(message);
            var numString = Console.ReadLine();
            var numberInt = 0;
            if (int.TryParse(numString, out numberInt))
            {
                return numberInt;
            }
            return 0;
        }

        public static decimal GetDecimal(string message)
        {
            Console.WriteLine(message);
            var numString = Console.ReadLine();
            var numberDecimal = 0m;
            if (decimal.TryParse(numString, out numberDecimal))
            {
                return numberDecimal;
            }
            return 0m;
        }

        public static string? GetValidOptions(string message, List<string> options)
        {
            Console.WriteLine(message);
            var answer = Console.ReadLine();
            if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
            {
                return answer;
            }
            return null;
        }
    }
}