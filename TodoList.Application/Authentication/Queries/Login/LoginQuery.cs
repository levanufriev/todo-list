using ErrorOr;
using MediatR;
using TodoList.Application.Authentication.Common;

namespace TodoList.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
