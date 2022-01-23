using CLI.Core;
using CLI.Core.Lib;
using DataToTable;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class StockDetailReadCommand
    : ReadCommand<IInventoryUnitOfWork, StockDetail, StockDetailArgFilter>
{
    public StockDetailReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IDataToText<StockDetail> textProvider)
            : base(unitOfWork, output, textProvider)
    {
    }

    protected override List<StockDetail> Get(StockDetailArgFilter model) =>
        UnitOfWork.StockDetail.Get(
            orderBy: t => t.OrderBy(p => p.Id)).ToList();
}