using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOTP_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод и вывод встроенных типов С#
            Console.WriteLine("Input Int:");
            int Integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Int {Integer}");

            Console.WriteLine("Input Byte:");
            byte Byte = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Byte {Byte}");

            Console.WriteLine("Input Char:");
            char Char = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Char {Char}");

            Console.WriteLine("Input Double:");
            double Double = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Double {Double}");

            Console.WriteLine("Input Bool:");
            bool Bool = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Bool {Bool}");

            Console.WriteLine("Input Float:");
            float Float = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Float {Float}");

            Console.WriteLine("Input Long:");
            long Long = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Long {Long}");

            Console.WriteLine("Input String:");
            string String = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"String {String}");

            Console.WriteLine("Input Short:");
            short Short = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Short {Short}");

            ushort Ushort = 7456;
            Console.WriteLine($"Ushort {Ushort}");

            uint Uint = 744576;
            Console.WriteLine($"Ushort {Uint}");

            ulong Ulong = 7456;
            Console.WriteLine($"Ulong {Ulong}");

            decimal Decimal = 7348456;
            Console.WriteLine($"Decimal {Decimal}");

            object Object = 7456;
            Console.WriteLine($"Object {Object}");

            sbyte Sbyte = 76;
            Console.WriteLine($"Sbyte {Sbyte}");


            //Неявное преобразование типов
            int integer = Ushort;
            float fl = Integer;
            short sh = Byte;
            decimal dec = Long;
            long lg = Uint;

            //Явное преобразование типов
            int a = (Int32)Uint;
            long b = (Int64)Ulong;
            short c = (Int16)Ushort;
            byte d = (Byte)Sbyte;
            double s = (Double)Float;

            //Упаковка и распаковка значимых типов

            Console.ReadKey();
            //
        }
    }
}
