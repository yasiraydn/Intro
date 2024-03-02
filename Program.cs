// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 10000.5;

bool isAuthenticated = true;
//variebles --> camelCase

Console.WriteLine(message1);
Console.WriteLine(term);
Console.WriteLine(amount);
Console.WriteLine(isAuthenticated);


//condition
if (isAuthenticated == true)
{
    Console.WriteLine("Hoşgeldiniz");
}
else
{
    Console.WriteLine("Giriş yapınız");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3" };
//string[] loans2 = new string[5];
//loans2[0] = "Kredi 1";

    //start     condition         increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}
