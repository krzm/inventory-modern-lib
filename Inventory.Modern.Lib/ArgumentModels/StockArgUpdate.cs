using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class StockArgUpdate : ArgUpdate
{
    [Option('i', nameof(ItemId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int? ItemId { get; set; }

    [Option('c', nameof(ContainerId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int? ContainerId { get; set; }

    [Option('s', nameof(Stored)), DataType(DataType.Date)]
    public DateTime? Stored { get; set; }

    [Option('o', nameof(Open)), DataType(DataType.Date)]
    public DateTime? Open { get; set; }
    
    [Option('u', nameof(Used)), DataType(DataType.Date)]
    public DateTime? Used { get; set; }

    [Option('t', nameof(StockDetailId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int? StockDetailId { get; set; }
}