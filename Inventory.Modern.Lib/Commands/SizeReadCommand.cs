using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class SizeReadCommand
    : ReadCommand<IInventoryUnitOfWork, Size, ItemDetailArgFilter>
{
    public SizeReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Size> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Size> Get(ItemDetailArgFilter model) =>
        UnitOfWork.Size.Get().ToList();
}