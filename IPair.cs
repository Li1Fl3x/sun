using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sun
{
    internal interface IPair
    {
       double A { get; set;}   
        double B { get; set;}
        IPair Add(IPair p);
        IPair Sub(IPair p);
        IPair Mult(IPair p);
        IPair Div(IPair p);
        bool Equ(IPair p);

    }
}
