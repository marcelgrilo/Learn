using MediatR;

namespace CQRS.SimpleSample.Domain.Commands
{
    public class CreateStudentResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}