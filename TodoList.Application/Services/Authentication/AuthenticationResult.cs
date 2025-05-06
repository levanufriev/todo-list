using TodoList.Domain.Entities;

namespace TodoList.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
);
