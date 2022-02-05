using AutoMapper;
using CLIHelper;
using CRUDCommandHelper;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class StockUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, Stock, StockArgUpdate, StockUpdate>
{
    public StockUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override Stock GetById(int id) =>
        UnitOfWork.Stock.GetByID(id);
}