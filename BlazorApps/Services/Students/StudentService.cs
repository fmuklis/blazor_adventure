// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using BlazorApps.Brokers.API;
using BlazorApps.Brokers.Logging;
using BlazorApps.Models.Students;
using System.Threading.Tasks;

namespace BlazorApps.Services.Students;

public class StudentService : IStudentService
{
    private readonly IApiBroker _apiBroker;
    private readonly ILoggingBroker _loggingBroker;

    public StudentService(IApiBroker apiBroker, ILoggingBroker loggingBroker)
    {
        _apiBroker = apiBroker;
        _loggingBroker = loggingBroker;
    }

    public async ValueTask<Student> RegisterStudentAsync(Student student) =>
        await _apiBroker.PostStudentAsync(student);
}
