// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using BlazorApps.Models.Students;
using System.Threading.Tasks;

namespace BlazorApps.Brokers.API;

public partial interface IApiBroker
{
    ValueTask<Student> PostStudentAsync(Student student);
}
