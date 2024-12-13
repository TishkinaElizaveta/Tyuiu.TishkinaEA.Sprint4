using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TishkinaEA.Sprint4.Task3.V13.Lib
{
    public class DataService : ISprint4Task3V13
    {
        public int Calculate(int[,] array)
        {
            if (array == null || array.GetLength(1) < 3)
            {
                throw new ArgumentException("Массив должен содержать минимум три столбца и не быть null.");
            }

            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, 2]; // Индекс 2 соответствует третьему столбцу
            }

            return sum;
        }
    }
}
