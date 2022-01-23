using AutoMapper;
using CLI.Core;
using CLI.Core.Lib;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class StockInsertCommand
    : InsertCommand<IInventoryUnitOfWork, Stock, StockArg>
{
    public StockInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override void InsertEntity(Stock entity) =>
        UnitOfWork.Stock.Insert(entity);
}