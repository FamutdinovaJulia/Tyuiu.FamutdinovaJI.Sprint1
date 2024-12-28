using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FamutdinovaJI.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            int res0 = (k % 1000) / 100;
            //int res = Math.Floor(res0);
            return res0;
        }
    }
}
