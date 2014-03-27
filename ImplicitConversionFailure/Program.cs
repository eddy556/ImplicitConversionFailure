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
        }

        public static int Precision(Decimal number)
        {
            int bits = Decimal.GetBits(number)[3];
            var bytes = BitConverter.GetBytes(bits)[2];

            return bytes;
        }

        //broken (cast):
        //[0] = 10 //low bits
        //[3] = 196608 = scale factor and sign

        //working:
        //[0] = 1 //low bits
        //[3] = 131072 = scale factor and sign
        //
    }
}
