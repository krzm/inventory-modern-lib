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
            c.CreateMap<CategoryArg, Category>();
            c.CreateMap<SizeArgs, Size>();
            c.CreateMap<ImageArg, Image>();
            c.CreateMap<StockArg, Stock>();

            c.CreateMap<ItemUpdateArg, ItemUpdate>();
            c.CreateMap<CategoryArgUpdate, CategoryUpdate>();
            c.CreateMap<SizeArgUpdate, SizeUpdate>();
            c.CreateMap<ImageArgUpdate, ImageUpdate>();
            c.CreateMap<StockArgUpdate, StockUpdate>();
        });
}