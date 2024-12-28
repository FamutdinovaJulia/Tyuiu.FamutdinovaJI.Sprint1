using Tyuiu.FamutdinovaJI.Sprint1.Task3.V11.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint1.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Фамутдинова Ю. И. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Фамутдинова Юлия Ильфатовна | ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая вычисляет площадь треугольника, если        *");
            Console.WriteLine("* известны координаты его углов.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x1, y1, x2, y2, x3, y3;

            Console.WriteLine("Введите х1:");
            x1 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y1:");
            y1 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите х2:");
            x2 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y2:");
            y2 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите х3:");
            x3 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y3:");
            y3 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь треугольника = " + ds.TriangleArea(x1, y1, x2, y2, x3, y3) + " кв.см");

            Console.ReadLine();
        }
    }
}
