using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task1.V21.Lib
{
    public class DataService : ISprint6Task1V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
             startValue = -5;
             stopValue = 5;
            int len = stopValue - startValue + 1;
            double y;
            double[] res = new double[len];
            int count = 0;
            for (int x = startValue; x<=stopValue; x++)
            {
                if (2 - 2 * x != 0)
                {
                    y = (Math.Cos(x)) + ((Math.Sin(x)) / (2 - 2 * x)) - (4 * x);
                    y = Math.Round(y, 2);
                    res[count] = y;
                }
                else
                {
                    res[count] = 0;
                }
                count++;
            }
            return res;

        }
    }
}
