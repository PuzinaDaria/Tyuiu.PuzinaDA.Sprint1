using Tyuiu.PuzinaDA.Sprint1.Task7.V25.Lib;
namespace Tyuiu.PuzinaDA.Sprint1.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*            2          3         2                                       *");
            Console.WriteLine("*      x    y + 6 + cosx + xy - 2x                                        *");
            Console.WriteLine("* z = e  -  ----------------------                                        *");
            Console.WriteLine("                  4                                                       *");
            Console.WriteLine("*            sin(x + 13) + 9y - 2                                         *");
            int x, y;
            Console.WriteLine("Введите Х: ");
            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Введите Y: ");
            y = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
        }
    }
}
