using AutoMapper;
using CLI.Core;
using CLI.Core.Lib;
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