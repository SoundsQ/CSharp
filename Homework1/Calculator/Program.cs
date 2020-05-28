using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum;
            Console.WriteLine("输入第一个数字");
            firstNum = ReadEftInt();
            Console.WriteLine("输入第二个数字");
            secondNum = ReadEftInt();
            Console.WriteLine("选择需要进行的运算:1.+    2.-    3.*    4./\n输入选择的运算前面的数字标号");
            int choice;
            choice = ReadEftInt();
            while (choice < 1 || choice > 4)//输入的数据不是1、2、3、4
            {
                Console.WriteLine("输入的数字不在有效范围，请重新输入：");
                choice = ReadEftInt();
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{firstNum}+{secondNum}的结果为{firstNum + secondNum}");
                    break;
                case 2:
                    Console.WriteLine($"{firstNum}-{secondNum}的结果为{firstNum - secondNum}");
                    break;
                case 3:
                    Console.WriteLine($"{firstNum}*{secondNum}的结果为{firstNum * secondNum}");
                    break;
                case 4:
                    if (secondNum == 0)
                    {
                        Console.WriteLine("错误！除数不能为0");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNum}/{secondNum}的结果为{firstNum / secondNum}");
                    }
                    break;
            }
        }

        //从控制台输入流中读取并返回一个有效的整数
        static int ReadEftInt()
        {
            string s = Console.ReadLine();
            bool isEft;//isEft表示输入的字符是否为整数，是整数则isEft为true，反之为false。
            int num;
            isEft = int.TryParse(s, out num);
            while (!isEft)//输入的字符不是整数（解析失败）,则需重新输入
            {
                Console.WriteLine("解析失败，输入的不是数字，请重新输入：");
                s = Console.ReadLine();
                isEft = int.TryParse(s, out num);
            }
            return num;
        }
    }
}
