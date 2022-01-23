using AutoMapper;
using CLI.Core;
using CLI.Core.Lib;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemImageInsertCommand
    : InsertCommand<IInventoryUnitOfWork, ItemImage, ItemImageArg>
{
    public ItemImageInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override void InsertEntity(ItemImage entity) =>
        UnitOfWork.ItemImage.Insert(entity);
}