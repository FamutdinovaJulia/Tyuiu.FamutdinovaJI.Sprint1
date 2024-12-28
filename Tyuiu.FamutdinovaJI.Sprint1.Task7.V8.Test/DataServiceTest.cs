using Tyuiu.FamutdinovaJI.Sprint1.Task7.V8.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 30;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(144.949, res);
        }
    }
}