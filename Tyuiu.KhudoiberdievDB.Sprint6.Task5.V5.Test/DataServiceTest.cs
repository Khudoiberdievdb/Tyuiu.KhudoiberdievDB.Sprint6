using System.IO;
using Tyuiu.KhudoiberdievDB.Sprint6.Task5.V5.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask5V5.txt";
            double[] waitarray = { 10, 16, -12 };
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(waitarray, res);



        }
    }
}