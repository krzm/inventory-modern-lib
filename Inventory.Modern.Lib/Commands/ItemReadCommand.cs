using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemReadCommand
    : ReadCommand<IInventoryUnitOfWork, Item, ItemArgFilter>
{
    public ItemReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Item> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Item> Get(ItemArgFilter model) =>
        UnitOfWork.Item.Get(
            orderBy: t => t.OrderBy(p => p.ItemCategory.Name)
            , includeProperties: nameof(Item.ItemCategory)).ToList();
}