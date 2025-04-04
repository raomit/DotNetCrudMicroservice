using DotNetCrudMicroservice.DBContexts;
using DotNetCrudMicroservice.Models;
using DotNetCrudMicroservice.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudMicroservice.Repositories.RepositoryImplementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly CrudDbContext _dbContext;

        public StudentRepository(CrudDbContext dbContext) {
            _dbContext = dbContext;
        }
        public Student? GetById(int id)
        {
            Student? studentById = (from student in _dbContext.Students
                                  where student.StudentId == id
                                  select student).FirstOrDefault();
            return studentById;
        }
    }
}
