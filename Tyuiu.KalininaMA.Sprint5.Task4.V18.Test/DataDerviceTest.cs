using Tyuiu.KalininaMA.Sprint5.Task4.V18.Lib;

namespace Tyuiu.KalininaMA.Sprint5.Task4.V18.Test
{
    [TestClass]
    public sealed class DataDerviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string p = @"C:\Users\rugis\AppData\Local\Temp\InPutDataFileTask4V18.txt";
            FileInfo fileInfo = new FileInfo(p);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
