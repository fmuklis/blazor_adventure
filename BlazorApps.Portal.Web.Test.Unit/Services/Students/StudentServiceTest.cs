using BlazorApps.Brokers.API;
using BlazorApps.Brokers.Logging;
using BlazorApps.Models.Students;
using BlazorApps.Services.Students;
using Castle.Core.Resource;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tynamix.ObjectFiller;

namespace BlazorApps.Test.Unit.Services.Students;
public partial class StudentServiceTest
{
    private readonly Mock<IApiBroker> _apiBrokerMock;
    private readonly Mock<ILoggingBroker> _loggingBrokerMock;
    private readonly IStudentService _studentService;

    public StudentServiceTest()
    {
        _apiBrokerMock = new Mock<IApiBroker>();
        _loggingBrokerMock = new Mock<ILoggingBroker>();
        _studentService = new StudentService(_apiBrokerMock.Object, _loggingBrokerMock.Object);
    }

    private static Student CreateRandomStudent() =>
        CreateStudentFiller().Create();
    private static Filler<Student> CreateStudentFiller()
    {
        var filler = new Filler<Student>();

        filler.Setup()
            .OnType<DateTimeOffset>().Use(DateTimeOffset.UtcNow);

        return filler;
    }
}
