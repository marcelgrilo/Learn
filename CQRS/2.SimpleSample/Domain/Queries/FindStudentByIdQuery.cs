using MediatR;

namespace CQRS.SimpleSample.Domain.Queries
{
    public class FindStudentByIdQuery: IRequest<FindStudentByIdResponse>
    {
        public string Id { get; set; }
    }
}