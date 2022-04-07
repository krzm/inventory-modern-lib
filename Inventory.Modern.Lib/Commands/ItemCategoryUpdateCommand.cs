using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemCategoryUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, ItemCategory, ItemCategoryArgUpdate, ItemCategoryUpdate>
{
    public ItemCategoryUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override ItemCategory GetById(int id) =>
        UnitOfWork.ItemCategory.GetByID(id);
}