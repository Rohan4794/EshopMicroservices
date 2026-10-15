using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, Unit>
        where TCommand : ICommand<Unit>
    {
        // This is non Generic Command Handler.
        // Boxing the TCommand to Response inherit ICommand which is furthur inherited from IRequest
    }
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
        where TResponse : notnull
    {
        // This if for Generic Command Handler having both Request and Response.
        // Here need to to boxing of TCommand (Request) to Response so making it to inherit ICommand Request which is further inherited from IRequest.
    }
}