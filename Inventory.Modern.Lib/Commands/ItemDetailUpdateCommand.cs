using AutoMapper;
using CLIHelper;
using CRUDCommandHelper;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemDetailUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, ItemDetail, ItemDetailArgUpdate, ItemDetailUpdate>
{
    public ItemDetailUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override ItemDetail GetById(int id) =>
        UnitOfWork.ItemDetail.GetByID(id);
}