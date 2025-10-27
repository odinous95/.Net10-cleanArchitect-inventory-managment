using ims.CoreEntities;
namespace ims.UseCases.Inventories.Interfaces
{
    public interface IViewInventoriesUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}