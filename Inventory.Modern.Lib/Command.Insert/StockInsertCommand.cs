using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class StockInsertCommand
    : InsertCommand<IInventoryUnitOfWork, Stock, StockInsertArgs>
{
    public StockInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(Stock entity) =>
        UnitOfWork.Stock.Insert(entity);
}