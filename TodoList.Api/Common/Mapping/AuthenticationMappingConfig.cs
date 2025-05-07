using Mapster;
using TodoList.Application.Authentication.Common;
using TodoList.Contracts.Authentication;

namespace TodoList.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}
