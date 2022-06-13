using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class StockReadCommand
    : ReadCommand<IInventoryUnitOfWork, Stock, StockArgFilter>
{
    public StockReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Stock> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Stock> Get(StockArgFilter model) =>
        UnitOfWork.Stock.Get(
            orderBy: t => t.OrderBy(p => p.Id)
            , includeProperties:$"{nameof(Stock.Item)}").ToList();
}