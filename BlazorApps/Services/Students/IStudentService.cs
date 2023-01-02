using BlazorApps.Models.Students;
using System.Threading.Tasks;

namespace BlazorApps.Services.Students;

public interface IStudentService
{
    ValueTask<Student> RegisterStudentAsync(Student student);
}
