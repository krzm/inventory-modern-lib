using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemReadCommand
    : ReadCommand<IInventoryUnitOfWork, Item, ItemReadArg>
{
    public ItemReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Item> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Item> Get(ItemReadArg model) =>
        UnitOfWork.Item.Get(
            orderBy: t => t.OrderBy(p => p.Category!.Name)
            , includeProperties: nameof(Item.Category)).ToList();
}