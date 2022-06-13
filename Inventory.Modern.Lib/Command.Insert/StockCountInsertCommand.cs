using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class StockCountInsertCommand
    : InsertCommand<IInventoryUnitOfWork, StockCount, StockCountInsertArgs>
{
    public StockCountInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(StockCount entity) =>
        UnitOfWork.StockCount.Insert(entity);
}