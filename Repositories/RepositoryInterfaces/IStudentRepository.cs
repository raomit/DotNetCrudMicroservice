using DotNetCrudMicroservice.Models;

namespace DotNetCrudMicroservice.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        public Student? GetById(int id);
    }
}
