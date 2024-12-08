using Tyuiu.KhudoiberdievDB.Sprint6.Task0.V10.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            double exp = 37.56;
            Assert.AreEqual(exp, dataService.Calculate(2));
        }
    }
}