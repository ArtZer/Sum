using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    class UseConsole
    {
        public List<int> InputMass(int SizeMass)
        {
            List<int> MassNum = new List<int>();

            Console.WriteLine($"Введите массив из {SizeMass} целых чисел:");
            for (int i = 0; i < SizeMass; i++)
            {
                try
                {
                    MassNum.Add(Int32.Parse(Console.ReadLine()));
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Не корректный ввод, ошибка : {ex}");
                    break;
                }
            }
            return MassNum;
        }
    }
}
