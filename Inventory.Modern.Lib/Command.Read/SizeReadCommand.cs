using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class SizeReadCommand
    : ReadCommand<IInventoryUnitOfWork, Size, SizeArgFilter>
{
    public SizeReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Size> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Size> Get(SizeArgFilter model) =>
        UnitOfWork.Size.Get().ToList();
}