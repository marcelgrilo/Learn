using CQRS.SimpleSample.Domain.Queries;

namespace CQRS.SimpleSample.Domain.Handlers
{
    public interface IFindStudentByIdQueryHandler
    {
        FindStudentByIdResponse Handle(FindStudentByIdQuery createStudentCommand);
    }

    public class FindStudentByIdQueryHandler : IFindStudentByIdQueryHandler
    {
        public FindStudentByIdResponse Handle(FindStudentByIdQuery query)
        {
            // validações failfast
            //   checkagens na query e seus parametros
            // busca na base
            // retorna resposta
            return new FindStudentByIdResponse {
                Id=query.Id,
                Name="macelgrilo"
            };
        }
    }
}