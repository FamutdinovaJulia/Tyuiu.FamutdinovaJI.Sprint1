using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FamutdinovaJI.Sprint1.Task4.V7.Lib
{
    public class DataService: ISprint1Task4V7
    {
        public double Calculate(double x, double y)
        {
            double q = 1 + Math.Sqrt(x * y);
            double d = Math.Pow(x - 3*y,2);
            double res1 = q / d;
            double res = Math.Round(res1, 3);
            return res;
        }
    }
}
