using Tyuiu.KokoulinIV.Sprint3.Task0.V6.Lib;
namespace Tyuiu.KokoulinIV.Sprint3.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 1;
            int stop = 15;
            double res = ds.GetMultiplySeries(start, stop);
            double wail = 0.001;
            Assert.AreEqual(wail, res);
        }
    }
}