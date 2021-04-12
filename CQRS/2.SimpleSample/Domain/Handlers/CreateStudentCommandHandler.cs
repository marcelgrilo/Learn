using System.Threading;
using System.Threading.Tasks;
using CQRS.SimpleSample.Domain.Commands;
using MediatR;

namespace CQRS.SimpleSample.Domain.Handlers
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, CreateStudentResponse>
    {
        public Task<CreateStudentResponse> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            // validações failfast
            //   checkagens no comando, checkagens no banco, etc
            // cria a entidade
            // persiste a entidade
            // dispara eventos
            // retorna resposta
            var response =  new CreateStudentResponse {
                Id="123",
                Name=request.Name
            };
            return Task.FromResult(response);
        }
    }
}