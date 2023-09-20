using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolovikovMV.Sprint1.Task3.V15.Lib;

namespace Tyuiu.VolovikovMV.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Воловиков М. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Воловиков Михаил Васильевич | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу, которая запрашивает у пользователя         *");
            Console.WriteLine("* исходные данные, выполняет указанные расчёты и                          *");
            Console.WriteLine("* печатает результат на экране.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1 = 60;
            double v2 = 50;
            double s = 10;
            double t = 3;

            Console.WriteLine("Скорость первого автомобиля = " + v1);
            Console.WriteLine("Скорость второго автомобиля = " + v2);
            Console.WriteLine("Расстояние между автомобилями = " + s);
            Console.WriteLine("Время затраченное на движение = " + t);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между автомобилями через " + t + " часов = " + ds.DistanceOverTime( v1, v2, s, t));

            Console.ReadKey();
        }   
    }
}
