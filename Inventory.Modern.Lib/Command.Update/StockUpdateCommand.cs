using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class StockUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, Stock, StockArgUpdate, StockUpdate>
{
    public StockUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override Stock GetById(int id) =>
        UnitOfWork.Stock.GetByID(id);
}