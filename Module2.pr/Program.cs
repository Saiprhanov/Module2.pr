using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.pr
{
    internal class Program
    {


        static void example7()
        {
            Console.Write("Введите радиус:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сторону 2:");
            int b = Convert.ToInt32(Console.ReadLine());
            double p = 3.14;
            double krug = a * a * p;
            int kvad = b * b;



            if (krug > kvad)
            {
                Console.WriteLine(krug);
            }
            else
            {
                Console.WriteLine(kvad);
            }
            Console.ReadKey();
        }
        static void example10()
        {

            for (int i = 20; i < 35; i++)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey(true);
        }
        static void example30()
        {
            Console.Write("Введите 1:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 2:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }

            }
            Console.WriteLine(sum);
            Console.ReadKey(false);

        }

        static void example15()
        {

            Console.Write("Введите: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 10;
            int c = a % 10;
            int sum = b + c;
            int kob = b * c;
            Console.WriteLine(kob);

            Console.ReadKey(true);
        }

        static void example16()
        {
            Console.Write("Введите:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 1000;
            int c = (a - b * 1000) / 100;
            int d = ((a % 1000) % 100) / 10;
            int e = ((a % 1000) % 100) % 10;
            int sum = b + c + d + e;
            int kob = b * c * d * e;
            Console.WriteLine("Сумма" + sum);
            Console.WriteLine("Произведение" + kob);
            Console.ReadKey();

        }
        static void example3()
        {
            Console.WriteLine("Введите величину в см");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / 100);
            Console.ReadKey();
        }
        static void example13()
        {
            Console.WriteLine("Введите величину в см");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / 100);
            Console.ReadKey();
        }
        static void example23()
        {
            Console.WriteLine("Введите часы");
            double h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            double m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            double s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(h * 3600 + m * 60 + s);
            Console.ReadKey(true);

        }
        static void example24()
        {
            Console.WriteLine("Введите месяц");
            double m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день");
            double d = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(m * 30 + d);
            Console.ReadKey(true);

        }
        static void example25()
        {
            Console.WriteLine("Введите месяц");
            double m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день");
            double d = Convert.ToInt32(Console.ReadLine());
            int days = 0;
            for (int i = 1; i <= m; i++)
            {
                if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    days += 30;
                }
                else days += 31;



            }
            Console.WriteLine(days + d);
            Console.ReadKey(true);


        }
        static void example2()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            example7();
            example10();
            example30();
            example15();
            example16();
            example3();
            example13();
            example23();
            example24();
            example25();
            example2();
        }
    }
}
