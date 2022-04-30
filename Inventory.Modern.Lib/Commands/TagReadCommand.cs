using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class TagReadCommand
    : ReadCommand<IInventoryUnitOfWork, Tag, SizeArgFilter>
{
    public TagReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Tag> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Tag> Get(SizeArgFilter model) =>
        UnitOfWork.Tag.Get(
            orderBy: t => t.OrderBy(p => p.Id)).ToList();
}