using Tyuiu.PuzinaDA.Sprint1.Task0.V16.Lib;

namespace Tyuiu.PuzinaDA.Sprint1.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Пузина Дарья Алексеевна | ИИПБ-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на С#, которая вычислаяет выражение 6/2/3+1-6/2*3    *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 6/2/3+1-6/2*3                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}