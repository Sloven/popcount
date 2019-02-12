using System;
using NUnit.Framework;

namespace LShift
{
    class Interview
    {
        static void Main(string[] args)
        {
            int input = 0;
            if(args == null || args.Length > 1 || args.Length == 0 || !int.TryParse(args[0],out input)){
                Console.WriteLine("Please provide exactly 1 argument that is positive integer number from 0 to 1000000");
                return;
            }

            var res = Population_count(input);
            Console.WriteLine($"Result is:{res}");
        }

        public static int Population_count(int val){
            int div  = val;
            var count = 0;
            Console.WriteLine(div);
            while(div / 2 > 0){
                if(div % 2 == 1) count ++;
                div = (int)Math.Floor((decimal)div/2);
            }
            return count + div;
        }
    }
}
