using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ImageUpdateCommand
	: UpdateCommand<IInventoryUnitOfWork, Image, ItemImageArgUpdate, ImageUpdate>
{
	public ImageUpdateCommand(
		IInventoryUnitOfWork unitOfWork
		, ILogger log
		, IMapper mapper)
			: base(unitOfWork, log, mapper)
	{
	}

	protected override Image GetById(int id) =>
		UnitOfWork.Image.GetByID(id);
}