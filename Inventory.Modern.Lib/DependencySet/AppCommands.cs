using CRUDCommandHelper;
using DIHelper.Unity;
using Unity;

namespace Inventory.Modern.Lib;

public class AppCommands 
    : UnityDependencySet
{
    public AppCommands(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container
            .RegisterSingleton<IReadCommand<ItemReadArg>, ItemReadCommand>()
            .RegisterSingleton<IReadCommand<CategoryArgFilter>, CategoryReadCommand>()
            .RegisterSingleton<IReadCommand<SizeArgFilter>, SizeReadCommand>()
            .RegisterSingleton<IReadCommand<ImageArgFilter>, ImageReadCommand>()
            .RegisterSingleton<IReadCommand<StockArgFilter>, StockReadCommand>()
            .RegisterSingleton<IReadCommand<SizeArgFilter>, SizeReadCommand>()

            .RegisterSingleton<IInsertCommand<ItemInsertArgs>, ItemInsertCommand>()
            .RegisterSingleton<IInsertCommand<ContainerInsertArgs>, ContainerInsertCommand>()
            .RegisterSingleton<IInsertCommand<CategoryInsertArgs>, CategoryInsertCommand>()
            .RegisterSingleton<IInsertCommand<SizeInsertArgs>, SizeInsertCommand>()
            .RegisterSingleton<IInsertCommand<ImageInsertArgs>, ImageInsertCommand>()
            .RegisterSingleton<IInsertCommand<StockInsertArgs>, StockInsertCommand>()
            .RegisterSingleton<IInsertCommand<SizeInsertArgs>, SizeInsertCommand>()
            .RegisterSingleton<IInsertCommand<StockCountInsertArgs>, StockCountInsertCommand>()

            .RegisterSingleton<IUpdateCommand<ItemUpdateArg>, ItemUpdateCommand>()
            .RegisterSingleton<IUpdateCommand<CategoryArgUpdate>, CategoryUpdateCommand>()
            .RegisterSingleton<IUpdateCommand<SizeArgUpdate>, SizeUpdateCommand>()
            .RegisterSingleton<IUpdateCommand<ImageArgUpdate>, ImageUpdateCommand>()
            .RegisterSingleton<IUpdateCommand<StockArgUpdate>, StockUpdateCommand>()
            .RegisterSingleton<IUpdateCommand<SizeArgUpdate>, SizeUpdateCommand>()

            .RegisterSingleton<IStockContainerInsertCommand, StockContainerInsertCommand>();
    }
}