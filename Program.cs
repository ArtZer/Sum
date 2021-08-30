using System;
using System.Collections.Generic;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MassNum = new List<int>();
            int Sum;

            UseConsole useConsole = new UseConsole();
            MassNum = useConsole.InputMass(8);

            SumEvenNum sumEvenNum = new SumEvenNum();            
            Sum = sumEvenNum.Count(MassNum);

            Console.WriteLine($"Сумма всех четных чиселл в массиве равна: {Sum}");
        }
    }
}
