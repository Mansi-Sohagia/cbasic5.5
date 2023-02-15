using System;

namespace cbasic5._5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter series of number saperated by Comma: ");
            var input = Console.ReadLine();
            var input1 = input.Split(',');
            var max = Convert.ToInt32(input1[0]);
            foreach (var str in input1)
            {
                var num = Convert.ToInt32(str);

                if (num > max)
                {
                    max = num;
                }

            }
            Console.WriteLine(max);

        }
    }
}
