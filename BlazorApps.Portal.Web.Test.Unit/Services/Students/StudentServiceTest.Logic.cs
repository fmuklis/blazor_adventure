// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using BlazorApps.Models.Students;
using FluentAssertions;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace BlazorApps.Test.Unit.Services.Students;
public partial class StudentServiceTest
{
    [Fact]
    public async Task ShouldRegisterStudentAsync()
    {
        // given
        Student randomStudent = CreateRandomStudent();
        Student inputStudent = randomStudent;
        Student retrivedStudent = inputStudent;
        Student expectedStudent = retrivedStudent;

        _apiBrokerMock.Setup(broker =>
            broker.PostStudentAsync(inputStudent))
                .ReturnsAsync(retrivedStudent);
        // when
        Student actualStudent = await _studentService.RegisterStudentAsync(inputStudent);

        // then
        actualStudent.Should().BeEquivalentTo(expectedStudent);

        _apiBrokerMock.Verify(broker =>
            broker.PostStudentAsync(inputStudent),
                Times.Once());
    }
}
