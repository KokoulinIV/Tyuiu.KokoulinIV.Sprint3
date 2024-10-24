using Tyuiu.KokoulinIV.Sprint3.Task2.V19.Lib;


namespace Tyuiu.KokoulinIV.Sprint3.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 1;
            int b = 10;
            double res = ds.GetSumSeries(a, b);
            double wail = -0.709;
            Assert.AreEqual(wail, res);
        }
    }
}