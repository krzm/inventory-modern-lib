using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class StockDetailInsertCommand
    : InsertCommand<IInventoryUnitOfWork, StockDetail, StockDetailArg>
{
    public StockDetailInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(StockDetail entity) =>
        UnitOfWork.StockDetail.Insert(entity);
}