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
            var bits = Decimal.GetBits(number)[3];
            var bytes = BitConverter.GetBytes(bits)[2];

            return bytes;

            //return BitConverter.GetBytes(Decimal.GetBits(number)[3])[2];
        }

        //broken (cast):
        //[0] = 10
        //[4] = 196608

        //broken (convert):
        //[0]
        //[4]

        //working:
        //[0] = 1
        //[4] = 131072

        //
    }
}
