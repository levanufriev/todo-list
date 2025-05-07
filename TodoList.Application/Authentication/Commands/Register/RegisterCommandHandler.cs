using ErrorOr;
using MediatR;
using TodoList.Application.Authentication.Common;
using TodoList.Application.Common.Interfaces.Authentication;
using TodoList.Application.Common.Interfaces.Persistance;
using TodoList.Domain.Common.Errors;
using TodoList.Domain.Entities;

namespace TodoList.Application.Authentication.Commands.Register;

public class RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator,
    IUserRepository userRepository) : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        if (await userRepository.GetUserByEmail(command.Email) is not null)
        {
            return Errors.User.DuplicateEmail;
        }

        var user = new User
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            Password = command.Password
        };

        await userRepository.Add(user);

        var token = jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user, token);
    }
}
