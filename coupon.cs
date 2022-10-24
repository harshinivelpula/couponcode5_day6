using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace couponcoded6
{
    internal class coupon
    {
        public class CoupenCode
        {
            public static void main(String[] args)
            {
                char[] chars = "abcdefgh".ToCharArray();
                int max = 100000000;
                double d = Math.random();
                int random = (int)(d * max);
                String sb = "";
                Console.WriteLine("random double " + d + " random at start " + random);

                while (random > 0)
                {
                    sb = sb + (chars[random % chars.Length]);
                    random /= chars.Length;
                    Console.WriteLine(random + "  " + random % chars.Length + " sb is " + sb);
                }
                String couponCode = sb.ToString();
                Console.WriteLine("Coupon Code: " + couponCode);
            }
        }
    }
}
