using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ims.CoreEntities;
using ims.UseCases.PluginsInterfaces;


namespace IMS.UseCases.Inventories
{
    public class ViewInventoriesUseCase
    {   
        private readonly IInventoryRepository inventoryRepository;
        public ViewInventoriesUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventorieByNameAsync(name);
        }

    }
}

