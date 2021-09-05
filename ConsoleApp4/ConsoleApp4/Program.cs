using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\ASUS\\Desktop\\a.txt");
            string s;
            List<string> bd = new List<string>();
            Console.WriteLine("Имеющаяся база данных:");
            while((s=sr.ReadLine())!=null)
            {
                bd.Add(s);
                Console.WriteLine(s);
            }
            sr.Close();
            int command = -1;
            while (command!=0)
            {
                Console.WriteLine("Введите номер команды:");
                Console.WriteLine("1 - Добавить");
                Console.WriteLine("0 - Выйти");
                command = Convert.ToInt32(Console.ReadLine());
                switch(command)
                {
                    case 1:
                        Console.WriteLine("Введите номер строки для вставки:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите данные:");
                        s = Console.ReadLine();
                        if (n > bd.Count)
                            bd.Add(s);
                        else bd.Insert(n,s);
                        break;
                    case 0:
                        StreamWriter sw = new StreamWriter("C:\\Users\\ASUS\\Desktop\\a.txt");
                        foreach (string st in bd)
                            sw.WriteLine(st);
                        sw.Close();
                        break;
                    default: break;
                }
             }
        }
    }
}
