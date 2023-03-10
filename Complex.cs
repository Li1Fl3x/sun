using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sun
{
    internal class Complex : IPair
    {
        public double A { get; set; }
        public double B { get; set; }

        public Complex(double a, double b)
        {
            A = a;
            B = b;
        }

        public IPair Add(IPair p)
        {
            return new Complex(this.A + p.A, this.B + p.B);
        }

        public IPair Div(IPair p)
        {
            return new Complex((this.A * p.A + this.B * p.B) / (p.A * p.A + p.B * p.B),
               (this.A * p.B + this.B * p.A) / (p.A * p.A + p.B * p.B));
        }

        public bool Equ(IPair p)
        {
            return (this.A == p.A && this.B == p.B);
        }

        public IPair Mult(IPair p)
        {
            return new Complex(this.A * p.A - this.B * p.B, this.A * p.B + p.A * this.B);
        }

        public IPair Sub(IPair p)
        {
            return new Complex(this.A - p.A, this.B - p.B);
        }
        public override string? ToString()
        {
            if (B > 0)
                return A + "+" + B + "i";
            else if (B < 0)
                return A + "-" + Math.Abs(B) + "i";
            return A.ToString();
        }
    }
}
