using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolovikovMV.Sprint1.Task2.V8.Lib;

namespace Tyuiu.VolovikovMV.Sprint1.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Воловиков М. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Воловиков Михаил Васильевич | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу, которая запрашивает у пользователя         *");
            Console.WriteLine("* исходные данные, выполняет указанные расчёты и                          *");
            Console.WriteLine("* печатает результат на экране.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a, b;
            Console.WriteLine("Введите длину первой стороны прямоугольника:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны прямоугольника:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.CalculatePerimetr(a,b);
            Console.WriteLine("Периметр прямоугольника = " + res);
            Console.ReadKey();
        }
    }
}
