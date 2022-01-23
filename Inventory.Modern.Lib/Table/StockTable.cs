using DataToTable;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class StockTable : TextTable<Stock>
{
	public StockTable(
		IColumnCalculator<Stock> columnCalculator)
			: base(columnCalculator)
	{
	}

	protected override void CreateTableHeader()
	{
		SetColumns();
	}

	private void SetColumns()
	{
		AddColumn(GetColumnData(nameof(Stock.Id)));
		AddColumn(GetColumnData(nameof(Stock.Item)));
		AddColumn(GetColumnData(nameof(Stock.ItemId)));
		AddColumn(GetColumnData(nameof(Stock.Container)));
		AddColumn(GetColumnData(nameof(Stock.ContainerId)));
		AddColumn(GetColumnData(nameof(Stock.Stored)));
		AddColumn(GetColumnData(nameof(Stock.Open)));
		AddColumn(GetColumnData(nameof(Stock.Used)));
		AddColumn(GetColumnData(nameof(Stock.StockDetailId)));
	}

	protected override void CreateTableRow(Stock e)
	{
		AddValue(GetColumnData(nameof(Stock.Id)), GetId(e));
		AddValue(GetColumnData(nameof(Stock.Item)), GetItem(e));
		AddValue(GetColumnData(nameof(Stock.ItemId)), GetItemId(e));
		AddValue(GetColumnData(nameof(Stock.Container)), GetContainer(e));
		AddValue(GetColumnData(nameof(Stock.ContainerId)), GetContainerId(e));
		AddValue(GetColumnData(nameof(Stock.Stored)), GetStored(e));
		AddValue(GetColumnData(nameof(Stock.Open)), GetOpen(e));
		AddValue(GetColumnData(nameof(Stock.Used)), GetUsed(e));
		AddValue(GetColumnData(nameof(Stock.StockDetailId)), GetStockDetailId(e));
	}

	private static string GetId(Stock e) => e.Id.ToString();

	private static string GetItem(Stock e) => e.Item.Name;

	private static string GetItemId(Stock e) => e.ItemId.ToString();

	private static string GetContainer(Stock e) => e.Container.Name;

	private static string GetContainerId(Stock e) => e.ContainerId.ToString();

	private static string GetStored(Stock e) => e.Stored.ToString();
	
	private static string GetOpen(Stock e) => e.Open.HasValue ? e.Open.Value.ToString() : "";

	private static string GetUsed(Stock e) => e.Used.HasValue ? e.Used.Value.ToString() : "";

	private static string GetStockDetailId(Stock e) => e.StockDetailId.HasValue ? e.StockDetailId.Value.ToString() : "";

	protected override void SetColumnsSize(List<Stock> paths)
	{
		SetColumn(nameof(Stock.Id), GetIdLength(paths));
		SetColumn(nameof(Stock.Item), GetItemLength(paths));
		SetColumn(nameof(Stock.ItemId), GetItemIdLength(paths));
		SetColumn(nameof(Stock.Container), GetContainerLength(paths));
		SetColumn(nameof(Stock.ContainerId), GetContainerIdLength(paths));
		SetColumn(nameof(Stock.Stored), GetStoredLength(paths));
		SetColumn(nameof(Stock.Open), GetOpenLength(paths));
		SetColumn(nameof(Stock.Used), GetUsedLength(paths));
		SetColumn(nameof(Stock.StockDetailId), GetStockDetailIdLength(paths));
	}

	private static List<int> GetIdLength(List<Stock> models)
	{
		var rows = models.Select(e => GetId(e).Length).ToList();
		rows.Insert(0, nameof(Stock.Id).Length);
		return rows;
	}

	private static List<int> GetItemLength(List<Stock> items)
	{
		var rows = items.Select(e => GetItem(e).Length).ToList();
		rows.Insert(0, nameof(Stock.Item).Length);
		return rows;
	}

	private static List<int> GetItemIdLength(List<Stock> models)
	{
		var rows = models.Select(e => GetItemId(e).Length).ToList();
		rows.Insert(0, nameof(Stock.ItemId).Length);
		return rows;
	}

	private static List<int> GetContainerLength(List<Stock> models)
	{
		var rows = models.Select(e => GetContainer(e).Length).ToList();
		rows.Insert(0, nameof(Stock.Container).Length);
		return rows;
	}

	private static List<int> GetContainerIdLength(List<Stock> models)
	{
		var rows = models.Select(e => GetContainerId(e).Length).ToList();
		rows.Insert(0, nameof(Stock.ContainerId).Length);
		return rows;
	}

	private static List<int> GetStoredLength(List<Stock> models)
	{
		var rows = models.Select(e => GetStored(e).Length).ToList();
		rows.Insert(0, nameof(Stock.Stored).Length);
		return rows;
	}

	private static List<int> GetOpenLength(List<Stock> models)
	{
		var rows = models.Select(e => GetOpen(e).Length).ToList();
		rows.Insert(0, nameof(Stock.Open).Length);
		return rows;
	}

	private static List<int> GetUsedLength(List<Stock> models)
	{
		var rows = models.Select(e => GetUsed(e).Length).ToList();
		rows.Insert(0, nameof(Stock.Used).Length);
		return rows;
	}

	private static List<int> GetStockDetailIdLength(List<Stock> models)
	{
		var rows = models.Select(e => GetStockDetailId(e).Length).ToList();
		rows.Insert(0, nameof(Stock.StockDetailId).Length);
		return rows;
	}
}