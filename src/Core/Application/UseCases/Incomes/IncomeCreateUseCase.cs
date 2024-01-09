
namespace CashFlowBalanceSheet.Application.UseCases.Incomes;

public class IncomeCreateRequest
{
}

public class IncomeCreateResponse
{
}

public class IncomeCreateUseCase : UseCase<IncomeCreateRequest, IncomeCreateResponse>
{
    public override Task<IncomeCreateResponse> Execute(IncomeCreateRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
