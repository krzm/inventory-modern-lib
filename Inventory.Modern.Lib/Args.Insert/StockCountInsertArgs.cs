using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class StockCountInsertArgs
    : Model
        , IArgumentModel
{
    [Operand(nameof(StockId))
        , Required
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int StockId { get; set; }

    [Operand(nameof(Count))
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int Count { get; set; }

    [Option('d', "description")
        , MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }
}