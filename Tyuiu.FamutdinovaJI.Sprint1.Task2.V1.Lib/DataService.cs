namespace Tyuiu.FamutdinovaJI.Sprint1.Task2.V1.Lib
{
    public class DataService
    {
        public double Calculate(double x)
        {
            double y = (x / 1.609);
            double res = Math.Round(y,3);
            return res;
        }
    }
}
