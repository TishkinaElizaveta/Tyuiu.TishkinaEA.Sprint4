using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TishkinaEA.Sprint4.Task2.V11.Lib
{
    public class DataService : ISprint4Task2V11
    {
        public int Calculate(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым или null.");
            }

            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
