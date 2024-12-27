using System.Globalization;

namespace Tyuiu.FamutdinovaJI.Sprint1.Task5.V3.Lib
{
    public class DataService
    {
        public double Calculate(double k)
        {
            double res0 = (k % 1000) / 100;
            double res = Math.Floor(res0);
            return res;
        }
    }
}
