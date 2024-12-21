using System.IO;
using Tyuiu.KhudoiberdievDB.Sprint6.Task6.V12.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V12.txt";
            string strTest = @"iKDOjtfsPmw";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual( strTest, res );
        }
    }
}