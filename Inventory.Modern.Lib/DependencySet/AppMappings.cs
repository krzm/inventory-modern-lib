using AutoMapper;
using Inventory.Data;
using Unity;

namespace Inventory.Modern.Lib;

public class AppMappings 
    : ModelHelper.AppMappings
{
    public AppMappings(
        IUnityContainer container)
        : base(container)
    {
    }

    protected override MapperConfiguration CreateMap() =>
        new (
        c => 
        {
            c.CreateMap<ItemInsertArgs, Item>();
            c.CreateMap<ContainerInsertArgs, Container>();
            c.CreateMap<CategoryInsertArgs, Category>();
            c.CreateMap<SizeInsertArgs, Size>();
            c.CreateMap<ImageInsertArgs, Image>();
            c.CreateMap<StockInsertArgs, Stock>();
            c.CreateMap<StockCountInsertArgs, StockCount>();
            c.CreateMap<StateInsertArgs, State>();

            c.CreateMap<ItemUpdateArg, ItemUpdate>();
            c.CreateMap<CategoryArgUpdate, CategoryUpdate>();
            c.CreateMap<SizeArgUpdate, SizeUpdate>();
            c.CreateMap<ImageArgUpdate, ImageUpdate>();
            c.CreateMap<StockArgUpdate, StockUpdate>();
        });
}