using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    void Delete(Course course);
    void Update(Course course, int? id = null, string name = null, string 
        description = null, DateTime? updatedDate = null);


}

