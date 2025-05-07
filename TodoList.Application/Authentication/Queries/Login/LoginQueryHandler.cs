using ErrorOr;
using MediatR;
using TodoList.Application.Common.Interfaces.Authentication;
using TodoList.Application.Common.Interfaces.Persistance;
using TodoList.Domain.Entities;
using TodoList.Domain.Common.Errors;
using TodoList.Application.Authentication.Common;

namespace TodoList.Application.Authentication.Queries.Login;

public class LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator,
    IUserRepository userRepository) : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        if (await userRepository.GetUserByEmail(query.Email) is not User user)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        if (user.Password != query.Password)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        var token = jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user, token);
    }
}
