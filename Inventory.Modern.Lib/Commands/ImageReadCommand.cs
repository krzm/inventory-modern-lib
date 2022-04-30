using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class ImageReadCommand
	: ReadCommand<IInventoryUnitOfWork, Image, ItemImageArgFilter>
{
	public ImageReadCommand(
		IInventoryUnitOfWork unitOfWork
		, IOutput output
        , ILogger log
		, IDataToText<Image> textProvider)
			: base(unitOfWork, output, log, textProvider)
	{
	}

	protected override List<Image> Get(ItemImageArgFilter model)
    {
		return UnitOfWork.Image.Get(
			orderBy: t => t.OrderBy(p => p.ItemId)
			, includeProperties: "Item").ToList();
	}
}