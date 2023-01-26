using sun;

Complex g1 = new Complex(1, 2);
Complex g2 = new Complex(2, 3);
Complex g3 = (Complex)g1.Add(g2);
Console.WriteLine(g3);
Complex g4 = (Complex)g1.Sub(g2);
Console.WriteLine(g4);
Complex g5 = (Complex)g1.Mult(g2);
Console.WriteLine(g5);
Complex g6 = (Complex)g1.Div(g2);
Console.WriteLine(g6);
Console.WriteLine(g1.Equ(g2));