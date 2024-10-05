
const string USERNAME = "Lilo";
const string PASSWORD = "password";

Console.WriteLine("Welcome to the Simple Login System!");
string username;
string password;
string generatedOTP;
while (true)
{
    Console.WriteLine("Please enter your username");
    username = Console.ReadLine();

    Console.WriteLine("Now enter your password");
    password = Console.ReadLine();


    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
    {
        Console.WriteLine("Username or password cannot be empty.");
        continue;
    }
    break;
}

if (username == USERNAME && password == PASSWORD)
{
    generatedOTP = GenerateOTP();
    Console.WriteLine($"Your 6-digit OTP is {generatedOTP}\nplease enter your OTP.");
    string userOTP = Console.ReadLine();
    if (userOTP == generatedOTP)
        Console.WriteLine("Success! You are logged in.");
    else
        Console.WriteLine("Invalid OTP. Access denied.");
}
else
{
    Console.WriteLine("Invalid username or password. Access denied.");
}


string GenerateOTP()
{
    return new Random().Next(100_000, 999_999).ToString();
}
