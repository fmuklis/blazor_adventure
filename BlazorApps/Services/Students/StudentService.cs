// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using BlazorApps.Brokers.API;
using BlazorApps.Brokers.Logging;
using BlazorApps.Models.Students;
using System.Threading.Tasks;

namespace BlazorApps.Services.Students;

public partial class StudentService : IStudentService
{
    private readonly IApiBroker _apiBroker;
    private readonly ILoggingBroker _loggingBroker;

    public StudentService(IApiBroker apiBroker, ILoggingBroker loggingBroker)
    {
        _apiBroker = apiBroker;
        _loggingBroker = loggingBroker;
    }

    public ValueTask<Student> RegisterStudentAsync(Student student) =>
        TryCatch(async () =>
        {
            ValidateStudent(student);

            return await _apiBroker.PostStudentAsync(student);
        });
}
