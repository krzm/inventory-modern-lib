using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class StockReadCommand
    : ReadCommand<IInventoryUnitOfWork, Stock, StockArgFilter>
{
    public StockReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IDataToText<Stock> textProvider)
            : base(unitOfWork, output, textProvider)
    {
    }

    protected override List<Stock> Get(StockArgFilter model) =>
        UnitOfWork.Stock.Get(
            orderBy: t => t.OrderBy(p => p.Id)
            , includeProperties:$"{nameof(Stock.Item)},{nameof(Stock.Container)}").ToList();
}