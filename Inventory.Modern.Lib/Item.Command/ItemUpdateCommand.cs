using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, Item, ItemUpdateArg, ItemUpdate>
{
    public ItemUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override Item GetById(int id) =>
        UnitOfWork.Item.GetByID(id);
}