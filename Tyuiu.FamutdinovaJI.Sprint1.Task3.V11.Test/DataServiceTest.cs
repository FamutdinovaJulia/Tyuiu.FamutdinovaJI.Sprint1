using Tyuiu.FamutdinovaJI.Sprint1.Task3.V11.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = -2.0;
            double y1 = 5.0;
            double x2 = 1.0;
            double y2 = 7.0;
            double x3 = 5.0;
            double y3 = -3.0;
            var res = ds.TriangleArea(x1, y1, x2, y2, x3, y3);
            Assert.AreEqual(19, res);
        }
    }
}