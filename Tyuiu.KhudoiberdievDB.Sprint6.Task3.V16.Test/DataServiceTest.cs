using Tyuiu.KhudoiberdievDB.Sprint6.Task3.V16.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
           int[,] matrix = new int[,] {{14  , 1,  -3,   1,  10 },
                                {7,  -3,   5,  -4,   0 },
                                {-10, -19, -18,  -9,  19 },
                                {-2,  -2, -16,   2, -17 },
                                {-16,   9,   5, -10,  16 } };
           int [,] WaitArray = {{14  , 1,  -3,   1,  10 },
                                {7,  -3,   5,  -4,   0 },
                                {0, -19, 0,  -9,  19 },
                                {-2,  -2, -16,   2, -17 },
                                {-16,   9,   5, -10,  16 } };
           int [,] resArray = ds.Calculate(matrix);
           CollectionAssert.AreEqual(resArray, WaitArray);


        }
    }
}