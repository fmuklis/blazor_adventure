// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using BlazorApps.Models.Students;
using BlazorApps.Models.Students.Exceptions;
using Moq;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xunit;

namespace BlazorApps.Test.Unit.Services.Students;
public partial class StudentServiceTest
{
    [Fact]
    public async Task ShouldThrowValidationExceptionOnRegisterIfStudentIsNullAndLogItAsync()
    {
        // given
        Student invalidStudent = null;
        var nullStudentException = new NullStudentException();

        var expectedStudentValidationException =
            new StudentValidationException(nullStudentException);

        // when
        ValueTask<Student> submitStudentTask =
            _studentService.RegisterStudentAsync(invalidStudent);

        //then
        await Assert.ThrowsAsync<StudentValidationException>(() => submitStudentTask.AsTask());

        _loggingBrokerMock.Verify(broker =>
            broker.LogError(
                It.Is(SameExceptionAs(expectedStudentValidationException))),
                    Times.Once);

        _apiBrokerMock.Verify(broker =>
            broker.PostStudentAsync(It.IsAny<Student>()), Times.Never);

        _loggingBrokerMock.VerifyNoOtherCalls();
        _apiBrokerMock.VerifyNoOtherCalls();
    }

}
