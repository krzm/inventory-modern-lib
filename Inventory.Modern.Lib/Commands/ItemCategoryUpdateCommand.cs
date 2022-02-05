using AutoMapper;
using CLIHelper;
using CRUDCommandHelper;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemCategoryUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, ItemCategory, ItemCategoryArgUpdate, ItemCategoryUpdate>
{
    public ItemCategoryUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override ItemCategory GetById(int id) =>
        UnitOfWork.ItemCategory.GetByID(id);
}