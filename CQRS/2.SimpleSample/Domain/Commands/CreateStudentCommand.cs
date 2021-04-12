using MediatR;

namespace CQRS.SimpleSample.Domain.Commands
{
    public class CreateStudentCommand : IRequest<CreateStudentResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}