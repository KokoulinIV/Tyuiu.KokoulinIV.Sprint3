using Tyuiu.KokoulinIV.Sprint3.Task7.V12.Lib;
namespace Tyuiu.KokoulinIV.Sprint3.Task7.V12.Test
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

            int len = b - a+1;
            double[] valueArray = new double[len];
            valueArray[0] = -4.85;
            valueArray[1] = 11.04;
            valueArray[2] = 11.50;
            valueArray[3] = 2.06;
            valueArray[4] = -3.80;
            valueArray[5] = 4;
            valueArray[6] = 3.57;
            valueArray[7] = -2.11;
            valueArray[8] = -11.52;
            valueArray[9] = -11.06;
            valueArray[10] = 4.84;
            double[] res = ds.GetMassFunction(a, b);
            CollectionAssert.AreEqual(valueArray,res);

        }
    }
}