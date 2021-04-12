using System.Threading;
using System.Threading.Tasks;
using CQRS.SimpleSample.Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace CQRS.SimpleSample.Domain.Handlers
{
    public class FindStudentByIdQueryHandler : IRequestHandler<FindStudentByIdQuery, FindStudentByIdResponse>
    {
        public Task<FindStudentByIdResponse> Handle(FindStudentByIdQuery request, CancellationToken cancellationToken)
        {
            // validações failfast
            //   checkagens na query e seus parametros
            // busca na base
            // retorna resposta
            var response =  new FindStudentByIdResponse {
                Id=request.Id,
                Name="macelgrilo"
            };
            return Task.FromResult(response);
        }
    }
}