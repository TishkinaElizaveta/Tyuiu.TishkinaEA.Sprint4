using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TishkinaEA.Sprint4.Task6.V17.Lib
{
    public class DataService : ISprint4Task6V17
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            // Используем Array для перебора элементов массива
            foreach (var str in array)
            {
                // Если длина строки равна 6, увеличиваем счетчик
                if (str.Length == 6)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
