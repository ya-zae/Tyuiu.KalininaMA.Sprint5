using Tyuiu.KalininaMA.Sprint5.Task1.V30.Lib;

namespace Tyuiu.KalininaMA.Sprint5.Task1.V30;
internal class Program
{
    static void Main(string[] args)
    {
        int startValue = -5;
        int stopValue = 5;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Калинина М.А | РППб-25-1 ";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #30                                                              *");
        Console.WriteLine("* Выполнила: Калинина М.А  | РППб-25-1                                    *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("startValue = " + startValue);
        Console.WriteLine("stopValue = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл: " + res);

        Console.WriteLine(" Создан!");
        Console.ReadKey();
    }
}