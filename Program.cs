using System;

namespace _121
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("от");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("до");
            int end = int.Parse(Console.ReadLine());
            int oddnumbers = 0;
            int evennumbers = 0;
            int counterevennumbers = 0;
            int counterodd = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    counterevennumbers++;

                    evennumbers = evennumbers + i;
                }
                
                else
                {
                    counterodd++;
                    oddnumbers = oddnumbers + i;
                }
            }
            
            Console.WriteLine("количество четных чисел в заданном диапозоне = " + counterevennumbers);
            Console.WriteLine("количество нечетных чисел в заданном диапозоне = " + counterodd);
            Console.WriteLine("сумма четных числе = " + evennumbers);
            Console.WriteLine("сумма не четных числе = " +oddnumbers);
            
            Console.WriteLine("Нажмите любую клавишу, что бы продолжить");
            Console.ReadLine();
            Main();
        }
        
    }
    

}

