using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class TagInsertCommand
    : InsertCommand<IInventoryUnitOfWork, Tag, SizeArg>
{
    public TagInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(Tag entity) =>
        UnitOfWork.Tag.Insert(entity);
}