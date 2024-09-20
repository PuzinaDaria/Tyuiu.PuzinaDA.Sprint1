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
            double distanceBetweenPoints = 3.5;
            double mapScale = 120;
            var res = ds.DistanceLength(mapScale, distanceBetweenPoints);
            Assert.AreEqual(420, res);
        }
    }
}