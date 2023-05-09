using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextSunday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProssimaDomenica(DateTime.Today));


            Console.ReadLine();
        }

        private static DateTime ProssimaDomenica(DateTime data)
        {
            do
            {
                data = data.AddDays(1);
            } while (data.DayOfWeek != DayOfWeek.Sunday);

            return data;
        }
    }
}
