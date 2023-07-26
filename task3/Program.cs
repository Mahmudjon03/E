using Calcullator;

var calculator=new Calculator(4,5);

string n = Console.ReadLine();
if(n=="+"){
   System.Console.WriteLine(calculator.Summ()); 
}else if(n=="-"){
    System.Console.WriteLine(calculator.Subtract());
}else if(n=="*"){
    System.Console.WriteLine(calculator.Multiplication());
}else if(n=="/"){
    System.Console.WriteLine(calculator.Division());
}



