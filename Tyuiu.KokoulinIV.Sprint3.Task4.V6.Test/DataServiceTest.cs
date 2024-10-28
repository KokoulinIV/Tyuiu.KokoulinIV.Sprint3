using Tyuiu.KokoulinIV.Sprint3.Task4.V6.Lib;
namespace Tyuiu.KokoulinIV.Sprint3.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = -5;
            int b = 5;
            double res = ds.Calculate(a, b);
            double wail = 8.995;
            Assert.AreEqual(wail, res);
        }
    }
}