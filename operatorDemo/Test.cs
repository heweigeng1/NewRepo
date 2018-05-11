using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace operatorDemo
{
    public class Ta
    {
        public BigInteger Age { get; set; }

        public Ta()
        { }

        public Ta(BigInteger age)
        {
            this.Age = age;
        }

        public static Ta operator ^(BigInteger
            c2, Ta stu)
        {
            return new Ta(stu.Age ^ c2);
        }
        
    }
}
