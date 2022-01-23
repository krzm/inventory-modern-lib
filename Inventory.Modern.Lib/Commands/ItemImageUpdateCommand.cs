using AutoMapper;
using CLI.Core;
using CLI.Core.Lib;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemImageUpdateCommand
	: UpdateCommand<IInventoryUnitOfWork, ItemImage, ItemImageArgUpdate, ItemImageUpdate>
{
	public ItemImageUpdateCommand(
		IInventoryUnitOfWork unitOfWork
		, IOutput output
		, IMapper mapper)
			: base(unitOfWork, output, mapper)
	{
	}

	protected override ItemImage GetById(int id) =>
		UnitOfWork.ItemImage.GetByID(id);
}