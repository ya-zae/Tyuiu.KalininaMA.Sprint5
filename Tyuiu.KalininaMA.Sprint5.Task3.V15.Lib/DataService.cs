using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KalininaMA.Sprint5.Task3.V15.Lib
{
    public class DataService : ISprint5Task3V15
    {
        public string SaveToFileTextData(int x)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.txt");
            double res = -1.4 * x * x * x + 2.3 * x * x + 0.6 * x;
            res = Math.Round(res, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return filePath;
        }
    }
}
