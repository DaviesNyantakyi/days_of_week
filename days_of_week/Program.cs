using System;


class MyApp
{

    class Program
    {
       static void Main()
        {
            Console.Write("Enter a number for the week: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string day = getDaysOfWeek(num);
            Console.WriteLine(day);
            
        }
    
        static string getDaysOfWeek (int num)
        {
            string dayNum;

            switch (num)
            {
                case 1:
                    dayNum = "Monday";
                    break;
                case 2:
                    dayNum = "Teusday";
                    break;
                case 3:
                    dayNum = "Wensday";
                    break;
                case 4:
                    dayNum = "Thursday";
                    break;
                case 5:
                    dayNum = "Friday";
                    break;
                default:
                    dayNum = "invalid number";
                    break;
            }
            return dayNum;
        }
    }
}
