using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FamutdinovaJI.Sprint1.Task7.V8.Lib
{
    public class DataService : ISprint1Task7V8
    {
        public double Calculate(double x, double y)
        {
            double ln = Math.Log(x);
            double cos = Math.Cos(x);
            double res1 = (x * ln) + (y / (cos - (x / 3)));
            double res = Math.Round(res1, 3);
            return res;
        }
    }
}
