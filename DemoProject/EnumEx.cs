using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{

    public enum Httpstatuscode
    {
        OK = 200,
        BadRequest = 400,
        unauthorized = 401,
        Forbidden = 500,
        Notfound = 404
    }

    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,

    }

    public enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December

    }
    internal class EnumEx
    {
        static void Main()
        {
            Months firstmonth = Months.January;

            if (firstmonth == Months.January && firstmonth == Months.January)
            {
                Console.WriteLine("Starting month of year: " + firstmonth);
            }

            Months lastmonth = Months.December;

            if (lastmonth == Months.December)
            {
                Console.WriteLine("Ending month of year :" + lastmonth);
            }


            Days today = Days.Wednesday;

            if (today == Days.Sunday || today == Days.Sunday)
            {
                Console.WriteLine("it's weekend");
            }
            else
            {
                Console.WriteLine("it's weekday");
            }

            Httpstatuscode code = Httpstatuscode.OK;
            Console.WriteLine("HTTP status code :" + code);

            int codenumber = (int)code;
            Console.WriteLine("HTTP status code number :" + codenumber);
            Console.WriteLine("HTTP status code number :" + codenumber);

        }
    }
}
