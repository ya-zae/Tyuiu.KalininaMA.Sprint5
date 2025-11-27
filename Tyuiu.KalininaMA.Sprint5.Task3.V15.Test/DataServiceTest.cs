using Tyuiu.KalininaMA.Sprint5.Task3.V15.Lib;

namespace Tyuiu.KalininaMA.Sprint5.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.KalininaMA.Sprint5\Tyuiu.KalininaMA.Sprint5.Task3.V15\bin\Debug\net8.\0OutPutFileTask3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
