using BlazorApps.Models.Students;
using System.Threading.Tasks;

namespace BlazorApps.Brokers.API;

public partial class ApiBroker
{
    private const string relativeUrl = "api/students";

    public async ValueTask<Student> PostStudentAsync(Student student) =>
        await PostAsync(relativeUrl, student);
}
