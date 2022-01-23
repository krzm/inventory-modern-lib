using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class StockArg : IArgumentModel
{
    [Operand(nameof(ItemId)), Required, Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int ItemId { get; set; }

    [Operand(nameof(ContainerId)), Required, Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int ContainerId { get; set; }

    [Operand, Required, DataType(DataType.Date)]
    public DateTime? Stored { get; set; }

    [Operand, DataType(DataType.Date)]
    public DateTime? Open { get; set; }

    [Operand, DataType(DataType.Date)]
    public DateTime? Used { get; set; }
    
    [Operand(nameof(StockDetailId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int? StockDetailId { get; set; }
}