using ims.CoreEntities;
using ims.UseCases.PluginsInterfaces;

namespace ims.Plugins.inMomery
{
    public class InventoryRepository : IInventoryRepository
    {
        public Task<IEnumerable<Inventory>> GetInventorieByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }

}
