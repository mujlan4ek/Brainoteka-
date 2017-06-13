using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cons_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //тест
            #region Arrays
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Консоль {0} ---", 1);

            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (int i = 0; i < weekdays.Count(); i++)
            {
                Console.WriteLine(weekdays[i]);
            }

            #endregion
            #region Lists
            Console.WriteLine();
            Console.WriteLine("--- Консоль {0} ---", 2);
            List<string> colors = new List<string> { "Red" };
            colors.Add("Orange");
            colors.Add("Green");
            colors.Sort();

            for (int i = 0; i < colors.Count(); i++)
            {
                Console.WriteLine(colors[i]);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
