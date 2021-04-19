﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{

    public class Complex
    {
        public double a; // real number
        public double b; // imaginary number

        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Square()
        {
            double atemp = (a * a) - (b * b);
            b = 2.0 * a * b;
            a = atemp;
        }

        public double Magnitude()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        public void Add(Complex c)
        {
            a += c.a;
            b += c.b;

        }

    }
}
