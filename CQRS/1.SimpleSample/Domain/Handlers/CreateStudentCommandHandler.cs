using CQRS.SimpleSample.Domain.Commands;

namespace CQRS.SimpleSample.Domain.Handlers
{
    public interface ICreateStudentCommandHandler
    {
        CreateStudentCommand Handle(CreateStudentCommand createStudentCommand);
    }

    public class CreateStudentCommandHandler : ICreateStudentCommandHandler
    {
        public CreateStudentCommand Handle(CreateStudentCommand createStudentCommand)
        {
            // validações failfast
            //   checkagens no comando, checkagens no banco, etc
            // cria a entidade
            // persiste a entidade
            // dispara eventos sync
            // dispara evenos ou async
            // retorna resposta
            return new CreateStudentCommand {
                Id="123",
                Name=createStudentCommand.Name
            };
        }
    }
}