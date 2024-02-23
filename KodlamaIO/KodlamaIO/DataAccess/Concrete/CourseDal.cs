using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concrete;

public class CourseDal : ICourseDal
{
    private List<Course> _courses;

    public void Add(Course course)
    {
        _courses.Add(course);
    }
    public void Delete(Course course)
    {
        _courses.Remove(course);
    }

    public List<Course> GetAll()
    {
        return _courses;
    }


    public void Update(Course course, int? id = null, string name = null, string
        description = null, DateTime? updatedDate = null)
    {
        if (_courses.Contains(course))
        {
            if (id != null)
            {
                course.Id = (int)id;
                Console.WriteLine("Course ID is used to change.");
            }
            else if (name != null)
            {
                course.Name = name;
                Console.WriteLine("Course Name is used to change.");
            }
            else if (description != null)
            {
                course.Description = description;
                Console.WriteLine("Course name is used to changed");
            }
            else if (updatedDate != null)
            {
                course.UpdatedDate = (DateTime)updatedDate;
                Console.WriteLine("Course update time is used to change.");
            }
            else
            {
                Console.WriteLine("No property is used to change.");
            }
        }
        else
        {
            Console.WriteLine("This course is not exist is data base. Firstly add the course into database.");
        }

    }
}

