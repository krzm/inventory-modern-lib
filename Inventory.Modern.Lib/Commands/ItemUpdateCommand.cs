using AutoMapper;
using CLI.Core;
using CLI.Core.Lib;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, Item, ItemArgUpdate, ItemUpdate>
{
    public ItemUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override Item GetById(int id) =>
        UnitOfWork.Item.GetByID(id);
}