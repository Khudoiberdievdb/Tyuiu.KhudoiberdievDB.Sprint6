using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhudoiberdievDB.Sprint6.Task5.V5.Lib
{
    public class DataService : ISprint6Task5V5
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            
            
            
            
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            }
            int count = 0;
            double[] array = new double[len];
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line= sr.ReadLine()) != null)
                {
                    array[count] = Convert.ToDouble(line);
                    count++;
                }

                array = array.Where(x => x % 2 ==0).ToArray();

                return array;
            }

        }
    }
}
