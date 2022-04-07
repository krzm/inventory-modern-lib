using AutoMapper;
using CLIHelper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ItemImageUpdateCommand
	: UpdateCommand<IInventoryUnitOfWork, ItemImage, ItemImageArgUpdate, ItemImageUpdate>
{
	public ItemImageUpdateCommand(
		IInventoryUnitOfWork unitOfWork
		, ILogger log
		, IMapper mapper)
			: base(unitOfWork, log, mapper)
	{
	}

	protected override ItemImage GetById(int id) =>
		UnitOfWork.ItemImage.GetByID(id);
}