using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class CategoryInsertCommand
    : InsertCommand<IInventoryUnitOfWork, Category, CategoryArg>
{
    public CategoryInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(Category entity) =>
        UnitOfWork.Category.Insert(entity);
}