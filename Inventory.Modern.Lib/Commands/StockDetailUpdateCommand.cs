using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class StockDetailUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, StockDetail, StockDetailArgUpdate, StockDetailUpdate>
{
    public StockDetailUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override StockDetail GetById(int id) =>
        UnitOfWork.StockDetail.GetByID(id);
}