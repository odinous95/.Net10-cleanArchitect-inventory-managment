using ims.CoreEntities;
using ims.UseCases.PluginsInterfaces;

namespace ims.Plugins.inMomery
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;
        public InventoryRepository()
        {
            _inventories = new List<Inventory>
            {
                new Inventory { Id = 1, Name = "Car", Quantity = 10  , Price = 15.5 },
                new Inventory { Id = 2, Name = "Motors", Quantity = 5 , Price = 25.0 },
            };
        }
        public async Task<IEnumerable<Inventory>> GetInventorieByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);
            
            return _inventories.Where(i => i.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

        }
    }

}
