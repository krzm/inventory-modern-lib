using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemDetailInsertCommand
    : InsertCommand<IInventoryUnitOfWork, ItemDetail, ItemDetailArg>
{
    public ItemDetailInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(ItemDetail entity) =>
        UnitOfWork.ItemDetail.Insert(entity);
}