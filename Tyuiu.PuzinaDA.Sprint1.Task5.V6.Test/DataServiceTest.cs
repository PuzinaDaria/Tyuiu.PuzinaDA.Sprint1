using Tyuiu.PuzinaDA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.PuzinaDA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCalculator()
        {
            DataService ds = new DataService();
            int k = 15;
            int nd = ds.Calculate(k);
            Assert.AreEqual(1, nd);
        }
    }
}