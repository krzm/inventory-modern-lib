using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class CategoryReadCommand 
    : ReadCommand<IInventoryUnitOfWork, Category, CategoryArgFilter>
{
    public CategoryReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Category> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Category> Get(CategoryArgFilter model) =>
        UnitOfWork.Category.Get(
            includeProperties: "Parent,Children").ToList();
}