using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNugetPack471
{
    public class TestNugetPack471
    {
        public TestNugetPack471()
        {
            StartStep = 0;
            EndStep = 100;
        }

        public uint StartStep { get; set; }

        public uint EndStep { get; set; }

        public uint Calculate()
        {
            uint value = _f;
            uint old = 0;
            uint temp = 0;
            uint result = 0;
            for (int i = 0; i < StartStep; i++)
            {
                temp = value;
                value = Fibonacci(value, old);
                old = temp;
            }
            result += value;
            for (int i = (int)StartStep; i < EndStep; i++)
            {
                temp = value;
                value = Fibonacci(value, old);
                result += value;
                old = temp;
            }

            return result;
        }

        private uint Fibonacci(uint f1, uint f2)
        {
            return f1 + f2;
        }

        private uint _f = 1;
    }
}
