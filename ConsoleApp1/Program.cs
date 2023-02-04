using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("shit");
            String name=Console.ReadLine();//readline可以1.用于停留,2.用于获取输入
            int score = int.Parse(Console.ReadLine());//int.Parse将字符串解释成int
            String info=string.Format("姓名:{0},分数:{1}",name,score);//占位符格式的字符串拼接
            Console.WriteLine(info);
            Console.WriteLine("姓名:{0},分数:{1}", name, score);//cw可以直接这么写
            Console.ReadLine();
        }
    }
}
