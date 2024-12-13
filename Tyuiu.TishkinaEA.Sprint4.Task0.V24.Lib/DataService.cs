using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TishkinaEA.Sprint4.Task0.V24.Lib
{
    public class DataService : ISprint4Task0V24
    {
        public int GetMultEvenArrEl(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым или null.");
            }

            int product = 1;
            bool hasEven = false;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    product *= num;
                    hasEven = true;
                }
            }

            return hasEven ? product : 0;
        }
    }
}
