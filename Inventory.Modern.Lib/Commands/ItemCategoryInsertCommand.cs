using AutoMapper;
using CLI.Core;
using CLI.Core.Lib;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemCategoryInsertCommand
    : InsertCommand<IInventoryUnitOfWork, ItemCategory, ItemCategoryArg>
{
    public ItemCategoryInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override void InsertEntity(ItemCategory entity) =>
        UnitOfWork.ItemCategory.Insert(entity);
}