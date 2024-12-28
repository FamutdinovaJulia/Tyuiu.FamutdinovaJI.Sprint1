using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FamutdinovaJI.Sprint1.Task3.V11.Lib
{
    public class DataService : ISprint1Task3V11
    {
        public double TriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double s = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            double s1 = Math.Abs(s);
            double res1 = 0.5 * s1;
            double res = Math.Round(res1, 3);
            return (int)res;
        }
    }
}
