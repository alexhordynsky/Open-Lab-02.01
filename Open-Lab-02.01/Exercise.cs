using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] numbers= new double[5] {1.1, 1.2, 1.3, 1.4, 1.5};
            return numbers;
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}