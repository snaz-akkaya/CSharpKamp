using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstract;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    void Add(Instructor instructor);
    void Delete(Instructor instructor);
    void Update(Instructor instructor, int? id = null, string firstName = null, string lastName = null, string profession = null);
}

