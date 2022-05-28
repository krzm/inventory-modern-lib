using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class StockArg
    : Model
    , IArgumentModel
{
    [Operand(nameof(ItemId))
        , Required
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int ItemId { get; set; }

    [Operand(nameof(Description))
        , MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }

    [Operand(nameof(TagId))
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int? TagId { get; set; }
}