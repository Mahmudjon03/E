using Calcullator;

var calculator=new Calculator(4,5);

char n;
    n = char.Parse(Console.ReadLine());
if(n=='+'){
  calculator.Summ(); 
}else if(n=='-'){
    System.Console.WriteLine(calculator.Subtract());
}else if(n=='*'){
    System.Console.WriteLine(calculator.Multiplication());
}else if(n=='/'){
    System.Console.WriteLine(calculator.Division());
}




