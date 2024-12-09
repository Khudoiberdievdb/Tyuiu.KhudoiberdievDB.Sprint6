using Tyuiu.KhudoiberdievDB.Sprint6.Task1.V21.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] ValueWaitarray;
            ValueWaitarray = new double[len];
            ValueWaitarray[0] = 20.36;
            ValueWaitarray[1] = 15.42;
            ValueWaitarray[2] = 10.99;
            ValueWaitarray[3] = 7.43;
            ValueWaitarray[4] = 4.33;
            ValueWaitarray[5] = 1;
            ValueWaitarray[6] = 0;
            ValueWaitarray[7] = -8.87;
            ValueWaitarray[8] = -13.03;
            ValueWaitarray[9] = -16.53;
            ValueWaitarray[10] = -19.6;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, ValueWaitarray);



        }
    }
}