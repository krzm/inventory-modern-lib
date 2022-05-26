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

            .RegisterSingleton<IInsertCommand<ItemInsertArg>, ItemInsertCommand>()
            .RegisterSingleton<IInsertCommand<CategoryArg>, CategoryInsertCommand>()
            .RegisterSingleton<IInsertCommand<SizeArgs>, SizeInsertCommand>()
            .RegisterSingleton<IInsertCommand<ImageArg>, ImageInsertCommand>()
            .RegisterSingleton<IInsertCommand<StockArg>, StockInsertCommand>()
            .RegisterSingleton<IInsertCommand<SizeArgs>, SizeInsertCommand>()

            .RegisterSingleton<IUpdateCommand<ItemUpdateArg>, ItemUpdateCommand>()
            .RegisterSingleton<IUpdateCommand<CategoryArgUpdate>, CategoryUpdateCommand>()
            .RegisterSingleton<IUpdateCommand<SizeArgUpdate>, SizeUpdateCommand>()
            .RegisterSingleton<IUpdateCommand<ImageArgUpdate>, ImageUpdateCommand>()
            .RegisterSingleton<IUpdateCommand<StockArgUpdate>, StockUpdateCommand>()
            .RegisterSingleton<IUpdateCommand<SizeArgUpdate>, SizeUpdateCommand>();
    }
}