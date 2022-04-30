using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ImageInsertCommand
    : InsertCommand<IInventoryUnitOfWork, Image, ImageArg>
{
    public ImageInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override void InsertEntity(Image entity) =>
        UnitOfWork.Image.Insert(entity);
}