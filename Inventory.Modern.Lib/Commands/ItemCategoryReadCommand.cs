using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemCategoryReadCommand 
    : ReadCommand<IInventoryUnitOfWork, ItemCategory, ItemCategoryArgFilter>
{
    public ItemCategoryReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<ItemCategory> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<ItemCategory> Get(ItemCategoryArgFilter model) =>
        UnitOfWork.ItemCategory.Get(
            includeProperties: "Parent,Children").ToList();
}