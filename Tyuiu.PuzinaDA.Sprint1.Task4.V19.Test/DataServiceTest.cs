using Tyuiu.PuzinaDA.Sprint1.Task4.V19.Lib;
namespace Tyuiu.PuzinaDA.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestedCalc()
        {
            DataService ds = new DataService();
            double x = 19;
            double y = 10;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(1.706, res);
        }
    }
}