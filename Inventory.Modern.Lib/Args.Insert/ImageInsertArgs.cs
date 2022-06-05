using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ImageInsertArgs
    : Model
        , IArgumentModel
{
    [Operand("itemid"), Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int ItemId { get; set; }

    [Operand("path"), Required, MaxLength(PathMaxLength)]
    public string? Path { get; set; }

    [Option('d', "description"), MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }
}