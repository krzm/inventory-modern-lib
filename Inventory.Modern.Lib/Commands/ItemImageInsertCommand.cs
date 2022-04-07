using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemImageInsertCommand
    : InsertCommand<IInventoryUnitOfWork, ItemImage, ItemImageArg>
{
    public ItemImageInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(ItemImage entity) =>
        UnitOfWork.ItemImage.Insert(entity);
}