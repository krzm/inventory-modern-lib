using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ContainerReadCommand
    : ReadCommand<IInventoryUnitOfWork, Container, ContainerReadArg>
{
    public ContainerReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Container> textProvider)
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Container> Get(ContainerReadArg model) =>
        UnitOfWork.Container.Get(
            orderBy: t => t.OrderBy(p => p.Category!.Name)
            , includeProperties: nameof(Item.Category)).ToList();
}