using System;
using System.Text;
    public class LeapYear
    {
        static bool IsYearLeap(int year){
            if (year%4==0 && year%100!=0) return true;
            else if (year%400==0) return true;
            else return false;

        }

        public static void LeapYearTest(){
            Console.WriteLine("\n---LeapYear---");
            Console.WriteLine(IsYearLeap(1996)); //true
            Console.WriteLine(IsYearLeap(1997)); //false
            Console.WriteLine(IsYearLeap(2000)); //true
            Console.WriteLine(IsYearLeap(1900)); //false
            
        }
    }
