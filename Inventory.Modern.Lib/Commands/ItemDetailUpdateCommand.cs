using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemDetailUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, ItemDetail, ItemDetailArgUpdate, ItemDetailUpdate>
{
    public ItemDetailUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override ItemDetail GetById(int id) =>
        UnitOfWork.ItemDetail.GetByID(id);
}