namespace SimpleEmailApp.Services.BuyerService
{
    public interface IBuyerService
    {
        List<BuyerDto>? GetAllBuyers();
        BuyerDto? GetSingleBuyer(int id);
    }
}
