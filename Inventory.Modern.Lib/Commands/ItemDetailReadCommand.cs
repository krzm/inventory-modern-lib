using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemDetailReadCommand
    : ReadCommand<IInventoryUnitOfWork, ItemDetail, ItemDetailArgFilter>
{
    public ItemDetailReadCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IDataToText<ItemDetail> textProvider)
            : base(unitOfWork, output, textProvider)
    {
    }

    protected override List<ItemDetail> Get(ItemDetailArgFilter model) =>
        UnitOfWork.ItemDetail.Get().ToList();
}