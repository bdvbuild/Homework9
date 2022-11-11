using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Калькулятор:");

            while (!endApp)
            {
                int a = 0;
                int b = 0;
                int c = 0;
                double d = 0;
                try
                {
                    Console.Write("Введите целое число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите целое число: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите код операции:\n1 - сложение\n2 - вычитание\n3 - умножение\n4 - деление");
                    c = Convert.ToInt32(Console.ReadLine());
                    while (c < 1 || c > 4)
                    {
                        Console.WriteLine("Нет операции с указанным номером. Введите верное значение:");
                        c = Convert.ToInt32(Console.ReadLine());
                    }
                    switch (c)
                    {
                        case 1:
                            d = a + b;
                            break;
                        case 2:
                            d = a - b;
                            break;
                        case 3:
                            d = a * b;
                            break;
                        case 4:
                            d = (double)a / b;
                            break;
                    }
                    Console.WriteLine($"Ответ: {d}");
                }
                catch (DivideByZeroException) when (b == 0 && c == 4)
                {
                    Console.WriteLine("Ошибка: деление на 0.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("");
                Console.Write("Введите 0, чтобы закрыть калькулятор, или любую другую клавишу, чтобы продолжить: ");
                if (Console.ReadLine() == "0") endApp = true;
                Console.WriteLine("");
            }
        }
    }
}
