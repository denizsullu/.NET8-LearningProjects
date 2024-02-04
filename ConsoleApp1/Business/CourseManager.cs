using ConsoleApp1.Entities;

namespace ConsoleApp1.Business;

public class CourseManager
{
    private Course[] courses = new Course[2];
    public CourseManager()
    {
        Console.WriteLine("başladı");
        Course course1 = new();
        course1.Id = 5;
        course1.Description = "deneme";
        course1.Name = "deniz";
        course1.Price = 299;
        Course course2 = new();
        course2.Id = 2;
        course2.Description = "deneme2";
        course2.Name = "denizce";
        course2.Price = 500;
        courses[0] = course1;
        courses[1] = course2;

    }
    public Course[] GetAll()
    {
        return courses;
    }
}