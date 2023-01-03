// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using BlazorApps.Models.Students;
using BlazorApps.Models.Students.Exceptions;
using FluentAssertions.Specialized;
using System;
using System.Threading.Tasks;

namespace BlazorApps.Services.Students;

public partial class StudentService
{
    private delegate ValueTask<Student> ReturningStudentFunction();

    private async ValueTask<Student> TryCatch(ReturningStudentFunction returningStudentFunction)
    {
		try
		{
			return await returningStudentFunction();
		}
		catch (NullStudentException nullStudentException)
		{

			throw CreateAndLogValidationException(nullStudentException);
		}
    }

    private StudentValidationException CreateAndLogValidationException(Exception nullStudentException)
    {
        var studentValidationException = new StudentValidationException(nullStudentException);

        _loggingBroker.LogError(studentValidationException);

        return studentValidationException;
    }
}
