using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.OvsepyanAA.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {

                y = x * Math.Pow((x + 9) / (x - 1), x);
            }
            else if (x == 0)
            {

                y = (Math.Pow(x, 2) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
            }
            else if (-25 < x && x < 2)
            {
                
                y = Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
            }
            else if (x < -25)
            {
                
                y = x + 10 * x - (1 / x);
            }
            else
            {
               
                y = double.NaN; 
            }

            return Math.Round(y, 3);
        }
    }
}
