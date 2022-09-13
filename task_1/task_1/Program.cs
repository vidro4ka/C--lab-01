using System;

namespace lab_01
{
    class task_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"[1] sbyte: minimum value is {SByte.MinValue} and maximum value is {SByte.MaxValue}");
            Console.WriteLine($"[2] byte: minimum value is {Byte.MinValue} and maximum value is {Byte.MaxValue}");
            Console.WriteLine($"[3] char: minimum value is {(int)Char.MinValue} and maximum value is {(int)Char.MaxValue}");
            Console.WriteLine($"[4] decimal: minimum value is {Decimal.MinValue} and maximum value is {Decimal.MaxValue}");
            Console.WriteLine($"[5] double: minimum value is {Double.MinValue} and maximum value is {Double.MaxValue}");
            Console.WriteLine($"[6] single: minimum value is {Single.MinValue} and maximum value is {Single.MaxValue}");
            Console.WriteLine($"[7] int16: minimum value is {Int16.MinValue} and maximum value is {Int16.MaxValue}");
            Console.WriteLine($"[8] int32: minimum value is {Int32.MinValue} and maximum value is {Int32.MaxValue}");
            Console.WriteLine($"[9] int64: minimum value is {Int64.MinValue} and maximum value is {Int64.MaxValue}");
            Console.WriteLine($"[10] uint16 minimum value is {UInt16.MinValue} and maximum value is {UInt16.MaxValue}");
            Console.WriteLine($"[11] uint32: minimum value is {UInt32.MinValue} and maximum value is {UInt32.MaxValue}");
            Console.WriteLine($"[12] uint64: minimum value is {UInt64.MinValue} and maximum value is {UInt64.MaxValue}");
            Console.WriteLine($"[13] bool: minimum value is {Boolean.TrueString} and maximum value is {Boolean.FalseString}");
            Console.ReadLine();
        }
    }
}
