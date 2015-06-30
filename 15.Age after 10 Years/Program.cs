using System;

namespace _15.Age_after_10_Years
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your B-Day in format YYYY-MM-DD");
            string date = Console.ReadLine();
            
            DateTime time = DateTime.Parse(date);
            Console.WriteLine(time.Year);
            DateTime timeNow = DateTime.Now;
            Console.WriteLine(timeNow.Year);
            TimeSpan diff = timeNow.Subtract(time);
            
            Console.WriteLine("ATM I am"+" "+diff.TotalDays / 365+" "+"Years Old");
            Console.WriteLine("And in 10 Years I will be" + " " + (diff.TotalDays + 3650)/365);
           
            
        }
    }
}
