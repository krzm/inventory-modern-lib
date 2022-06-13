using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class StockContainerInsertCommand
    : InsertManyToManyCommand<IInventoryUnitOfWork>
        , IStockContainerInsertCommand
{
    public StockContainerInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(int stockId, int containerId)
    {
        var stock = UnitOfWork.Stock.GetByID(stockId);
        var container = UnitOfWork.Container.GetByID(containerId);
        stock.Containers?.Add(container);
    }
}