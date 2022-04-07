using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemCategoryInsertCommand
    : InsertCommand<IInventoryUnitOfWork, ItemCategory, ItemCategoryArg>
{
    public ItemCategoryInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(ItemCategory entity) =>
        UnitOfWork.ItemCategory.Insert(entity);
}