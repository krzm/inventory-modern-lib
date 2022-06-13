using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class StateInsertCommand
    : InsertCommand<IInventoryUnitOfWork, State, StateInsertArgs>
{
    public StateInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(State entity) =>
        UnitOfWork.State.Insert(entity);
}