using AutoMapper;
using CLI.Core;
using CLI.Core.Lib;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemDetailInsertCommand
    : InsertCommand<IInventoryUnitOfWork, ItemDetail, ItemDetailArg>
{
    public ItemDetailInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override void InsertEntity(ItemDetail entity) =>
        UnitOfWork.ItemDetail.Insert(entity);
}