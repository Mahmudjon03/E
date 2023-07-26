using System;

namespace Calcullator;

public class Calculator
{            int x ;
    public int y ;
public Calculator(int _x,int _y)
{    x=_x;
       y=_y;
}
public void Summ(){
    System.Console.WriteLine( x+y);
    }

public int Subtract(){
    return x-y;
}
public int Multiplication(){
    return x*y;
}public int Division(){
    return x/y;
}

}



