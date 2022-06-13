using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ContainerInsertCommand
    : InsertCommand<IInventoryUnitOfWork, Container, ContainerInsertArgs>
{
    public ContainerInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(Container entity) =>
        UnitOfWork.Container.Insert(entity);
}