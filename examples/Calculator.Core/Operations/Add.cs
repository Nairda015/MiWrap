using MiWrap;

namespace Calculator.Core.Operations;

public record Add(int A, int B) : IHttpCommand;

public class AddEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
        => builder.MapPost<Add, AddHandler>("add/{a}/{b}")
            .Produces<int>();
}

internal class AddHandler : IHttpCommandHandler<Add>
{
    private readonly ILogger<AddHandler> _logger;

    public AddHandler(ILogger<AddHandler> logger) => _logger = logger;

    public Task<IResult> HandleAsync(Add query, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Adding {A} and {B}", query.A, query.B);
        return Task.FromResult(Results.Ok(query.A + query.B));
    }
}