using Tyuiu.FamutdinovaJI.Sprint1.Task4.V7.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint1.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 6;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.049, res);
        }
    }
}