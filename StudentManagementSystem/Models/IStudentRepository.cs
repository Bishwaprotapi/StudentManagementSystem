using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task<Student> AddStudentAsync(Student student);
        Task<Student> UpdateStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
        Task<IEnumerable<Student>> SearchStudentsAsync(string searchTerm);
    }
} 