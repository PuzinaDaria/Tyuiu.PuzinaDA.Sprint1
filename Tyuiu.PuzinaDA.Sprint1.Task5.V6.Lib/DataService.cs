using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PuzinaDA.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int res = k % 7;
            if (res == 0) 
            {
                res += 7;
            }
            return res;
        }
    }
}
