using System;
namespace NumberConverter
{
    public class Converter
    {
        string [] tenArray = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
        string [] twentyArray = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tensArray = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public string noConverter(int x)
        {       
            if(x < 10)
            {
                return singleDigit(x);
            }
            else if(x<=99)
            {
                return doubleDigit(x);
            }
            else if(x<=999)
            {
                return tripleDigit(x);
            }
            else if (x <= 9999)
            {
                return quadDigit(x);
            }
            else
            {
                return "Number not in range";
            }
            
        }

        public string singleDigit(int x)
        {
            return tenArray[x];
        }

        public string doubleDigit(int x)
        {
            int digitTwo = x % 10;
            if (x % 10 == 0)
            {
                return tensArray[x / 10];
            }
            else if (x < 20)
            {
                return twentyArray[digitTwo];
            }
            else
            {
                return tensArray[x/10] + "-" + tenArray[x%10];
            }
        }

        public string tripleDigit(int x)
        {
            return tenArray[x / 100] + " Hundred" + (x % 100 == 0 ? "" : " and ") + doubleDigit(x % 100);
        }

        public string quadDigit(int x)
        {
            return tenArray[x / 1000] + " Thousand" + (x % 1000 == 0 ? "" : ", " + tripleDigit(x % 1000));
        }
    }
}
