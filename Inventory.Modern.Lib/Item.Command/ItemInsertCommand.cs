using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemInsertCommand
    : InsertCommand<IInventoryUnitOfWork, Item, ItemInsertArg>
{
    public ItemInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(Item entity) =>
        UnitOfWork.Item.Insert(entity);
}