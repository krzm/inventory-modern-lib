using Core;
using Core.Lib;
using Inventory.Data;
using Unity;

namespace Inventory.Modern.Lib;

public class AppDatabase : UnityDependencyProvider
{
    public AppDatabase(
        IUnityContainer container) 
            : base(container)
    {
    }

    public override void RegisterDependencies()
    {
        Container.RegisterSingleton<InventoryContext>();

        Container.RegisterSingleton<IGenericRepository<Item>, EFGenericRepository<Item, InventoryContext>>();
        Container.RegisterSingleton<IGenericRepository<ItemCategory>, EFGenericRepository<ItemCategory, InventoryContext>>();
        Container.RegisterSingleton<IGenericRepository<ItemDetail>, EFGenericRepository<ItemDetail, InventoryContext>>();
        Container.RegisterSingleton < IGenericRepository<ItemImage>, EFGenericRepository<ItemImage, InventoryContext>>();
        Container.RegisterSingleton < IGenericRepository<Stock>, EFGenericRepository<Stock, InventoryContext>>();
        Container.RegisterSingleton < IGenericRepository<StockDetail>, EFGenericRepository<StockDetail, InventoryContext>>();

        Container.RegisterSingleton<IInventoryUnitOfWork, InventoryUnitOfWork>();
    }
}
