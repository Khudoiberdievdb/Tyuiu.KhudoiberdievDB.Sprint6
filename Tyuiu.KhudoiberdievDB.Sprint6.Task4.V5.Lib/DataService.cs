using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] array = new double[len];
            int count = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2, 2);
                array[count] = y;
                count++;
            }
            return array;
        }
    }
}
