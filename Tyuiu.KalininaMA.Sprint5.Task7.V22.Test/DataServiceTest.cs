using Tyuiu.KalininaMA.Sprint5.Task7.V22.Lib;

namespace Tyuiu.KalininaMA.Sprint5.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestLoadDataAndSave()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V22.txt");
            DataService ds = new DataService();
            var res = ds.LoadDataAndSave(path);
            string wait = "Ст#ока# и# #точка#";
            Assert.AreEqual(wait, File.ReadAllText(res));
        }
    }
}
