namespace Userr;

public class User{


    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName  { get; set; }
    public int Password { get; set; }
        List<User> _user;
       
    public void GetInfo(){
          System.Console.WriteLine($"{FirstName}");
           System.Console.WriteLine($"{LastName}");
            System.Console.WriteLine($"{UserName}");
             System.Console.WriteLine($"{Password}");
         }
         public void Login(string a,int b){
            if(a==UserName&&b==Password){
                System.Console.WriteLine($"Login successful! Welcome mr {FirstName} , {LastName}");
            }else{
                System.Console.WriteLine("Login Failed");
            }
         }
    }