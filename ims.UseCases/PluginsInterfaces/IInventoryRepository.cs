using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ims.CoreEntities;

namespace ims.UseCases.PluginsInterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventorieByNameAsync(string name);
    }
}