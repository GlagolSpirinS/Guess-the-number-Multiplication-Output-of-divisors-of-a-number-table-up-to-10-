using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения ");
            Console.WriteLine("3. Вывод делителей числа ");
            Console.WriteLine("4. Закрыть программу ");


            while (true)
            {
                Console.WriteLine("------------------------------------- ");
                Console.WriteLine("Какое действие вы хотите выполнить ? ");
                int action = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (action)
                {
                    case 1:
                        {
                            result = gadai();
                            break;
                        }
                    case 2:
                        {
                            result = Matrix();
                            break;
                        }
                    case 3:
                        {
                            result = delitka();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Ну и иди");
                            Environment.Exit(0);
                            break;
                        }
                }
                Console.WriteLine("Нажмите Enter для выбора других функций", result);
                Console.ReadKey();
            }

        }
        public static int gadai()
        {

            Random r = new Random();
            int winner = r.Next(0, 100);
            bool win = false;
            do
            {
                Console.WriteLine("Угадай число от 0 до 100: ");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                if (i > winner)
                {
                    Console.WriteLine("Бери ниже!");
                }
                else if (i < winner)
                {
                    Console.WriteLine("Бери выше!");
                }
                else if (i == winner)
                {
                    Console.WriteLine("ТЫ ВАНГА!");
                    win = true;
                }
            } while (win == false);

            int result = 1;
            return result;
        }
        public static int Matrix()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
            int result = 1;
            return result;
        }
        public static int delitka()
        {
            Console.WriteLine("Введите число ниже");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            int result = 1;
            return result;
        }
    }
}