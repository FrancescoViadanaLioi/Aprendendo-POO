using System;
using System.Collections.Generic;

namespace EX25.Services
{
    internal class PrintService<T>
    {
        private T[] _values = new T[10];

        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10) throw new InvalidOperationException("The list is already full.");
            _values[_count] = value;
            _count++;
        }
        public void First()
        {
            if (_count == 0) throw new InvalidOperationException("The list is empty.");
            Console.WriteLine($"First: {_values[0]}");
        }
        public void Print()
        {
            Console.Write("[");
            
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write($"{_values[i]}, ");
            }
            if (_count > 0) Console.Write(_values[_count - 1]);
            Console.WriteLine("]");
        }
    }
}
