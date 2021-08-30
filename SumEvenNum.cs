using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    class SumEvenNum
    {
        public int Count(List<int> LNum)
        {
            int sum = 0;
            foreach(int i in LNum)
            {
                try
                {
                    if (IsEven(i))
                        sum += i;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при подсчете суммы: {ex}");
                    break;
                }
            }

            return sum;
        }

        private bool IsEven(int i)
        {
            return (i % 2) == 0;
        }
    }
}
