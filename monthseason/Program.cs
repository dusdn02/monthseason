using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] mon = { "1", "2", "3", "4", "5", "6",
                "7", "8", "9", "10", "11", "12" };

            Console.Write("이번 달은 몇 월인가요 : ");
            String line =Console.ReadLine();

            int input=0;

            for (int i = 0; i < 12; i++)
            {
                if (line.Contains(mon[i]))
                {
                    Console.WriteLine(mon[i]);
                    input = int.Parse(mon[i]);
                }
            }
            
                switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("대체 어느 행성에서 왔습니까");
                    break;
            }
        }
    }
}
