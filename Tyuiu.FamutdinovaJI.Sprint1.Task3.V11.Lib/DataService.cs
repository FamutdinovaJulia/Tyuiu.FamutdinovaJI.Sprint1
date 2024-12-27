namespace Tyuiu.FamutdinovaJI.Sprint1.Task3.V11.Lib
{
    public class DataService
    {
        public double Calculate(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double s = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            double s1 = Math.Abs(s);
            double res = 0.5 * s1;
            return res;
        }
    }
}
