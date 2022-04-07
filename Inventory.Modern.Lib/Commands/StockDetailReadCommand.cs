using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class StockDetailReadCommand
    : ReadCommand<IInventoryUnitOfWork, StockDetail, StockDetailArgFilter>
{
    public StockDetailReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<StockDetail> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<StockDetail> Get(StockDetailArgFilter model) =>
        UnitOfWork.StockDetail.Get(
            orderBy: t => t.OrderBy(p => p.Id)).ToList();
}