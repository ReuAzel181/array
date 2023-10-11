Console.Write("Enter a number of users: ");
int usernum = Convert.ToInt32(Console.ReadLine());

string[] emails = new string[usernum];
string[] uname = new string[usernum];
string[] pword = new string[usernum];

for (int i = 0; i < usernum; i++)
{
    Console.Write("Enter email for user " + (i + 1) + ": ");
    string? userInputEmail = Console.ReadLine();
    if (userInputEmail != null)
    {
        emails[i] = userInputEmail;
    }

    Console.Write("Enter username for user " + (i + 1) + ": ");
    string? userInputUsername = Console.ReadLine();
    if (userInputUsername != null)
    {
        uname[i] = userInputUsername;
    }

    Console.Write("Enter password for user " + (i + 1) + ": ");
    string? userInputPassword = Console.ReadLine();
    if (userInputPassword != null)
    {
        pword[i] = userInputPassword;
    }
}

Console.Write("Enter a number: ");
int j = Convert.ToInt32(Console.ReadLine());

if (j >= 0 && j < usernum)
{
    Console.WriteLine("Index: " + j);
    Console.WriteLine("Email: " + emails[j]);
    Console.WriteLine("Username: " + uname[j]);
    Console.WriteLine("Password: " + pword[j]);
}
else
{
    Console.WriteLine("Invalid index. Please enter a valid index between 0 and " + (usernum - 1));
}
