using Tyuiu.PuzinaDA.Sprint1.Task2.V13.Lib;
namespace Tyuiu.PuzinaDA.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 1;
            double res = ds.Calculate(value);
            res = res / 1000;
            Assert.AreEqual(1.609, res);

        }
    }
}