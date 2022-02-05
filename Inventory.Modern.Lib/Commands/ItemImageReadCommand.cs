using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemImageReadCommand
	: ReadCommand<IInventoryUnitOfWork, ItemImage, ItemImageArgFilter>
{
	public ItemImageReadCommand(
		IInventoryUnitOfWork unitOfWork
		, IOutput output
		, IDataToText<ItemImage> textProvider)
			: base(unitOfWork, output, textProvider)
	{
	}

	protected override List<ItemImage> Get(ItemImageArgFilter model)
    {
		return UnitOfWork.ItemImage.Get(
			orderBy: t => t.OrderBy(p => p.ItemId)
			, includeProperties: "Item").ToList();
	}
}