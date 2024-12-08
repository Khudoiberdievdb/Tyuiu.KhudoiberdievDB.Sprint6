using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task0.V10.Lib
{
    public class DataService : ISprint6Task0V10
    {
        public double Calculate(int x)
        {
            return Math.Round((2.12 * (x * x * x)) + (1.05 * (x * x)) + 4.1 * x * 2, 3);


        }
    }
}
