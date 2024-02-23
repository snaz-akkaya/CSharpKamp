using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstract;

public interface ICategoryDal
{
    List<Category> GetAll();
    void Add(Category course);
    void AddCourseToCategory(Category category, int courseId);
    void Delete(Category course);
    void Update(Category category, int? id = null, string name = null, string description = null);
}

