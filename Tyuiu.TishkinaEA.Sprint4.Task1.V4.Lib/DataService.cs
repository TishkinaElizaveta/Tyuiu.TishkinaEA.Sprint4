using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TishkinaEA.Sprint4.Task1.V4.Lib
{
    public class DataService : ISprint4Task1V4
    {
        public int Calculate(int[] array)
        {
                if (array == null || array.Length == 0)
                {
                    throw new ArgumentException("Массив не должен быть пустым или null.");
                }

                int product = 1;
                bool hasOdd = false;

                foreach (int num in array)
                {
                    if (num % 2 != 0)
                    {
                        product *= num;
                        hasOdd = true;
                    }
                }

                return hasOdd ? product : 0;
            }
        }
    }
