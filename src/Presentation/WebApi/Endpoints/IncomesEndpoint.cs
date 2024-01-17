

using CashFlow.Application.UseCases.Incomes;

namespace CashFlowBalanceSheet.Presentation.WebApi.Endpoints;



public class IncomesEndpoint : Endpoint<IncomeCreateRequest, IncomeCreateResponse>
{

    public override Task<IncomeCreateResponse> ExecuteAsync(IncomeCreateRequest req, CancellationToken ct)
    {
        return Task.FromResult(new IncomeCreateResponse());
    }
}
