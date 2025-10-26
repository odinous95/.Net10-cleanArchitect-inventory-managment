using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ims.CoreEntities;


namespace IMS.UseCases.Inventories
{
    public class ViewInventoriesUseCase
    {
        public IEnumerable<Inventory> ExecuteAsync(string name = "");

    }
}

