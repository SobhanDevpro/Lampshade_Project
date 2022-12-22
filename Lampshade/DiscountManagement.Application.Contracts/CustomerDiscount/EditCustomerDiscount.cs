using DiscountManagement.Application.Contracts.CustomerDiscount;

namespace DiscountManagement.Application.Contracts.CustomerDiscount 
{
    public class EditCustomerDiscount : DefineCustomerDiscount  
    {
        public long Id { get; set; }
    }
}
