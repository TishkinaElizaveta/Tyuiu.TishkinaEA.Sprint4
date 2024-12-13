using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TishkinaEA.Sprint4.Task7.V13.Lib
{
    public class DataService : ISprint4Task7V13
    {
        public int Calculate(int n, int m, string value)
        {
            if (value.Length != n * m)
            {
                throw new ArgumentException("Длина строки не соответствует размеру матрицы.");
            }

            int count = 0;
            int[,] matrix = new int[n, m];

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            foreach (var num in matrix)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
