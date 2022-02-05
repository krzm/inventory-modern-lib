using AutoMapper;
using CLIHelper;
using CRUDCommandHelper;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class StockDetailInsertCommand
    : InsertCommand<IInventoryUnitOfWork, StockDetail, StockDetailArg>
{
    public StockDetailInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override void InsertEntity(StockDetail entity) =>
        UnitOfWork.StockDetail.Insert(entity);
}