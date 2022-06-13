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
        RegisterInsertCommand();
        RegisterInsertManyToManyCommand();
        RegisterUpdateCommand();
        RegisterReadCommand();
    }

    private void RegisterInsertCommand()
    {
        Container
            .RegisterSingleton<IInsertCommand<ItemInsertArgs>, ItemInsertCommand>()
            .RegisterSingleton<IInsertCommand<ContainerInsertArgs>, ContainerInsertCommand>()
            .RegisterSingleton<IInsertCommand<CategoryInsertArgs>, CategoryInsertCommand>()
            .RegisterSingleton<IInsertCommand<SizeInsertArgs>, SizeInsertCommand>()
            .RegisterSingleton<IInsertCommand<ImageInsertArgs>, ImageInsertCommand>()
            .RegisterSingleton<IInsertCommand<StockInsertArgs>, StockInsertCommand>()
            .RegisterSingleton<IInsertCommand<SizeInsertArgs>, SizeInsertCommand>()
            .RegisterSingleton<IInsertCommand<StockCountInsertArgs>, StockCountInsertCommand>()
            .RegisterSingleton<IInsertCommand<StateInsertArgs>, StateInsertCommand>();
    }

    private void RegisterInsertManyToManyCommand()
    {
        Container
            .RegisterSingleton<IStockContainerInsertCommand, StockContainerInsertCommand>();
    }

    private void RegisterUpdateCommand()
    {
        Container
                    .RegisterSingleton<IUpdateCommand<ItemUpdateArg>, ItemUpdateCommand>()
                    .RegisterSingleton<IUpdateCommand<CategoryArgUpdate>, CategoryUpdateCommand>()
                    .RegisterSingleton<IUpdateCommand<SizeArgUpdate>, SizeUpdateCommand>()
                    .RegisterSingleton<IUpdateCommand<ImageArgUpdate>, ImageUpdateCommand>()
                    .RegisterSingleton<IUpdateCommand<StockArgUpdate>, StockUpdateCommand>()
                    .RegisterSingleton<IUpdateCommand<SizeArgUpdate>, SizeUpdateCommand>();
    }

    private void RegisterReadCommand()
    {
        Container
            .RegisterSingleton<IReadCommand<ItemReadArg>, ItemReadCommand>()
            .RegisterSingleton<IReadCommand<CategoryArgFilter>, CategoryReadCommand>()
            .RegisterSingleton<IReadCommand<SizeArgFilter>, SizeReadCommand>()
            .RegisterSingleton<IReadCommand<ImageArgFilter>, ImageReadCommand>()
            .RegisterSingleton<IReadCommand<StockArgFilter>, StockReadCommand>()
            .RegisterSingleton<IReadCommand<SizeArgFilter>, SizeReadCommand>();
    }
}