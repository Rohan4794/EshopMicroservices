using MediatR;

namespace BuildingBlocks.CQRS
{

    public interface ICommand : ICommand<Unit>
    {
        // This is for without response.
    }
    public interface ICommand<out TResponse>:IRequest<TResponse>
    {
        // This for Generic Response.
    }
}
