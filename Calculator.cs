using System;

namespace NUnits
{
    public class Calculator : IDisposable
    {

        public int AddNumns(int a, int b)
        {
            return(a + b);
        }

        public int SubtractNums(int a, int b)
        {
            if (a < b)
                throw new Exception($"first number{a} is smaller than last number{b}");
            return a - b;
        }

        public void Dispose() { }
    }
}
