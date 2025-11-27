using System;
using Tyuiu.KalininaMA.Sprint5.Task2.V25.Lib;
namespace Tyuiu.KalininaMA.Sprint5.Task2.V25

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Калинина М.А | РППб-25-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Калинина М.А  | РППб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: ");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = {
            { 4, 8, 5 },
            { 1, 4, 2 },
            { 4, 9, 9 }
        };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}