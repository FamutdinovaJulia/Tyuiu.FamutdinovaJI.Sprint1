using Tyuiu.FamutdinovaJI.Sprint1.Task5.V3.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double k = 130985;
            var res = ds.Calculate(k);
            Assert.AreEqual(9, res);
        }
    }
}