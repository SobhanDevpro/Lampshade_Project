using InventoryManagement.Application.Contracts.Inventory;

namespace InventoryManagement.Application.Contracts.Inventory
{
    public class EditInventory : CreateInventory
    {
        public long Id { get; set; }
    }
}
