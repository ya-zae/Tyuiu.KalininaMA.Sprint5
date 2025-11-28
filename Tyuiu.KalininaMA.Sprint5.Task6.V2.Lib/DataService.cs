using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KalininaMA.Sprint5.Task6.V2.Lib
{
    public class DataService : ISprint5Task6V2
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] >= 'А' && line[i] <= 'Я' || line[i] >= 'а' && line[i] <= 'я')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
