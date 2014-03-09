using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitConversionFailure
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define an array of Decimal values.
            //Decimal[] values = { 1M, 100000000000000M, 10000000000000000000000000000M,
            //               100000000000000.00000000000000M, 1.0000000000000000000000000000M,
            //               123456789M, 0.123456789M, 0.000000000123456789M,
            //               0.000000000000000000123456789M, 4294967295M,
            //               18446744073709551615M, Decimal.MaxValue,
            //               Decimal.MinValue, -7.9228162514264337593543950335M };

            Decimal[] values = { 0.01m, (decimal)0.01f };









            Console.WriteLine("{0,31}  {1,10:X8}{2,10:X8}{3,10:X8}{4,10:X8}",
                              "Argument", "Bits[3]", "Bits[2]", "Bits[1]",
                              "Bits[0]");
            Console.WriteLine("{0,31}  {1,10:X8}{2,10:X8}{3,10:X8}{4,10:X8}",
                               "--------", "-------", "-------", "-------",
                               "-------");

            // Iterate each element and display its binary representation 
            foreach (var value in values)
            {
                int[] bits = decimal.GetBits(value);
                Console.WriteLine("{0,31}  {1,10:X8}{2,10:X8}{3,10:X8}{4,10:X8}",
                                  value, bits[3], bits[2], bits[1], bits[0]);
            }

            Console.ReadLine();
        }

        public static int Precision(Decimal number)
        {
            var bits = Decimal.GetBits(number)[3];
            var bytes = BitConverter.GetBytes(bits)[2];

            return bytes;

            //return BitConverter.GetBytes(Decimal.GetBits(number)[3])[2];
        }

        //broken (cast):
        //[0] = 10 //low bits
        //[3] = 196608

        //working:
        //[0] = 1 //low bits
        //[3] = 131072

        //
    }
}
