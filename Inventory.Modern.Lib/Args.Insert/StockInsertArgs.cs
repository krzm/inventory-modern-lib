using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class StockInsertArgs
    : Model
        , IArgumentModel
{
    [Operand(nameof(ItemId))
        , Required
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int ItemId { get; set; }

    [Option('t', "tagid")
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int? TagId { get; set; }

    [Option('d', "description")
        , MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }
}