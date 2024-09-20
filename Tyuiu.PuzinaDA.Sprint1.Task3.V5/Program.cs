using Tyuiu.PuzinaDA.Sprint1.Task3.V5.Lib;
namespace Tyuiu.PuzinaDA.Sprint1.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите масштаб карты (количество км. в одном см.): ");
            double mapScale = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите расстояние между точками, изображающими населенные пункты (см): ");
            double distanceBetweenPoints = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.DistanceLength(mapScale, distanceBetweenPoints);
            Console.Write("Расстояние между населенными пунктами: " + res);
        }
    }
}
