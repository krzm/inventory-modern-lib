using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class SizeUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, Size, SizeArgUpdate, SizeUpdate>
{
    public SizeUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override Size GetById(int id) =>
        UnitOfWork.Size.GetByID(id);
}