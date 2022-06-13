using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class SizeInsertCommand
    : InsertCommand<IInventoryUnitOfWork, Size, SizeInsertArgs>
{
    public SizeInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(Size entity) =>
        UnitOfWork.Size.Insert(entity);
}