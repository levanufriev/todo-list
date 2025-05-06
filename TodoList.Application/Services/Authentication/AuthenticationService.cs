using TodoList.Application.Common.Interfaces.Authentication;
using TodoList.Application.Common.Interfaces.Persistance;
using TodoList.Domain.Entities;

namespace TodoList.Application.Services.Authentication;

public class AuthenticationService(IJwtTokenGenerator jwtTokenGenerator,
    IUserRepository userRepository) : IAuthenticationService
{
    public async Task<AuthenticationResult> Login(string email, string password)
    {
        if (await userRepository.GetUserByEmail(email) is not User user)
        {
            throw new Exception("User does not exist");
        }

        if (user.Password !=  password)
        {
            throw new Exception("Invalid password");
        }

        var token = jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user, token);
    }

    public async Task<AuthenticationResult> Register(string firstName, string lastName, string email, string password)
    {
        if (await userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User already exists");
        }

        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };

        await userRepository.Add(user);

        var token = jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user, token);
    }
}
