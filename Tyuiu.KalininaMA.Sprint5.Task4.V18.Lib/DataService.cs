using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KalininaMA.Sprint5.Task4.V18.Lib
{
    public class DataService : ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            double x = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string content = File.ReadAllText(path);
                content = content.Replace('.', ',');
                x = Double.Parse(content);
            }
            double res = Math.Cos(x) + (Math.Pow(x, 2) / 2);
            return Math.Round(res, 3);
        }
    }
}
