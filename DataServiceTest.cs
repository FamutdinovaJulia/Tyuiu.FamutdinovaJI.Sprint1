using Tyuiu.FamutdinovaJI.Sprint1.Task2.V1.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 6;
            var res = ds.Calculate(x);
            Assert.AreEqual(3.729, res);
        }
    }
}