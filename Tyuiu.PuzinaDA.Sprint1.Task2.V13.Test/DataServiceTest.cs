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
            int res = ds.Calculate(value);
            Assert.AreEqual(1609, res);

        }
    }
}