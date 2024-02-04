// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Entities;

Console.WriteLine("Hello, World! deniz");
Console.WriteLine("deneme ilk yorum .NET heyooo");

string message = "krediler";
string message2 = "krediler2";
int term = 12;
double amont = 1000;
bool isAuthenticated = true;
// variables --> camelCase 
Console.WriteLine(isAuthenticated);

// condition

if (isAuthenticated)
{
    Console.WriteLine("Hoşgeldin engin");
}
else
{
    Console.WriteLine("sisteme giriş yap");
}
string[] loans = {"kredi1","kredi2","kredi3","kredi4","kredi5","kredi6"};
string[] loans2 = new string[2];

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".Net 8";
course1.Price = 100;

Course[] courses = {course1};

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}