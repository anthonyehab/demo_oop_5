using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_5
{
    internal class complex
    {
        public int real { get; set; }
        public int imag { get; set; }

        public override string ToString()
        {
            return $"{real}+{imag}";
        }
        #region operators overloading
        //public static complex operator + (complex left , complex right)

        //{
        //    return new complex()
        //    {
        //        real= (left?.real ?? 0)+(right?.real ?? 0),
        //        imag= (left?.imag ?? 0)+(right?.imag ?? 0)

        //    };


        //}
        //public static complex operator - (complex left, complex right)

        //{
        //    return new complex()
        //    {
        //        real = (left?.real ?? 0) - (right?.real ?? 0),
        //        imag = (left?.imag ?? 0) - (right?.imag ?? 0)
        //    };


        //}
        //public static complex operator ++(complex c)

        //{
        //    return new complex()
        //    {
        //        real = (c?.real ?? 0) + 1,
        //        imag = (c?.imag ?? 0) 
        //    };


        //}

        //public static complex operator --(complex c)

        //{
        //    return new complex()
        //    {
        //        real = (c?.real ?? 0) - 1,
        //        imag = (c?.imag ?? 0)
        //    };


        //}

        //public static bool operator < (complex left, complex right)

        //{

        //       if (left.real == right.real)
        //        return left.imag < right.imag;
        //    else
        //        return left.real < right.real;

        //}



    }
    #endregion
        #region casting operators overloading
    //public static  explicit operator int (complex c)
    //    {
    //    return c?.real ?? 0;
        
    //    }

    //public static implicit operator string(complex c)
    //{
    //    return c.ToString() ?? string.Empty ;

    //}

    #endregion

}
