using DataToTable;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemImageTable : TextTable<ItemImage>
{
	public ItemImageTable(
		IColumnCalculator<ItemImage> columnCalculator) : base(columnCalculator)
    {
    }
		
	protected override void CreateTableHeader()
	{
		SetColumns();
	}

	private void SetColumns()
	{
		AddColumn(GetColumnData(nameof(ItemImage.Id)));
        AddColumn(GetColumnData(nameof(ItemImage.Item)));
        AddColumn(GetColumnData(nameof(ItemImage.ItemId)));
		AddColumn(GetColumnData(nameof(ItemImage.Path)));
	}

	protected override void CreateTableRow(ItemImage e)
	{
		AddValue(GetColumnData(nameof(ItemImage.Id)), e.Id.ToString());
		AddValue(GetColumnData(nameof(ItemImage.Item)), e.Item.Name);
		AddValue(GetColumnData(nameof(ItemImage.ItemId)), e.ItemId.ToString());
		AddValue(GetColumnData(nameof(ItemImage.Path)), e.Path);		
    }

	protected override void SetColumnsSize(List<ItemImage> paths)
	{
		SetColumn(nameof(ItemImage.Id), GetIdsLength(paths));
		SetColumn(nameof(ItemImage.Item), GetItemsLength(paths));
		SetColumn(nameof(ItemImage.ItemId), GetItemIdsLength(paths));
		SetColumn(nameof(ItemImage.Path), GetPathsLength(paths));
	}

	private static List<int> GetIdsLength(List<ItemImage> models)
    {
        var rows = models.Select(e => e.Id.ToString().Length).ToList();
		rows.Insert(0, nameof(ItemImage.Id).Length);
		return rows;
    }

	private static List<int> GetItemsLength(List<ItemImage> models)
    {
            var rows = models.Select(e => e.Item.Name.Length).ToList();
		rows.Insert(0, nameof(ItemImage.Item).Length);
		return rows;
    }

	private static List<int> GetItemIdsLength(List<ItemImage> models)
    {
            var rows = models.Select(e => e.ItemId.ToString().Length).ToList();
		rows.Insert(0, nameof(ItemImage.ItemId).Length);
		return rows;
    }

	private static List<int> GetPathsLength(List<ItemImage> models)
    {
        var rows = models.Select(e => e.Path.Length).ToList();
		rows.Insert(0, nameof(ItemImage.Path).Length);
		return rows;
    }
}