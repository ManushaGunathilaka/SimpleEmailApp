using SimpleEmailApp.Models;

namespace SimpleEmailApp.Services.BuyerService
{
    public class BuyerService : IBuyerService
    {
        private static List<BuyerDto> buyerDtos = new List<BuyerDto>
        {
            new BuyerDto { Id = 1,Name="Manusha",Email="bhmmpmgunathilake1999@gmail.com"},
            new BuyerDto { Id = 2,Name="Gunathilaka",Email="manu@gmail.com"}
        };

        public List<BuyerDto> GetAllBuyers()
        {
            return buyerDtos;
        }

        public BuyerDto? GetSingleBuyer(int id)
        {
            var buyer = buyerDtos.Find(x => x.Id == id);
            if (buyer == null)
            {
                return null;
            }
            return buyer;
        }
    }
}
