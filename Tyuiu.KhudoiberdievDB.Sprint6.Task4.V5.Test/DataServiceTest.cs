using Tyuiu.KhudoiberdievDB.Sprint6.Task4.V5.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startStep = -5;
            int stopStep = 5;
            int len = stopStep - startStep + 1;
            double[] wait = new double[] { 70.14, 55.21, 41.05, 27.96, 15.48, 1, -13.06, -28.16, -42.96, -56.77, -69.83 };
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(wait,res);


        }
    }
}