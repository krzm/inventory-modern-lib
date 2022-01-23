using CLI.Core;
using CLI.Core.Lib;
using DataToTable;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemCategoryReadCommand 
    : ReadCommand<IInventoryUnitOfWork, ItemCategory, ItemCategoryArgFilter>
{
    public ItemCategoryReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IDataToText<ItemCategory> textProvider)
            : base(unitOfWork, output, textProvider)
    {
    }

    protected override List<ItemCategory> Get(ItemCategoryArgFilter model) =>
        UnitOfWork.ItemCategory.Get(includeProperties: "Parent,Children").ToList();
}