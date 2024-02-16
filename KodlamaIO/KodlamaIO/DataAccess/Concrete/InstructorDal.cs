using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KodlamaIO.DataAccess.Concrete;

public class InstructorDal : IInstructorDal
{
    private List<Instructor> _instructors;
    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructors.Remove(instructor);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor instructor, int? id = null, string firstName = null, string lastName = null, string profession = null)
    {
        if (_instructors.Contains(instructor))
        {
            if (id != null)
            {
                instructor.Id = (int)id;
                Console.WriteLine("Instructor ID is used to change.");
            }
            else if (firstName != null)
            {
                instructor.FirstName = firstName;
                Console.WriteLine("Instructor first name is used to change.");
            }
            else if (lastName != null)
            {
                instructor.LastName = lastName;
                Console.WriteLine("Instructor last name is used to changed");
            }
            else if (profession != null)
            {
                instructor.Profession = profession;
                Console.WriteLine("Instructor's profession is used to change.");
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

