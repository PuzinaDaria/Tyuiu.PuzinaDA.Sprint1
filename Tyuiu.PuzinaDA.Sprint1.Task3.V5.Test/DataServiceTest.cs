using Tyuiu.PuzinaDA.Sprint1.Task3.V5.Lib;
namespace Tyuiu.PuzinaDA.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DistanceTest()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(420, res);

        }
    }
}