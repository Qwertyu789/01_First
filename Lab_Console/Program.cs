using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab02_NameForm;

namespace CosoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello c#!");
            Console.Write("你的姓名：");
            string Name = Console.ReadLine();
            Console.WriteLine("歡迎回來！" + Name);
            Console.ReadKey();

            MyFirstClass mc = new MyFirstClass();
            mc.method04();

        }
    }
}
