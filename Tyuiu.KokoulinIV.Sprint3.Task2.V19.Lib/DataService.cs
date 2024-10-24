using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KokoulinIV.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double z = 0;
            do
            {
                z = z + Math.Round(Math.Cos(startValue)) * (1 / 2);
                startValue++;
            }
            while (startValue <= stopValue); 
            return Math.Round(z,3);
        }
    }
}
