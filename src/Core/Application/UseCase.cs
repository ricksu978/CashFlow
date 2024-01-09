namespace CashFlowBalanceSheet.Application;

public abstract class UseCase<TRequest, TResponse>
    where TRequest : class
    where TResponse : class
{
    public abstract Task<TResponse> Execute(TRequest request, CancellationToken cancellationToken = default);
}
