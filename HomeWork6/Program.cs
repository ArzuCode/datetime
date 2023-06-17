using Microsoft.VisualBasic;
using System.Globalization;

namespace HomeWork6
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dateInput = "07/10/1998";
            Console.WriteLine(IsValidDate(dateInput));
        }

        public static bool IsValidDate(string date)
        {
            DateTime tempObject;

            return DateTime.TryParseExact(date, "dd/mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tempObject);
        }
    }
}