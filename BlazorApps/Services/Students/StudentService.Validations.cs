// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using BlazorApps.Models.Students;
using BlazorApps.Models.Students.Exceptions;

namespace BlazorApps.Services.Students;

public partial class StudentService
{
    private void ValidateStudent(Student student)
    {
        if (student is null)
        {
            throw new NullStudentException();
        }
    }
}
