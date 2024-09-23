using Tyuiu.PuzinaDA.Sprint1.Task7.V25.Lib;
namespace Tyuiu.PuzinaDA.Sprint1.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCalculate()
        {
            DataService ds = new DataService();
            double x = 2, y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6.861, res);
        }
    }
}