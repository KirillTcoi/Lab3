using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzprog
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
        static void prog1()
        {
            {
                int n = int.Parse(Console.ReadLine());
                bool qwe = false;
                int god = 0;
                int g = 0;
                while (g != n+1)
                {
                    god = god + g;
                    g++;
                }
                Console.WriteLine(god);
                Console.ReadKey();
            }
            
        }
        static void prog2()
        {
            {
                int g = 35;
                while (g != 88)
                {
                    if (g % 7 == 1 || g % 7 == 2 || g % 7 == 5)
                        Console.WriteLine(g);
                    g++;
                }
                Console.ReadKey();
            }
        }
        static void prog3()
        {
            Console.WriteLine("Введите кол-во посетителей:");
            int[] pos = new int[int.Parse(Console.ReadLine())];
            int i = 0;
            int oldmen = 0;
            int yumen = 200;
            int all = 0;
            while (i != pos.Length)
            {
                Console.WriteLine("Введите возраст {0} посетителя", i + 1);
                pos[i] = int.Parse(Console.ReadLine());
                if (pos[i] > oldmen)
                    oldmen = pos[i];
                if (pos[i] < yumen)
                    yumen = pos[i];
                all = all + pos[i];
                i++;
            }
            Console.Clear();
            Console.WriteLine("Самый молодой посетитель: {0}\r\nСамый старый посетитель: {1}\r\nСредний возраст посетителей: {2}", yumen, oldmen, all / pos.Length);
            Console.ReadKey();
        }
        static void prog4()
        {
            int kol = 15;
            while (kol != 0)
            {
                Console.WriteLine("Машина подъехала, сколько загрузим в неё ящиков? \r\nОстолось {0} ящиков", kol);
                int kl = int.Parse(Console.ReadLine());
                if (kl <= kol)
                    kol = kol - kl;
                else
                    Console.WriteLine("Ошибка");
                Console.Clear();
                Console.WriteLine("Вы восхитительны");
                Console.ReadKey();
            }
        }
        static void prog5()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write("3 ");
                Console.WriteLine("");
            }

            int k = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0} ", k);
                    k++;
                }

                Console.WriteLine("");
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    if (i >= j)
                        Console.Write("* ");
                Console.WriteLine("");
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    if (i == 4 - j || i == j)
                        Console.Write("1 ");
                    else Console.Write("0 ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

