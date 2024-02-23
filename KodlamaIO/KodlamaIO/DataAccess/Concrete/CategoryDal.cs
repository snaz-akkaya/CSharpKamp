using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concrete;

public class CategoryDal : ICategoryDal
{
    private List<Category> _categories;
    private object _courses;

    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void AddCourseToCategory(Category category, int courseId)
    {
        if (!_categories.Contains(category))
        {
            Console.WriteLine("Category does not exist. Please add the category first.");
        }
        else
        {
            if (!category.CourseId.Contains(courseId))
            {
                Console.WriteLine("The course already exists in the category.");
            }
            else
            {
                category.CourseId.Add(courseId);
            }


        }

    }

    public void Delete(Category category)
    {
        _categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public void Update(Category category, int? id = null, string name = null, string description = null)
    {
        if (_categories.Contains(category))
        {
            if (id != null)
            {
                category.Id = (int)id;
                Console.WriteLine("Category ID is used to change.");
            }
            else if (name != null)
            {
                category.Name = name;
                Console.WriteLine("Category name is used to change.");
            }
            else if (description != null)
            {
                category.Description = description;
                Console.WriteLine("Category descrption is used to changed");
            }
            else
            {
                Console.WriteLine("No property is used to change.");
            }
        }
        else
        {
            Console.WriteLine("This category is not exist is data base. Firstly add the course into database.");
        }
    }
}

