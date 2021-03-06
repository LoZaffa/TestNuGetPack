﻿using System;

namespace TestNuGetPack
{
    public class TestNuGetPack
    {
        
        public TestNuGetPack()
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
            for (int i = 0; i < StartStep; i++)
            {
                temp = value;
                value = Fibonacci(value, old);
                old = temp;
            }
                
            return value;
        }

        private uint Fibonacci(uint f1, uint f2)
        {
            return f1 + f2;
        }

        private uint _f = 1;
    }

}
