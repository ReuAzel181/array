Console.Write("Enter a number of user: ");
int usernum = Convert.ToInt32(Console.ReadLine());

string[] emails = new string[usernum];
string[] uname = new string[usernum];
string[] pword = new string[usernum];



Console.Write("Enter first email: ");
string[] userinput = Console.ReadLine();

Console.Write("Enter first email: ");
string[] userinputone = Console.ReadLine();

for (int i = 0; i < usernum; i++)
{
    emails[i] = userinput[i];

   
    for (int k = 0; k < uname.Length; k++)
    {
        uname[k] = userinputone[k];
    }    
}


Console.Write("Enter a number: ");
int j = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Index: " +  j);
Console.WriteLine("Email: " + emails[j]);
Console.WriteLine("Username: " + uname[j]);
Console.WriteLine("Password: " + pword[j]);