using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemDetailReadCommand
    : ReadCommand<IInventoryUnitOfWork, ItemDetail, ItemDetailArgFilter>
{
    public ItemDetailReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<ItemDetail> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<ItemDetail> Get(ItemDetailArgFilter model) =>
        UnitOfWork.ItemDetail.Get().ToList();
}