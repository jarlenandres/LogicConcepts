namespace Calculate
{
    public class CalculateSalary
    {
        public static string? GetName(string message)
        {
            Console.WriteLine(message);
            var name = Console.ReadLine();
            return name;
        }
        public static float GetHours(string message)
        {
            Console.WriteLine(message);
            var hoursString = Console.ReadLine();
            if (float.TryParse(hoursString, out float hours))
            {
                return hours;
            }
            return 0;
        }

        public static decimal GetHourValue(string message)
        {
            Console.WriteLine(message);
            var hourValueString = Console.ReadLine();
            if (decimal.TryParse(hourValueString, out decimal hourValue))
            {
                return hourValue;
            }
            return 0;
        }

        public static decimal GetMinimunSalary(string message)
        {
            Console.WriteLine(message);
            var minimunSalaryString = Console.ReadLine();
            if (decimal.TryParse(minimunSalaryString, out decimal minimunSalary))
            {
                return minimunSalary;
            }
            return 0;
        }
    }
}
