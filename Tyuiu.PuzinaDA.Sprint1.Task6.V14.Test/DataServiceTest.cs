using Tyuiu.PuzinaDA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.PuzinaDA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            string value = "проверка текста";
            bool res = ds.CheckLowerCaseRusLetters(value);
            Assert.IsTrue(res);
        }
    }
}