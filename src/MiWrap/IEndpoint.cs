using Microsoft.AspNetCore.Routing;

namespace MiWrap;

public interface IEndpoint
{
    void MapEndpoint(IEndpointRouteBuilder builder);
}