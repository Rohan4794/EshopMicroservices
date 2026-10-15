using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface IQueryHandler<in TQuery,TResponse>:IRequestHandler<TQuery,TResponse>
        where TQuery : IQuery<TResponse>
        where TResponse:notnull
    {
        // This is the Query Handler having Query request and response.
        //Bozing the TQuery to inherit IQyery response further inheriting the IRequest.
    }
}
