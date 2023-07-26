  using Userr;
  var list=new List<User>();

var user=new User();
user.FirstName="test";
user.LastName="testov";
user.UserName="abc123";
user.Password=1234;
list.Add(user);


var user1=new User();
user1.FirstName="efef";
user1.LastName="testwefewov";
user1.UserName="abcefe123";
user1.Password=124534;
list.Add(user1);

var user2=new User();
user2.FirstName="teerst";
user2.LastName="testoertv";
user2.UserName="123";
user2.Password=14564;
list.Add(user2);
var user3=new User();
user3.FirstName="test";
user3.LastName="testov";
user3.UserName="a2323";
user3.Password=734;
list.Add(user3);
var user4=new User();
user4.FirstName="te876st";
user4.LastName="tesjhgtov";
user4.UserName="abc";
user4.Password=567;
list.Add(user4);

string a=Console.ReadLine();
int b= Convert.ToInt32(Console.ReadLine);
foreach (var item in list){

if(item.UserName==a && item.Password==b){
   System.Console.WriteLine($"Login successful! Welcome mr {item.FirstName} , {item.LastName}");
            }else{
                System.Console.WriteLine("Login Failed");
            }

}
  




