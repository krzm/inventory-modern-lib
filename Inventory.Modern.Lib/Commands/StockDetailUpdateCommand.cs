using AutoMapper;
using CLIHelper;
using CRUDCommandHelper;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class StockDetailUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, StockDetail, StockDetailArgUpdate, StockDetailUpdate>
{
    public StockDetailUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override StockDetail GetById(int id) =>
        UnitOfWork.StockDetail.GetByID(id);
}