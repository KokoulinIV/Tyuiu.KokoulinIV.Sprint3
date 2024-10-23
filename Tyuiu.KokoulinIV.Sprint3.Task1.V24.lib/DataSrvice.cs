using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KokoulinIV.Sprint3.Task1.V24.lib
{
    public class DataSrvice : ISprint3Task1V24

    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double z = 0;
            while (startValue<stopValue)
            {
                z = z + Math.Pow(2/(6+Math.Pow(value,startValue)),startValue);
                startValue++;
            }
            return Math.Round(z,3);
        }
    }
}
