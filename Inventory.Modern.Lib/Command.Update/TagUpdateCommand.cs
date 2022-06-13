using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class TagUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, Tag, SizeArgUpdate, TagUpdate>
{
    public TagUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override Tag GetById(int id) =>
        UnitOfWork.Tag.GetByID(id);
}